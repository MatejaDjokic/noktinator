using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace Noktinator
{
    public partial class FingerMenu : Form
    {
        public FingerMenu()
        {
            InitializeComponent();

            this.FormClosing += FormClose;
            this.KeyDown += MyKeyDown;
            this.KeyPreview = true;
        }

        public static Nail nail = NailUtil.GetDefaultNailData();

        //slika koja sluzi za kopiranje na FingerPreview
        public static Image copyImage;

        public static Bitmap fingerImage;
        private static Bitmap nailImage;
        public static Bitmap patternImage;


        private void MyKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Navigator.GotoRetain<FingerPreview, FingerMenu>();
        }
        private void FingerMenuLoad(object sender, EventArgs e)
        {
            nail.Update();

            fingerImage = new Bitmap(nail.fingerShapeImage());
            nailImage = new Bitmap(nail.nailShapeImage());
            patternImage = new Bitmap(nail.patternImage());
            MergeImages();
        }

        private void FormClose(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //spajanje slike prsta i odgovarajuceg nokta
        public void MergeImages()
        {
            fingerView.BackgroundImage = NailUtil.MergeBitmaps(fingerImage, nailImage, patternImage);
        }

        //biranje boje nokta 
        private void BojaNoktaClick(object sender, EventArgs e)
        {
            var res = NokatColorDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                nail.nailColor = NokatColorDialog.Color;

                // kreiranje nove instance bitmape za bojenje nokte
                nailImage = NailUtil.ColorBitmap(new Bitmap(nail.nailShapeImage()), NokatColorDialog.Color);
            }
            MergeImages();
        }

        //biranje boje paterna
        private void BojaPaternaClick(object sender, EventArgs e)
        {
            var res = PaternColorDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                nail.patternColor = PaternColorDialog.Color;

                patternImage = NailUtil.ColorBitmap(new Bitmap(nail.patternImage()), PaternColorDialog.Color);
            }
            MergeImages();
        }

        //biranje boje koze
        private void RasaClick(object sender, EventArgs e)
        {
            SkinChoice a = new SkinChoice();
            a.Show();
            this.Hide();
        }

        //biranje oblika
        private void OblikNoktaClick(object sender, EventArgs e)
        {
            Navigator.GotoRetain<ChooseShape, FingerMenu>();
        }


        private void FingerMenuVisibleChanged(object sender, EventArgs e)
        {
            nail.Update();

            //kad god se ponovo pojavi ova forma, prst i nokat ce imati poslednju sacuvanu boju
            nailImage = NailUtil.ColorBitmap(new Bitmap(nail.nailShapeImage()), nail.nailColor);
            fingerImage = NailUtil.ColorBitmap(new Bitmap(nail.fingerShapeImage()), nail.skinColor);
            patternImage = NailUtil.ColorBitmap(new Bitmap(nail.patternImage()), nail.patternColor);
            MergeImages();
        }

        //biranje paterna
        private void Patern_Click(object sender, EventArgs e)
        {
            ChoosePattern choosePattern = new ChoosePattern();
            choosePattern.Show();
            this.Hide();
        }


        //kada se stisne nazad onda 
        private void BackButttonClick(object sender, EventArgs e)
        {
            Navigator.GotoRetain<FingerPreview, FingerMenu>();
            FingerPreview.ChosenField.Image = fingerView.BackgroundImage;
        }

        private void AddNailToGallery()
        {
            List<Nail> nails = JsonUtil.LoadNails();
            nails.Add(nail);
            JsonUtil.SaveNails(nails);
        }

        private void AddNailToGalleryButtonClick(object sender, EventArgs e) => AddNailToGallery();

        private void ResetDesign_Click(object sender, EventArgs e)
        {
            nail = NailUtil.GetDefaultNailData();
            fingerView.BackgroundImage = NailUtil.GetDefaultNail();
        }
    }
}
