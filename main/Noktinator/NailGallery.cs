using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace Noktinator
{
    public partial class NailGallery : Form
    {
        private int totalItemCount = 100;
        private int rows = 3;
        private int cols = 4;

        private List<Nail> nails;
        private List<Nail> filteredNails;

        private int nailsPerPage;
        private int modifier;

        private int currentPageIndex = 0;
        private string searchBarText;

        public NailGallery()
        {
            InitializeComponent();

            this.nails = new List<Nail>();
            this.filteredNails = new List<Nail>();
            this.nailsPerPage = this.rows * this.cols;
            this.modifier = filteredNails.Count % this.nailsPerPage == 0 ? 0 : -1;

            this.KeyDown += MyKeyDown;
            this.KeyPreview = true;
            this.FormClosing += FormClose;

        }
        private void NailGalleryLoad(object sender, EventArgs e)
        {
            InitializeNails();
            DisplayItems();
            this.searchBar.TabIndex = 0;
        }

        private void FormClose(object sender, EventArgs e)
        {
            Application.Exit();
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
            else if (e.KeyCode == Keys.Back && e.Modifiers == Keys.Control)
                this.searchBar.Text = string.Empty;
            else if (e.KeyCode == Keys.I && e.Modifiers == Keys.Control)
            {
                MessageBox.Show("Nails: " + nails.Count.ToString());
                MessageBox.Show("Filtered: " + filteredNails.Count.ToString());
            }
        }

        private void InitializeNails()
        {
            //nails = JsonUtils.LoadNails();
            nails.Add(new Nail(NailShape.Lipstick, nailColor: Color.Red, pattern: NailPattern.LeafStyle, patternColor: Color.Orange));
            nails.Add(new Nail(NailShape.Stiletto, nailColor: Color.Yellow, pattern: NailPattern.LeavesStyle, patternColor: Color.LightBlue)); nails.Add(new Nail(NailShape.Almond, nailColor: Color.Green, pattern: NailPattern.FireStyle, patternColor: Color.Magenta));
            nails.Add(new Nail(NailShape.Wide, nailColor: Color.Blue, pattern: NailPattern.StarsStyle, patternColor: Color.Pink));
            nails.Add(new Nail(NailShape.Lipstick, nailColor: Color.Red, pattern: NailPattern.LeafStyle, patternColor: Color.Orange));
            nails.Add(new Nail(NailShape.Almond, nailColor: Color.Green, pattern: NailPattern.FireStyle, patternColor: Color.Magenta));
            nails.Add(new Nail(NailShape.Stiletto, nailColor: Color.Yellow, pattern: NailPattern.LeavesStyle, patternColor: Color.LightBlue)); nails.Add(new Nail(NailShape.Almond, nailColor: Color.Green, pattern: NailPattern.FireStyle, patternColor: Color.Magenta));
            nails.Add(new Nail(NailShape.Wide, nailColor: Color.Blue, pattern: NailPattern.StarsStyle, patternColor: Color.Pink));
            nails.Add(new Nail(NailShape.Stiletto, nailColor: Color.Yellow, pattern: NailPattern.LeavesStyle, patternColor: Color.LightBlue)); nails.Add(new Nail(NailShape.Almond, nailColor: Color.Green, pattern: NailPattern.FireStyle, patternColor: Color.Magenta));
            nails.Add(new Nail(NailShape.Lipstick, nailColor: Color.Red, pattern: NailPattern.LeafStyle, patternColor: Color.Orange));
            nails.Add(new Nail(NailShape.Stiletto, nailColor: Color.Yellow, pattern: NailPattern.LeavesStyle, patternColor: Color.LightBlue)); nails.Add(new Nail(NailShape.Almond, nailColor: Color.Green, pattern: NailPattern.FireStyle, patternColor: Color.Magenta));
            nails.Add(new Nail(NailShape.Wide, nailColor: Color.Blue, pattern: NailPattern.StarsStyle, patternColor: Color.Pink));
            nails.Add(new Nail(NailShape.Lipstick, nailColor: Color.Red, pattern: NailPattern.LeafStyle, patternColor: Color.Orange));
            nails.Add(new Nail(NailShape.Wide, nailColor: Color.Blue, pattern: NailPattern.StarsStyle, patternColor: Color.Pink));
            nails.Add(new Nail(NailShape.Wide, nailColor: Color.Blue, pattern: NailPattern.StarsStyle, patternColor: Color.Pink));
            nails.Add(new Nail(NailShape.Lipstick, nailColor: Color.Red, pattern: NailPattern.LeafStyle, patternColor: Color.Orange));
            nails.Add(new Nail(NailShape.Stiletto, nailColor: Color.Yellow, pattern: NailPattern.LeavesStyle, patternColor: Color.LightBlue)); nails.Add(new Nail(NailShape.Almond, nailColor: Color.Green, pattern: NailPattern.FireStyle, patternColor: Color.Magenta));
            nails.Add(new Nail(NailShape.Wide, nailColor: Color.Blue, pattern: NailPattern.StarsStyle, patternColor: Color.Pink));
            nails.Add(new Nail(NailShape.Stiletto, nailColor: Color.Yellow, pattern: NailPattern.LeavesStyle, patternColor: Color.LightBlue)); nails.Add(new Nail(NailShape.Almond, nailColor: Color.Green, pattern: NailPattern.FireStyle, patternColor: Color.Magenta));
            nails.Add(new Nail(NailShape.Lipstick, nailColor: Color.Red, pattern: NailPattern.LeafStyle, patternColor: Color.Orange));
            nails.Add(new Nail(NailShape.Lipstick, nailColor: Color.Red, pattern: NailPattern.LeafStyle, patternColor: Color.Orange));
            nails.Add(new Nail(NailShape.Stiletto, nailColor: Color.Yellow, pattern: NailPattern.LeavesStyle, patternColor: Color.LightBlue)); nails.Add(new Nail(NailShape.Almond, nailColor: Color.Green, pattern: NailPattern.FireStyle, patternColor: Color.Magenta));
            nails.Add(new Nail(NailShape.Wide, nailColor: Color.Blue, pattern: NailPattern.StarsStyle, patternColor: Color.Pink));
            nails.Add(new Nail(NailShape.Lipstick, nailColor: Color.Red, pattern: NailPattern.LeafStyle, patternColor: Color.Orange));
            nails.Add(new Nail(NailShape.Stiletto, nailColor: Color.Yellow, pattern: NailPattern.LeavesStyle, patternColor: Color.LightBlue));
            nails.Add(new Nail(NailShape.Wide, nailColor: Color.Blue, pattern: NailPattern.StarsStyle, patternColor: Color.Pink));
            nails.Add(new Nail(NailShape.Stiletto, nailColor: Color.Yellow, pattern: NailPattern.LeavesStyle, patternColor: Color.LightBlue)); nails.Add(new Nail(NailShape.Almond, nailColor: Color.Green, pattern: NailPattern.FireStyle, patternColor: Color.Magenta));
            nails.Add(new Nail(NailShape.Lipstick, nailColor: Color.Red, pattern: NailPattern.LeafStyle, patternColor: Color.Orange));
            nails.Add(new Nail(NailShape.Wide, nailColor: Color.Blue, pattern: NailPattern.StarsStyle, patternColor: Color.Pink));
            //JsonUtils.SaveNails(nails);
            filteredNails.Clear();
            filteredNails.AddRange(nails);
            //filteredNails = nails;
        }
        private void DisplayItems()
        {
            this.indexInput.Text = $"{currentPageIndex + 1}";


            this.grid.Controls.Clear();

            int startIndex = currentPageIndex * this.nailsPerPage;
            int endIndex = Math.Min(startIndex + this.nailsPerPage, filteredNails.Count);

            for (int i = startIndex; i < endIndex; i++)
            {
                Nail nail = this.filteredNails[i];
                Button button = new Button();

                button.BackgroundImage = nail.GetImage();
                button.BackgroundImageLayout = ImageLayout.Zoom;
                button.Click += (object sender, EventArgs e) => new DetaljiONoktu(nail, filteredNails.IndexOf(nail)).ShowDialog();

                button.Dock = DockStyle.Fill;
                grid.Controls.Add(button);
            }

            grid.RowStyles.Clear();
            grid.ColumnStyles.Clear();

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

            // TRENUTNO NE RADI
            //if (SearchBarTextValid())
            //    filteredNails =
            //        filteredNails.Where(
            //            nail => searchBarText.Split(' ').Select(s => s.Trim().ToLower())
            //            .All(str => new string[] {
            //                $"{nail.nailShape}",
            //                $"{nail.nailPattern}"}
            //                .ToList().Select(a => a.Trim().ToLower())
            //                .Any(attribute => attribute.Contains(str)))).ToList();

            currentPageIndex = 0;
            DisplayItems();
        }

        private void FirstPage()
        {
            if (currentPageIndex != 0)
            {
                currentPageIndex = 0;
                DisplayItems();
            }
        }
        private void PreviousPage()
        {
            if (currentPageIndex > 0)
            {
                currentPageIndex--;
                DisplayItems();
            }
        }
        private void NextPage()
        {
            if (currentPageIndex < (filteredNails.Count / this.nailsPerPage) + modifier)
            {
                currentPageIndex++;
                DisplayItems();
            }
        }
        private void LastPage()
        {
            //if (currentPageIndex != filteredNails.Count / this.nailsPerPage + modifier)
            //{
                currentPageIndex = filteredNails.Count / this.nailsPerPage + modifier;
                DisplayItems();
            //}
        }

        private bool SearchBarTextValid()
        {
            bool isNotNull = searchBarText != null;
            bool isNotEmpty = searchBar.Text != string.Empty;
            return isNotNull && isNotEmpty;
        }

        private void IndexInputChanged(object sender, EventArgs e)
        {
            try
            {
                currentPageIndex = int.Parse(indexInput.Text) - 1;
                if (currentPageIndex < 0 || currentPageIndex > totalItemCount / this.nailsPerPage + this.modifier)
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
            //Filter();
        }

        private void BackBtnClick(object sender, EventArgs e)
        {
            StartMenu sm = (StartMenu)Application.OpenForms["StartMenu"];
            sm.Show();
            this.Hide();
        }

        private void FullLeftClick(object sender, EventArgs e) => FirstPage();
        private void LeftClick(object sender, EventArgs e) => PreviousPage();
        private void RightClick(object sender, EventArgs e) => NextPage();
        private void FullRightClick(object sender, EventArgs e) => LastPage();
    }
}
