using System.Collections.Generic;
using System.Windows.Forms;
using Noktinator.Forms;
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
        public int pressedButtonIndex = -1;

        public NailGallery()
        {
            InitializeComponent();

            this.nails = new List<Nail>();
            this.nailsPerPage = this.rows * this.cols;

            this.KeyDown += NailGalleryKeyDown;
            this.KeyPreview = true;
            CenterToScreen();
        }
        private void NailGalleryLoad(object sender, EventArgs e)
        {
            InitializeNails();
            DisplayItems();
        }

        // WHAT TO DO WHEN A KEY IS PRESSED
        private void NailGalleryKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape: Navigator.GotoRetain<StartMenu, NailGallery>(); break;
                case Keys.R: RefreshNails(); break;
                case Keys.O: JsonUtil.OpenNailsJson(); break;
                case Keys.Down: this.FirstPage(); break;
                case Keys.Left: this.PreviousPage(); break;
                case Keys.Right: this.NextPage(); break;
                case Keys.Up: this.LastPage(); break;
            }
        }

        // READ THE NAILS FROM THE nails.json FILE AND UPDATES THEM
        private void InitializeNails()
        {
            nails = JsonUtil.LoadNails();
            nails.ForEach(n => n.Update());
        }

        // DISPLAYS THE CERTAIN AMOUNT OF NAILS THAT IS PREDEFINED 
        private void DisplayItems()
        {
            //nailButtons.Clear();

            // UPDATE THE MODIFIER THAT DETERMINES IF TO DRAW THE LAST PAGE
            this.modifier = nails.Count % this.nailsPerPage == 0 ? -1 : 0;

            // CLEAR ALL CURRENTYL VISIBLE NAILS
            this.grid.Controls.Clear();

            // DETERMINE THE START AND END INDECIES FOR THE NEW SET OF NAILS
            int startIndex = currentPageIndex * this.nailsPerPage;
            int endIndex = Math.Min(startIndex + this.nailsPerPage, nails.Count);

            // UPDATE THE TEXT THAT SHOWS WHAT NAILS ARE SHOWN ON THE SCREEN
            // IF THERE ARE NONE OR IF THERE IS ONLY ONE SHOW THE ACCORDING TEXT
            if (nails.Count == 0)
                this.itemInPageLabel.Text = "No Nails";
            else if (nails.Count == 1)
                this.itemInPageLabel.Text = "1";
            else
                this.itemInPageLabel.Text = $"{startIndex + 1} - {endIndex}";

            // ITERATE FROM THE START TO END INDICE
            // TO GET THE NEW SET OF NAILS
            // CREATE THE BUTTONS THAT SHOW THEM
            for (int i = startIndex; i < endIndex; i++)
            {
                Nail nail = this.nails[i];
                Button button = new Button();

                button.BackgroundImage = nail.GetImage();
                button.BackgroundImageLayout = ImageLayout.Zoom;
                button.FlatStyle = FlatStyle.Flat;

                button.Click += (object sender, EventArgs e) => new ActionPanel(nail, nails.IndexOf(nail)).ShowDialog();

                nailButtons.Add(button);
                nailButtons[i % nailButtons.Count].Name = i.ToString();

                button.Dock = DockStyle.Fill;
                grid.Controls.Add(button);
            }

            // CLEAR THE STYLES FOR THE GRID THAT HOLD THE NAILS
            grid.RowStyles.Clear();
            grid.ColumnStyles.Clear();

            // SET THE ROW AND COLUMN COUNTS
            grid.RowCount = this.rows;
            grid.ColumnCount = this.cols;

            // SET THE APPROPRIATE STYLES FOR THE ROWS AND COLUMNS
            for (int i = 0; i < this.rows; i++)
                grid.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / this.rows));
            for (int i = 0; i < this.cols; i++)
                grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / this.cols));
        }

        // IF POSSIBLE GO TO THE FIRST PAGE
        private void FirstPage()
        {
            if (currentPageIndex != 0)
            {
                currentPageIndex = 0;
                DisplayItems();
            }
        }
        // IF POSSIBLE GO TO THE PREVIOUS PAGE
        private void PreviousPage()
        {
            if (currentPageIndex > 0)
            {
                currentPageIndex--;
                DisplayItems();
            }
        }
        // IF POSSIBLE GO TO THE NEXT PAGE
        private void NextPage()
        {
            int maxIndex = (nails.Count / this.nailsPerPage) + modifier;
            if (currentPageIndex < maxIndex)
            {
                currentPageIndex++;
                DisplayItems();
            }
        }
        // IF POSSIBLE GO TO THE LAST PAGE
        private void LastPage()
        {
            int maxIndex = (nails.Count / this.nailsPerPage) + modifier;
            if (currentPageIndex != maxIndex)
            {
                currentPageIndex = maxIndex;
                DisplayItems();
            }
        }

        // REFRESH THE NAILS LIST BY RELOADING THEM 
        // FROM THE nails.json FILE AND UPDATING THEM
        // AS WELL AS RETURNING THE PAGE NUMBER TO START
        // AND DISPLAYING THEM
        public void RefreshNails()
        {
            nails = JsonUtil.LoadNails();
            nails.ForEach(n => n.Update());
            currentPageIndex = 0;
            DisplayItems();
        }

        // WHEN THE BACK BTN IS PRESSED
        private void BackBtnClick(object sender, EventArgs e)
        {
            Navigator.GotoRetain<StartMenu, NailGallery>();
        }

        // WHEN THE BUTTONS ARE PRESSED THE APPROPRIATE METHODS ARE CALLED
        private void FullLeftClick(object sender, EventArgs e) => FirstPage();
        private void LeftClick(object sender, EventArgs e) => PreviousPage();
        private void RightClick(object sender, EventArgs e) => NextPage();
        private void FullRightClick(object sender, EventArgs e) => LastPage();
        private void RefreshBtnClick(object sender, EventArgs e) => RefreshNails();

        // OPEN THE nails.json FILE THAT HOLDS THE NAILS 
        private void OpenJsonClick(object sender, EventArgs e) => JsonUtil.OpenNailsJson();
    }
}
