using System.Windows.Forms;
using System;

namespace Noktinator
{
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
        }


        //dizajniraj
        private void DizajnirajClick(object sender, EventArgs e)
        {
            FingerPreview fingerPreview = new FingerPreview();
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
            NailGalerija nailGalerija = new NailGalerija();
            nailGalerija.Show();
            //this.Hide();
        }
    }
}
