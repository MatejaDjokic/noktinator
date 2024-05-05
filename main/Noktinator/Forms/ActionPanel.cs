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
                case Keys.S: new SetFingerFromGallery(nail.GetImage()).ShowDialog(); break;
                case Keys.O: NailUtil.OpenDownloadsFolder(); break;
            }
        }
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

                try
                {
                    nailGallery.nailButtons.RemoveAt(this.idx);
                    List<Nail> nails = JsonUtil.LoadNails();
                    nails.RemoveAt(this.idx);
                    JsonUtil.SaveNails(nails);
                    this.Close();
                    nailGallery.RefreshNails();
                }
                catch (Exception)
                {
                    if (idx > nailGallery.nailButtons.Count)
                    {
                        MessageBox.Show("aaaa");
                    }
                }
               
            }
        }
        void DeleteNailBtnClick(object sender, EventArgs e) => DeleteNail();

        private void DownloadNailImageBtnClick(object sender, EventArgs e) => NailUtil.DownloadNailImage(nail);

        private void OpenDownloadsFolderClick(object sender, EventArgs e) => NailUtil.OpenDownloadsFolder();

        private void SetNailFromGalleryClick(object sender, EventArgs e)
        {
            new SetFingerFromGallery(nail.GetImage()).ShowDialog();
        }

        private void downloadNailImageBtn_Click(object sender, EventArgs e)
        {
            NailUtil.DownloadNailImage(nail);
        }
    }
}
