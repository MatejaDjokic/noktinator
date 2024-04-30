using System.Windows.Forms;
using System.Drawing;
using System;

namespace Noktinator
{
    public partial class FingerPreview : Form
    {

        public static PictureBox ChosenField;

        Image CopyPasteImage;

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
            if (e.KeyCode == Keys.Escape)
                Navigator.GotoRetain<StartMenu, FingerPreview>();
        }
        private void FormClose(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void FingerPreviewLoad(object sender, EventArgs e)
        {
            Bitmap img = NailUtil.GetDefaultNail();
            LittleFinger.Image = img;
            RingFinger.Image = img;
            MiddleFinger.Image = img;
            IndexFinger.Image = img;
            Thumb.Image = img;
        }

        private void FingerChoiceClick(PictureBox field)
        {
            ChosenField = field;
            Navigator.GotoRetain<FingerMenu, FingerPreview>();
        }

        private void LittleFingerClick(object sender, EventArgs e)
        {
            FingerChoiceClick(LittleFinger);
        }

        private void RingFingerClick(object sender, EventArgs e)
        {
            FingerChoiceClick(RingFinger);
        }

        private void MiddleFingerClick(object sender, EventArgs e)
        {
            FingerChoiceClick(MiddleFinger);
        }

        private void IndexFingerClick(object sender, EventArgs e)
        {
            FingerChoiceClick(IndexFinger);
        }

        private void ThumbClick(object sender, EventArgs e)
        {
            FingerChoiceClick(Thumb);
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


        //kopiranje slika
        private void MaliCopy_Click(object sender, EventArgs e)
        {
            CopyPasteImage = LittleFinger.Image;
        }

        private void DomaliCopy_Click(object sender, EventArgs e)
        {
            CopyPasteImage = RingFinger.Image;
        }

        private void SrednjiCopy_Click(object sender, EventArgs e)
        {
            CopyPasteImage = MiddleFinger.Image;
        }

        private void KaziCopy_Click(object sender, EventArgs e)
        {
            CopyPasteImage = IndexFinger.Image;
        }

        private void PalacCopy_Click(object sender, EventArgs e)
        {
            CopyPasteImage = Thumb.Image;
        }

        private void MaliPaste_Click(object sender, EventArgs e)
        {
            LittleFinger.Image = CopyPasteImage;
        }

        private void DomaliPaste_Click(object sender, EventArgs e)
        {
            RingFinger.Image = CopyPasteImage;
        }

        private void SrednjiPaste_Click(object sender, EventArgs e)
        {
            MiddleFinger.Image = CopyPasteImage;
        }

        private void KaziPaste_Click(object sender, EventArgs e)
        {
            IndexFinger.Image = CopyPasteImage;
        }

        private void PalacPaste_Click(object sender, EventArgs e)
        {
            Thumb.Image = CopyPasteImage;
        }

        private void NazadClick(object sender, EventArgs e)
        {
            Navigator.GotoRetain<StartMenu, FingerPreview>();
        }
    }
}
