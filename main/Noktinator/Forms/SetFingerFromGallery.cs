using System.Drawing;
using System.Windows.Forms;

namespace Noktinator.Forms
{
    public partial class SetFingerFromGallery : Form
    {
        Image toSet;

        public SetFingerFromGallery(Image toSet)
        {
            InitializeComponent();
            CenterToScreen();
            this.toSet = toSet;
            this.KeyDown += SetFingerFromGalleryKeyDown;
            this.KeyPreview = true;
        }

        void SetFingerFromGalleryKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D1: SetImage("little"); break;
                case Keys.D2: SetImage("ring"); break;
                case Keys.D3: SetImage("middle"); break;
                case Keys.D4: SetImage("index"); break;
                case Keys.D5: SetImage("thumb"); break;
            }
        }
        void SetImage(string finger)
        {
            FingerPreview fingerPreview = Navigator.Get<FingerPreview>();
            switch (finger)
            {
                case "little": fingerPreview.littleFingerPictureBox.Image = toSet; break;
                case "ring": fingerPreview.ringFingerPictureBox.Image = toSet; break;
                case "middle": fingerPreview.middleFingerPictureBox.Image = toSet; break;
                case "index": fingerPreview.indexFingerPictureBox.Image = toSet; break;
                case "thumb": fingerPreview.thumbPictureBox.Image = toSet; break;
            }
            this.Close();
        }

        private void SetLittleFingerBtnClick(object sender, System.EventArgs e) => SetImage("little");
        private void SetRingFingerBtnClick(object sender, System.EventArgs e) => SetImage("ring");
        private void SetMiddleFIngerBtnClick(object sender, System.EventArgs e) => SetImage("middle");
        private void SetIndexFingerBtnClick(object sender, System.EventArgs e) => SetImage("index");
        private void SetThumbBtnClick(object sender, System.EventArgs e) => SetImage("thumb");
    }
}
