namespace nail_gallery
{
    public partial class NailGallery : Form
    {
        private int totalItemCount = 10_000;
        private int rows = 3;
        private int cols = 4;

        private List<Nail> nails;
        private List<Nail> filteredNails;

        private int rc;
        private int modifier;

        private int currentIndex = 0;
        private string searchBarText;

        public NailGallery()
        {
            InitializeComponent();

            this.nails = [];
            this.filteredNails = [];
            this.rc = this.rows * this.cols;
            this.modifier = filteredNails.Count % this.rc == 0 ? 0 : -1;

            this.KeyDown += MyKeyDown!;
            this.KeyPreview = true;
        }

        private void NailGalleryLoad(object sender, EventArgs e)
        {
            InitializeNails();
            DisplayItems();

            this.searchBar.TabIndex = 0;
        }

        private void MyKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Application.Exit();
            else if (e.KeyCode == Keys.Enter)
                Filter();
            else if (e.KeyCode == Keys.Down)
                this.FirstPage();
            else if (e.KeyCode == Keys.Left)
                this.PreviousPage();
            else if (e.KeyCode == Keys.Right)
                this.NextPage();
            else if (e.KeyCode == Keys.Up)
                this.LastPage();
            else if (e.KeyCode == Keys.I && e.Modifiers == Keys.Control)
            {
                MessageBox.Show(GetRgb(Color.Red), "Debug");
            }
        }

        private void InitializeNails()
        {
            for (int i = 0; i < totalItemCount; i++)
                nails.Add(Nail.Random());
            filteredNails = nails;
        }
        private void DisplayItems()
        {
            this.indexInput.Text = $"{currentIndex + 1}";


            this.grid.Controls.Clear();

            int startIndex = currentIndex * this.rc;
            int endIndex = Math.Min(startIndex + this.rc, filteredNails.Count);

            for (int i = startIndex; i < endIndex; i++)
            {
                Nail nail = this.filteredNails[i];
                Button button = new Button();

                string str = string.Empty;
                str += $"{nail.shape}";
                str += "\n";
                str += $"{nail.pattern}";
                button.Text = str;

                button.BackColor = nail.shapeColor;
                //button.ForeColor = nail.patternColor;

                button.Click += (object _, EventArgs _) => MessageBox.Show(nail.Info(), $"Nail {filteredNails.IndexOf(nail) + 1}");

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
        private void Filter()
        {
            filteredNails = nails;

            if (SearchBarTextValid())
                filteredNails =
                    filteredNails.Where(
                        n => searchBarText.Split(" ").Select(s => s.Trim().ToLower()).All(
                            x => new string[] {
                                $"{filteredNails.IndexOf(n) + 1}",
                            $"{n.shape}",
                            $"{n.pattern}",
                            $"{GetRgb(n.shapeColor)}",
                            $"{GetRgb(n.patternColor)}"
                                    }
                            .ToList().Select(a => a.Trim().ToLower()).Any(attribute => attribute
                            .Contains(x)))).ToList();

            currentIndex = 0;
            DisplayItems();
        }
        private string GetRgb(Color color, char separator = ',', char start = '(', char end = ')')
        {
            int red = color.R;
            int green = color.G;
            int blue = color.B;
            return $"{start}{red}{separator}{green}{separator}{blue}{end}";
        }
        private string ReturnMessage(string message)
        {
            MessageBox.Show(message);
            return message;
        }
        private T Return<T>(T t) => t;

        private void FirstPage()
        {
            if (currentIndex != 0)
            {
                currentIndex = 0;
                DisplayItems();
            }
        }
        private void PreviousPage()
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                DisplayItems();
            }
        }
        private void NextPage()
        {
            if (currentIndex < (filteredNails.Count / this.rc) + modifier)
            {
                currentIndex++;
                DisplayItems();
            }
        }
        private void LastPage()
        {
            if (currentIndex != filteredNails.Count / this.rc + modifier)
            {
                currentIndex = filteredNails.Count / this.rc + modifier;
                DisplayItems();
            }
        }

        private bool SearchBarTextValid()
        {
            bool isNotNull = searchBar.Text != null;
            bool isNotEmpty = searchBar.Text != string.Empty;
            return isNotNull && isNotEmpty;
        }

        private void FullLeftClick(object sender, EventArgs e) => FirstPage();
        private void LeftClick(object sender, EventArgs e) => PreviousPage();
        private void RightClick(object sender, EventArgs e) => NextPage();
        private void FullRightClick(object sender, EventArgs e) => LastPage();

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

        private void SearchBarTextChanged(object sender, EventArgs e)
        {
            searchBarText = searchBar.Text.Trim().ToLower();
            Filter();
        }
    }

    public class Nail
    {
        private NailShape _shape;
        private NailPattern _pattern;
        private Color _shapeColor;
        private Color _patternColor;

        public Nail(
            NailShape shape = NailShape.Almond,
            NailPattern pattern = NailPattern.FireStyle,
            Color nailColor = default,
            Color patternColor = default)
        {
            this._shape = shape;
            this._pattern = pattern;
            this._shapeColor = nailColor;
            this._patternColor = patternColor;
        }

        public NailShape shape
        {
            get { return _shape; }
            set { _shape = value; }
        }
        public NailPattern pattern
        {
            get { return _pattern; }
            set { _pattern = value; }
        }
        public Color shapeColor
        {
            get { return _shapeColor; }
            set { _shapeColor = value; }
        }
        public Color patternColor
        {
            get { return _patternColor; }
            set { _patternColor = value; }
        }

        public String Info()
        {
            Color sc = this._shapeColor;
            Color pc = this._patternColor;
            string nailColorTxt = $"({sc.R},{sc.G},{sc.B})";
            string patternColorTxt = $"({pc.R},{pc.G},{pc.B})";
            return $"    Shape - {this._shape}\n    Pattern - {this._pattern}\n    NailColor - {nailColorTxt}\n    PatternColor - {patternColorTxt}";
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
