using System.Windows.Forms;
using Noktinator.Util;
using System.Drawing;
using System;

namespace Noktinator
{
    public partial class FingerPreview : BaseForm
    {

        public static PictureBox ChosenField;

        Image copyPasteImage = NailUtil.GetDefault();

        public FingerPreview()
        {
            InitializeComponent();

            this.FormClosing += FormClose;
            this.Load += FingerPreviewLoad;
            this.KeyDown += MyKeyDown;
            this.KeyPreview = true;
        }

        private void MyKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape: Navigator.GotoRetain<StartMenu, FingerPreview>(); break;
                case Keys.D1: FingerChoiceClick(littleFingerPictureBox); break;
                case Keys.D2: FingerChoiceClick(ringFingerPictureBox); break;
                case Keys.D3: FingerChoiceClick(middleFingerPictureBox); break;
                case Keys.D4: FingerChoiceClick(indexFingerPictureBox); break;
                case Keys.D5: FingerChoiceClick(thumbPictureBox); break;
            }
        }
        private void FormClose(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void FingerPreviewLoad(object sender, EventArgs e)
        {
            Bitmap img = NailUtil.GetDefault();
            littleFingerPictureBox.Image = img;
            ringFingerPictureBox.Image = img;
            middleFingerPictureBox.Image = img;
            indexFingerPictureBox.Image = img;
            thumbPictureBox.Image = img;

            downloadLittleFingerBtn.BackgroundImage = Properties.Resources.download;
            downloadRingFingerBtn.BackgroundImage = Properties.Resources.download;
            downloadMiddleFingerBtn.BackgroundImage = Properties.Resources.download;
            downloadIndexFingerBtn.BackgroundImage = Properties.Resources.download;
            downloadThumbBtn.BackgroundImage = Properties.Resources.download;
            downloadAllFingersBtn.BackgroundImage = Properties.Resources.download;
        }

        private void FingerChoiceClick(PictureBox field)
        {
            ChosenField = field;
            Navigator.GotoRetain<FingerMenu, FingerPreview>();
        }

        private void LittleFingerClick(object sender, EventArgs e)
        {
            FingerChoiceClick(littleFingerPictureBox);
        }

        private void RingFingerClick(object sender, EventArgs e)
        {
            FingerChoiceClick(ringFingerPictureBox);
        }

        private void MiddleFingerClick(object sender, EventArgs e)
        {
            FingerChoiceClick(middleFingerPictureBox);
        }

        private void IndexFingerClick(object sender, EventArgs e)
        {
            FingerChoiceClick(indexFingerPictureBox);
        }

        private void ThumbClick(object sender, EventArgs e)
        {
            FingerChoiceClick(thumbPictureBox);
        }

        //shadeovanje pri hoverovanju misem
        private void Darken(object sender, EventArgs e)
        {
            PictureBox picBox = (PictureBox)sender;
            picBox.BackColor = Color.Plum;
        }

        private void Lighten(object sender, EventArgs e)
        {
            PictureBox picBox = (PictureBox)sender;
            picBox.BackColor = Color.Transparent;
        }

        private void LittleFingerCopy(object sender, EventArgs e)
        {
            copyPasteImage = littleFingerPictureBox.Image;
        }
        private void RingFingerCopy(object sender, EventArgs e)
        {
            copyPasteImage = ringFingerPictureBox.Image;
        }
        private void MiddleFingerCopy(object sender, EventArgs e)
        {
            copyPasteImage = middleFingerPictureBox.Image;
        }
        private void IndexFingerCopy(object sender, EventArgs e)
        {
            copyPasteImage = indexFingerPictureBox.Image;
        }
        private void ThumbCopy(object sender, EventArgs e)
        {
            copyPasteImage = thumbPictureBox.Image;
        }

        private void LittleFingerPaste(object sender, EventArgs e)
        {
            littleFingerPictureBox.Image = copyPasteImage;
        }
        private void RingFingerPaste(object sender, EventArgs e)
        {
            ringFingerPictureBox.Image = copyPasteImage;
        }
        private void MiddleFingerPaste(object sender, EventArgs e)
        {
            middleFingerPictureBox.Image = copyPasteImage;
        }
        private void IndexFingerPaste(object sender, EventArgs e)
        {
            indexFingerPictureBox.Image = copyPasteImage;
        }
        private void ThumbFingerPaste(object sender, EventArgs e)
        {
            thumbPictureBox.Image = copyPasteImage;
        }

        private void BackBtnClick(object sender, EventArgs e)
        {
            Navigator.GotoRetain<StartMenu, FingerPreview>();
        }

        private void DownloadLittleFingerBtnClick(object sender, EventArgs e)
        {
            NailUtil.DownloadFinger("little", littleFingerPictureBox.Image);
        }
        private void DownloadRingFingerBtnClick(object sender, EventArgs e)
        {
            NailUtil.DownloadFinger("ring", ringFingerPictureBox.Image);
        }
        private void DownloadMiddleFingerBtnClick(object sender, EventArgs e)
        {
            NailUtil.DownloadFinger("middle", middleFingerPictureBox.Image);
        }
        private void DownloadIndexFingerBtnClick(object sender, EventArgs e)
        {
            NailUtil.DownloadFinger("index", indexFingerPictureBox.Image);
        }
        private void DownloadThumbBtnClick(object sender, EventArgs e)
        {
            NailUtil.DownloadFinger("thumb", thumbPictureBox.Image);
        }
        private void DownloadAllFingersBtnClick(object sender, EventArgs e)
        {
            NailUtil.DownloadAllFingers(
                littleFingerPictureBox.Image,
                ringFingerPictureBox.Image,
                middleFingerPictureBox.Image,
                indexFingerPictureBox.Image,
                thumbPictureBox.Image
            );
        }

        private void OpenDowloadsFolderBtnClick(object sender, EventArgs e) => NailUtil.OpenDownloadsFolder();
    }
}
