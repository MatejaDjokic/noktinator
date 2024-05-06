using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace Noktinator.Forms
{
    public partial class ActionPanel : Form
    {
        Nail nail;
        int idx;

        public ActionPanel(Nail nail, int idx)
        {
            InitializeComponent();
            this.nail = nail;
            this.idx = idx;
            this.KeyDown += ActionPanelKeyDown;
            this.KeyPreview = true;
        }

        void ActionPanelKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape: this.Close(); break;
                case Keys.Delete: DeleteNail(); break;
                case Keys.D: NailUtil.DownloadNailImage(nail); break;
                case Keys.O: NailUtil.OpenDownloadsFolder(); break;
            }
        }
        // WHEN THE FORM IS LOADED THE CORRECT DATA
        // IS ASSIGNED TO CORRECT OBJECTS
        private void ActionPanelLoad(object sender, EventArgs e)
        {
            this.Text = $"Nail {this.idx + 1}";
            fingerView.BackgroundImage = nail.GetImage();

            shapeInfoBtn.Text = nail.shape.ToString();
            shapeInfoBtn.ForeColor = NailUtil.GetContrastingColor(nail.shapeColor);
            shapeInfoBtn.BackColor = nail.shapeColor;

            patterInfoBtn.Text = nail.pattern.ToString();
            patterInfoBtn.ForeColor = NailUtil.GetContrastingColor(nail.patternColor);
            patterInfoBtn.BackColor = nail.patternColor;

            Color skin = nail.skinColor;
            skinInfoBtn.Text = $"({skin.R}, {skin.G}, {skin.B})";
            skinInfoBtn.ForeColor = NailUtil.GetContrastingColor(nail.skinColor);
            skinInfoBtn.BackColor = nail.skinColor;
        }

        // A MESSAGEBOX ASK IF YOU ARE SURE
        // IF YES IS PRESSED THE NAIL AND IT'S BUTTON
        // WILL BE REMOVED FROM THEIR LISTS
        // THE ACTION PANEL IS GOING TO BE CLOSED
        // AND THE NAILS GALLERY NAILS REFRESHED
        void DeleteNail()
        {
            NailGallery nailGallery = Navigator.Get<NailGallery>();

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete \"Nail {this.idx + 1}\"?",
                $"Delete \"Nail {this.idx + 1}\"",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (result == DialogResult.Yes)
            {
                nailGallery.nailButtons.RemoveAt(this.idx);
                List<Nail> nails = JsonUtil.LoadNails();
                nails.RemoveAt(this.idx);
                JsonUtil.SaveNails(nails);
                this.Close();
                nailGallery.RefreshNails();
            }
        }
        // THE METHOD ABOVE IS CALLED WHEN THE DELETE NAIL BTN IS PRESSED
        void DeleteNailBtnClick(object sender, EventArgs e) => DeleteNail();

        // WHEN PRESSED THE THE NAIL IMAGE IS DOWNLOADED
        private void DownloadNailImageBtnClick(object sender, EventArgs e) => NailUtil.DownloadNailImage(nail);

        // WHEN PRESSED THE OPEN DOWNLOADS FOLDER IS OPENED
        private void OpenDownloadsFolderClick(object sender, EventArgs e) => NailUtil.OpenDownloadsFolder();
    }
}
