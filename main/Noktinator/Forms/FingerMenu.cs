using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System;
using Noktinator.Util;
using System.Globalization;

namespace Noktinator
{
    public partial class FingerMenu : BaseForm
    {
        public FingerMenu()
        {
            InitializeComponent();

            this.KeyDown += FingeMenuKeyDown;
            this.KeyPreview = true;
        }

        public static Nail nail = NailUtil.GetDefaultData();

        public static Image copyImage;

        public static Bitmap fingerImage;
        private static Bitmap nailImage;
        public static Bitmap patternImage;


        private void FingeMenuKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape: Navigator.GotoRetain<FingerPreview, FingerMenu>(); break;
                case Keys.D1: Navigator.GotoRetain<ChooseShape, FingerMenu>(); break;
                case Keys.D2: BojaNoktaClick(); break;
                case Keys.D3: Navigator.GotoRetain<ChoosePattern, FingerMenu>(); break;
                case Keys.D4: BojaPaternaClick(); break;
                case Keys.D5: Navigator.GotoRetain<SkinChoice, FingerMenu>(); break;
                case Keys.D6: AddNailToGallery(); break;
                case Keys.D7: ResetDesignClick(); break;
            }
        }
        private void FingerMenuLoad(object sender, EventArgs e)
        {
            nail.Update();

            fingerImage = new Bitmap(nail.fingerShapeImage());
            nailImage = new Bitmap(nail.nailShapeImage());
            patternImage = new Bitmap(nail.patternImage());
            MergeImages();
        }

        //spajanje slike prsta i odgovarajuceg nokta
        public void MergeImages()
        {
            fingerView.BackgroundImage = NailUtil.MergeBitmaps(fingerImage, nailImage, patternImage);
        }

        //biranje boje nokta 
        void BojaNoktaClick()
        {
            var res = NokatColorDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                nail.shapeColor = NokatColorDialog.Color;

                // kreiranje nove instance bitmape za bojenje nokte
                nailImage = NailUtil.ColorBitmap(new Bitmap(nail.nailShapeImage()), NokatColorDialog.Color);
            }
            MergeImages();
        }
        private void BojaNoktaButtonClick(object sender, EventArgs e) => BojaNoktaClick();

        //biranje boje paterna
        void BojaPaternaClick()
        {
            var res = PaternColorDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                nail.patternColor = PaternColorDialog.Color;

                patternImage = NailUtil.ColorBitmap(new Bitmap(nail.patternImage()), PaternColorDialog.Color);
            }
            MergeImages();

        }
        void BojaPaternaButtonClick(object sender, EventArgs e) => BojaPaternaClick();

        //biranje boje koze
        void RasaClick(object sender, EventArgs e)
        {
            Navigator.GotoRetain<SkinChoice, FingerMenu>();
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
            nailImage = NailUtil.ColorBitmap(new Bitmap(nail.nailShapeImage()), nail.shapeColor);
            fingerImage = NailUtil.ColorBitmap(new Bitmap(nail.fingerShapeImage()), nail.skinColor);
            patternImage = NailUtil.ColorBitmap(new Bitmap(nail.patternImage()), nail.patternColor);
            MergeImages();
        }

        //biranje paterna
        private void Patern_Click(object sender, EventArgs e)
        {
            Navigator.GotoRetain<ChoosePattern, FingerMenu>();
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
            MessageBox.Show("Successfully added to gallery!", "Add To Gallery", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddNailToGalleryButtonClick(object sender, EventArgs e) => AddNailToGallery();

        void ResetDesignClick()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to reset the design?", "Reset Design", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                nail = NailUtil.GetDefaultData();
                fingerView.BackgroundImage = NailUtil.GetDefault();
            }
        }

        private void ResetDesignButtonClick(object sender, EventArgs e) => ResetDesignClick();
    }
}
