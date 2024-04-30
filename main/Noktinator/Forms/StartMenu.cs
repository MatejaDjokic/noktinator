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
            this.KeyDown += StartMenuKeyDown;
        }

        private void StartMenuLoad(object sender, EventArgs e)
        {
            Navigator.Init(
                new NailGallery(),
                new FingerPreview(),
                new FingerMenu(),
                new ChooseShape(),
                new ChoosePattern(),
                new SkinChoice()
            );
        }
        private void StartMenuKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D1: Navigator.GotoRetain<FingerPreview, StartMenu>(); break;
                case Keys.D2: Navigator.GotoRetain<NailGallery, StartMenu>(); break;
                case Keys.D3: Application.Exit(); break;
            }
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
