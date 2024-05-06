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

        // WHAT DO DO WHEN A KEY IS PRESSED
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

        // WHEN THE DESIGN BTN IS CLICKED
        private void DesignBtnClick(object sender, EventArgs e)
        {
            Navigator.GotoRetain<FingerPreview, StartMenu>();
        }
        
        // WHEN THE GALLERY BTN IS CLICKED
        private void GalleryBtnClick(object sender, EventArgs e)
        {
            Navigator.GotoRetain<NailGallery, StartMenu>();
        }

        // WHEN THE EXIT BTN IS CLICKED
        private void ExitBtnClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
