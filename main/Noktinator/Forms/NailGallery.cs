using System.Collections.Generic;
using System.Windows.Forms;
using Noktinator.Util;
using System;

namespace Noktinator
{
    public partial class NailGallery : BaseForm
    {
        private int rows = 3;
        private int cols = 4;

        private List<Nail> nails;

        private int nailsPerPage;
        private int modifier;

        private int currentPageIndex = 0;

        public List<Button> nailButtons = new List<Button>();
        public int buttonIndex = -1;

        public NailGallery()
        {
            InitializeComponent();

            this.nails = new List<Nail>();
            this.nailsPerPage = this.rows * this.cols;

            this.KeyDown += MyKeyDown;
            this.KeyPreview = true;
            this.FormClosing += FormClose;
            CenterToScreen();
        }
        private void NailGalleryLoad(object sender, EventArgs e)
        {
            InitializeNails();
            DisplayItems();
        }

        private void FormClose(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MyKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Navigator.GotoRetain<StartMenu, NailGallery>();
            else if (e.KeyCode == Keys.R)
                RefreshNails();
            else if (e.KeyCode == Keys.O)
                JsonUtil.OpenNailsJson();
            else if (e.KeyCode == Keys.Down)
                this.FirstPage();
            else if (e.KeyCode == Keys.Left)
                this.PreviousPage();
            else if (e.KeyCode == Keys.Right)
                this.NextPage();
            else if (e.KeyCode == Keys.Up)
                this.LastPage();
        }
        private void InitializeNails()
        {
            nails = JsonUtil.LoadNails();
            nails.ForEach(n => n.Update());
        }

        private void ClickButton(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            if (e.Button == MouseButtons.Right)
            {
                ConfirmDelete cd = new ConfirmDelete();
                buttonIndex = nailButtons.IndexOf(btn);
                cd.Show();
                Enabled = false;
            }
        }

        private void DisplayItems()
        {
            nailButtons.Clear();

            this.modifier = nails.Count % this.nailsPerPage == 0 ? -1 : 0;

            this.grid.Controls.Clear();

            int startIndex = currentPageIndex * this.nailsPerPage;
            int endIndex = Math.Min(startIndex + this.nailsPerPage, nails.Count);
            this.itemInPageLabel.Text = nails.Count > 0 ? $"{startIndex + 1} - {endIndex}" : "No nails";

            for (int i = startIndex; i < endIndex; i++)
            {
                Nail nail = this.nails[i];
                Button button = new Button();

                button.BackgroundImage = nail.GetImage();
                button.BackgroundImageLayout = ImageLayout.Zoom;
                button.Click += (object sender, EventArgs e) => new NailDetailsPage(nail, nails.IndexOf(nail)).ShowDialog();

                //desni klik za deletovanje
                button.MouseDown += ClickButton;

                nailButtons.Add(button);
                nailButtons[i % nailButtons.Count].Name = i.ToString();

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
            if (currentPageIndex < (nails.Count / this.nailsPerPage) + modifier)
            {
                currentPageIndex++;
                DisplayItems();
            }
        }
        private void LastPage()
        {
            if (currentPageIndex != nails.Count / this.nailsPerPage + modifier)
            {
                currentPageIndex = nails.Count / this.nailsPerPage + modifier;
                DisplayItems();
            }
        }
        public void RefreshNails()
        {
            nails = JsonUtil.LoadNails();
            nails.ForEach(n => n.Update());
            currentPageIndex = 0;
            DisplayItems();
        }

        private void BackBtnClick(object sender, EventArgs e)
        {
            Navigator.GotoRetain<StartMenu, NailGallery>();
        }

        private void FullLeftClick(object sender, EventArgs e) => FirstPage();
        private void LeftClick(object sender, EventArgs e) => PreviousPage();
        private void RightClick(object sender, EventArgs e) => NextPage();
        private void FullRightClick(object sender, EventArgs e) => LastPage();

        private void RefreshBtnClick(object sender, EventArgs e) => RefreshNails();
        private void OpenJsonClick(object sender, EventArgs e) => JsonUtil.OpenNailsJson();

        private void NailGallery_EnabledChanged(object sender, EventArgs e)
        {

        }
    }
}
