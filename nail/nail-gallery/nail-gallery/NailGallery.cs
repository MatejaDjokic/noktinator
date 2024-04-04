using System.Security.Cryptography;

namespace nail_gallery
{
    public partial class NailGallery : Form
    {
        private int totalItemCount = 100;
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

                button.Text = "";
                button.BackgroundImage = nail.GetImage();
                button.BackgroundImageLayout = ImageLayout.Zoom;
                button.Click += (_, _) => new CustomDialog(nail, filteredNails.IndexOf(nail)).ShowDialog();


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
                            $"{n.pattern}"}
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

    class CustomDialog : Form
    {
        public Nail nail;
        public CustomDialog(Nail nail, int i)
        {
            this.nail = nail;

            this.Size = new Size(600, 400);
            CenterToScreen();

            this.KeyDown += (object sender, KeyEventArgs e) =>
            {
                if (e.KeyCode == Keys.Escape) this.Close();
            };

            Text = $"Nail {i + 1}";

            TableLayoutPanel table = new TableLayoutPanel()
            {
                Dock = DockStyle.Fill,
                RowCount = 1,
                ColumnCount = 3,
                RowStyles = { new RowStyle(SizeType.Percent, 100f) },
                ColumnStyles = {
                    new ColumnStyle(SizeType.Percent, 33f),
                    new ColumnStyle(SizeType.Percent, 33f),
                    new ColumnStyle(SizeType.Percent, 33f),
                },
            };
            this.Controls.Add(table);

            Label l1 = new Label()
            {
                Text = $"{nail.shape}",
                Dock = DockStyle.Fill,
                BackColor = nail.nailColor,
                Font = new Font("Arial", 12),
                TextAlign = ContentAlignment.MiddleCenter,
            };
            table.Controls.Add(l1, 0, 0);

            Label l2 = new Label()
            {
                Text = $"{nail.pattern}",
                Dock = DockStyle.Fill,
                BackColor = nail.patternColor,
                Font = new Font("Arial", 12),
                TextAlign = ContentAlignment.MiddleCenter,
            };
            table.Controls.Add(l2, 1, 0);

            Label l3 = new Label()
            {
                Text = $"Skin Color",
                Dock = DockStyle.Fill,
                BackColor = nail.skinColor,
                Font = new Font("Arial", 12),
                TextAlign = ContentAlignment.MiddleCenter,
            };
            table.Controls.Add(l3, 2, 0);
        }
    }
}
