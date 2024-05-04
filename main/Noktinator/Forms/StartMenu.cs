using System.Windows.Forms;
using Noktinator.Util;
using System;

namespace Noktinator
{
    public partial class StartMenu : BaseForm
    {
        public StartMenu()
        {
            InitializeComponent();
            // ADD THE KEYDOWN HANDLER TO THE START MENU FORM
            this.KeyDown += StartMenuKeyDown;
        }

        private void StartMenuKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                // GO TO THE FINGER PREVIEW FORM
                case Keys.D1: Navigator.GotoRetain<FingerPreview, StartMenu>(); break;
                // GO TO THE NAIL GALLERY FORM
                case Keys.D2: Navigator.GotoRetain<NailGallery, StartMenu>(); break;
                // EXIT THE APP
                case Keys.D3: Application.Exit(); break;
            }
        }

        private void DizajnirajClick(object sender, EventArgs e)
        {
            Navigator.GotoRetain<FingerPreview, StartMenu>();
        }

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
