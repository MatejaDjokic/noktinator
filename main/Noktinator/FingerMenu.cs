using System.Windows.Forms;
using System.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Noktinator
{
    public partial class FingerMenu : Form
    {
        public FingerMenu()
        {
            InitializeComponent();

            this.FormClosing += FormClose;
        }

        public static Nail nail = new Nail(
                shape: NailShape.Almond,
                nailColor: Color.White,
                skinColor: Color.FromArgb(240, 184, 160)
         );

        //slika koja sluzi za kopiranje na FingerPreview
        public static Image copyImage;

        public static Bitmap fingerImage;
        private Bitmap nailImage;
        public static Bitmap patternImage;

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

        Bitmap ColorBitmap(Bitmap bmp, Color color)
        {
            return NailUtil.ColorBitmap(bmp, color);
        }

        //biranje boje nokta 
        private void BojaNoktaClick(object sender, EventArgs e)
        {
            var res = NokatColorDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                nail.nailColor = NokatColorDialog.Color;

                // kreiranje nove instance bitmape za bojenje nokte
                nailImage = ColorBitmap(new Bitmap(nail.nailShapeImage()), NokatColorDialog.Color);
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

                patternImage = ColorBitmap(new Bitmap(nail.patternImage()), PaternColorDialog.Color);
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
            //ChooseShape forma na kojoj se biraju oblici noktiju
            ChooseShape chooseShape = new ChooseShape();
            chooseShape.Show();
            this.Hide();
        }


        private void FingerMenuVisibleChanged(object sender, EventArgs e)
        {
            nail.Update();

            //kad god se ponovo pojavi ova forma, prst i nokat ce imati poslednju sacuvanu boju
            nailImage = ColorBitmap(new Bitmap(nail.nailShapeImage()), nail.nailColor);
            fingerImage = ColorBitmap(new Bitmap(nail.fingerShapeImage()), nail.skinColor);
            patternImage = ColorBitmap(new Bitmap(nail.patternImage()), nail.patternColor);
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
        private void Nazad_Click(object sender, EventArgs e)
        {
            FingerPreview fingerPreview = (FingerPreview)Application.OpenForms["FingerPreview"];
            FingerPreview.ChosenField.Image = fingerView.BackgroundImage;

            fingerPreview.Show();
            this.Hide();
        }

        private void AddToGallery()
        {
            List<Nail> nails = JsonUtil.LoadNails();
            nails.Add(nail);
            JsonUtil.SaveNails(nails);
        }

        private void GalerijaClick(object sender, EventArgs e) => AddToGallery();

        private void ResetDesign_Click(object sender, EventArgs e)
        {
            fingerView.BackgroundImage = NailUtil.GetDefaultNail();
            nail = new Nail(
               shape: NailShape.Almond,
               nailColor: Color.White,
               skinColor: Color.FromArgb(240, 184, 160)
        );
        }
    }
}
