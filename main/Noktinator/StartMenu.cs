using System.Windows.Forms;
using System;

namespace Noktinator
{
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
            this.Load += StartMenuLoad;
        }

        private void StartMenuLoad(object sender, EventArgs e)
        {
            NailGallery ng = new NailGallery();
            FingerPreview fp = new FingerPreview();
            FingerMenu fm = new FingerMenu();
            ng.Show();
            fp.Show();
            fm.Show();

            ng.Hide();
            fp.Hide();
            fm.Hide();
        }

        //dizajniraj
        private void DizajnirajClick(object sender, EventArgs e)
        {
            FingerPreview fingerPreview = (FingerPreview)Application.OpenForms["FingerPreview"];
            fingerPreview.Show();
            this.Hide();
        }

        //izadji
        private void IzadjiClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GalleryButtonClick(object sender, EventArgs e)
        {
            NailGallery ng = (NailGallery)Application.OpenForms["NailGallery"];
            ng.Show();
            this.Hide();
        }
    }
}
