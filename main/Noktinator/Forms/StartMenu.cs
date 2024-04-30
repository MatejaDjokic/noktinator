using System.Windows.Forms;
using System;
using Noktinator.Util;

namespace Noktinator
{
    public partial class StartMenu : BaseForm
    {
        public StartMenu()
        {
            InitializeComponent();
            this.Load += StartMenuLoad;
        }

        private void StartMenuLoad(object sender, EventArgs e)
        {
            Navigator.Init(
                new NailGallery(),
                new FingerPreview(),
                new FingerMenu(),
                new ChooseShape(),
                new SkinChoice()
            );
        }

        //dizajniraj
        private void DizajnirajClick(object sender, EventArgs e)
        {
            Navigator.GotoRetain<FingerPreview, StartMenu>();
        }

        //izadji
        private void IzadjiClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GalleryButtonClick(object sender, EventArgs e)
        {
            Navigator.GotoRetain<NailGallery, StartMenu>();
        }
    }
}
