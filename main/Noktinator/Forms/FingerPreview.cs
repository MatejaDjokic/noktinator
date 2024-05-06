using System.Windows.Forms;
using Noktinator.Util;
using System.Drawing;
using System;

namespace Noktinator
{
    public partial class FingerPreview : BaseForm
    {

        public static PictureBox chosenField;

        Image copyPasteImage = NailUtil.GetDefault();

        public FingerPreview()
        {
            InitializeComponent();

            this.Load += FingerPreviewLoad;
            this.KeyDown += FingerPreviewKeyDown;
            this.KeyPreview = true;
        }

        private void FingerPreviewKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape: Navigator.GotoRetain<StartMenu, FingerPreview>(); break;
                case Keys.O: NailUtil.OpenDownloadsFolder(); break;
                case Keys.D1: FingerChoiceClick(littleFingerPictureBox); break;
                case Keys.D2: FingerChoiceClick(ringFingerPictureBox); break;
                case Keys.D3: FingerChoiceClick(middleFingerPictureBox); break;
                case Keys.D4: FingerChoiceClick(indexFingerPictureBox); break;
                case Keys.D5: FingerChoiceClick(thumbPictureBox); break;
            }
        }

        // LOAD THE DEFAULT NAIL IMAGES AND LOAD THE ICONS FOR THE DOWNLOAD BUTTONS
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

        // METHOD TO SELECT A FINGER PICTURE BOX WHICH WILL BE EDITED IN THE DESIGNER
        private void FingerChoiceClick(PictureBox field)
        {
            chosenField = field;
            Navigator.GotoRetain<Designer, FingerPreview>();
        }

        // METHODS THAT CALL THE UPPER METHOD TO SELECT ONE OF THE FIVE FINGERS
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

        // METHODS TO MAKE THE HOVER EFFECT WHEN HOVERING OVER A PICTURE BOX 
        private void Darken(object sender, EventArgs e) => NailUtil.Darken((PictureBox)sender);
        private void Lighten(object sender, EventArgs e) => NailUtil.Lighten((PictureBox)sender);

        // COPY THE IMAGE OF A FINGER INTO THE COPY IMAGE BUFFER
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

        // PASTE THE IMAGE FROM THE COPY IMAGE BUFFER TO THE CORRESPONDING PICTURE BOX
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

        // WHEN THE BACK BTN IS PRESSED
        private void BackBtnClick(object sender, EventArgs e)
        {
            Navigator.GotoRetain<StartMenu, FingerPreview>();
        }

        // CORRESPONDING FINGER IMAGE IS DOWNLOADED WHEN PRESSED
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

        // WHEN PRESSED AN IMAGE OF ALL FINGERS IS DOWNLOADED
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

        // WHEN THE OPEN DOWNLOAD FOLDER BTN IS PRESSED
        private void OpenDowloadsFolderBtnClick(object sender, EventArgs e) => NailUtil.OpenDownloadsFolder();
    }
}
