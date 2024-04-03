using System.Drawing.Design;
using System.Reflection.Metadata;

namespace nail_gallery
{
    public partial class NailGallery : Form
    {
        private List<Nail> items;
        private int currentIndex = 0;
        private int totalItemCount = 100;
        private int rows = 3;
        private int cols = 4;
        private int rc;
        private int modifier;

        public NailGallery()
        {
            InitializeComponent();

            this.items = new List<Nail>();
            this.rc = this.rows * this.cols;
            this.modifier = items.Count % this.rc == 0 ? 0 : -1;

            // Register keydown event
            this.KeyDown += MyKeyDown!;
            this.KeyPreview = true;
        }

        private void MyKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Application.Exit();
        }
        private void NailGalleryLoad(object sender, EventArgs e)
        {
            InitializeNails();
            DisplayItems();
        }
        private void InitializeNails()
        {
            for (int i = 0; i < totalItemCount; i++)
                items.Add(Nail.Random());
        }
        private void DisplayItems()
        {
            this.indexInput.Text = $"{currentIndex + 1}";


            this.grid.Controls.Clear();

            int startIndex = currentIndex * this.rc;
            int endIndex = Math.Min(startIndex + this.rc, items.Count);

            for (int i = startIndex; i < endIndex; i++)
            {
                Nail nail = this.items[i];
                Button button = new Button();
                button.Text = nail.Info(i);
                button.TextAlign = ContentAlignment.MiddleLeft;
                button.Dock = DockStyle.Fill;
                grid.Controls.Add(button);
            }

            grid.RowStyles.Clear();
            grid.RowCount = this.rows;
            grid.ColumnCount = this.cols;
            for (int i = 0; i < this.rows; i++)
                grid.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / this.rows));
            for (int i = 0; i < this.cols; i++)
                grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / this.cols));
        }
        private void IndexInputChanged(object sender, EventArgs e)
        {
            try
            {
                currentIndex = int.Parse(indexInput.Text) - 1;
                if (currentIndex < 0 || currentIndex > totalItemCount / this.rc + this.modifier)
                    throw new Exception();
                indexInput.ForeColor = Color.Black;
                DisplayItems();
            }
            catch
            {
                indexInput.ForeColor = Color.Red;
            }
        }
        private void FullLeftClick(object sender, EventArgs e)
        {

            if (currentIndex != 0)
            {
                currentIndex = 0;
                DisplayItems();
            }
        }
        private void LeftClick(object sender, EventArgs e)
        {

            if (currentIndex > 0)
            {
                currentIndex--;
                DisplayItems();
            }
        }
        private void RightClick(object sender, EventArgs e)
        {

            if (currentIndex < (items.Count / this.rc) + modifier)
            {
                currentIndex++;
                DisplayItems();
            }
        }
        private void FullRightClick(object sender, EventArgs e)
        {

            if (currentIndex != items.Count / this.rc + modifier)
            {
                currentIndex = items.Count / this.rc + modifier;
                DisplayItems();
            }
        }
    }

    public class Nail
    {
        public NailShape shape;
        public NailPattern pattern;
        public Color shapeColor;
        public Color patternColor;
        public Nail(
            NailShape shape = NailShape.Almond,
            NailPattern pattern = NailPattern.FireStyle,
            Color nailColor = default,
            Color patternColor = default)
        {
            this.shape = shape;
            this.pattern = pattern;
            this.shapeColor = nailColor;
            this.patternColor = patternColor;
        }
        public String Info(int index)
        {
            Color sc = this.shapeColor;
            Color pc = this.patternColor;
            string nailColorTxt = $"rgb({sc.R},{sc.G},{sc.B})";
            string patternColorTxt = $"rgb({pc.R},{pc.G},{pc.B})";
            return $"Nail {index + 1}:\n    Shape - {this.shape}\n    Pattern - {this.pattern}\n    NailColor - {nailColorTxt}\n    PatternColor - {patternColorTxt}";
        }
        public static Nail Random()
        {
            return new Nail(
                shape: Nail.RandomShape(),
                pattern: Nail.RandomPattern(),
                nailColor: Nail.RandomColor(),
                patternColor: Nail.RandomColor()
            );
        }
        private static NailShape RandomShape()
        {
            return (NailShape)Nail.RandomIndexForEnum<NailShape>();
        }
        private static NailPattern RandomPattern()
        {
            return (NailPattern)Nail.RandomIndexForEnum<NailPattern>();
        }
        private static int RandomIndexForEnum<T>()
        {
            Random rnd = new Random();
            int enumLength = Enum.GetValues(typeof(T)).Length;
            return rnd.Next(enumLength);
        }
        private static Color RandomColor()
        {
            Random rnd = new Random();
            return Color.FromArgb(
                red: rnd.Next(256),
                green: rnd.Next(256),
                blue: rnd.Next(256)
            );
        }
    }

    public enum NailShape
    {
        Almond,
        Ballerina,
        Lipstick,
        MountainPeak,
        Oval,
        Rounded,
        Short,
        Squoval,
        Stiletto,
        Wide
    }

    public enum NailPattern
    {
        FireStyle,
        LeafStyle,
        StarsStyle,
        HeartsStyle,
        LeavesStyle
    }
}
