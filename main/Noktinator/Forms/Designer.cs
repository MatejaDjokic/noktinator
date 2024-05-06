using System.Collections.Generic;
using System.Windows.Forms;
using Noktinator.Util;
using System.Drawing;
using System;

namespace Noktinator
{
    public partial class Designer : BaseForm
    {
        public static Nail nail = NailUtil.GetDefaultData();

        public static Image copyImage;
        public static Bitmap fingerImage;
        private static Bitmap nailImage;
        public static Bitmap patternImage;

        public Designer()
        {
            InitializeComponent();

            this.KeyDown += DesignerKeyDown;
        }

        // WHAT TO DO WHEN A KEY IS PRESSED
        private void DesignerKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape: Navigator.GotoRetain<FingerPreview, Designer>(); break;
                case Keys.D1: Navigator.GotoRetain<ChooseShape, Designer>(); break;
                case Keys.D2: NailColorClick(); break;
                case Keys.D3: Navigator.GotoRetain<ChoosePattern, Designer>(); break;
                case Keys.D4: PatternColorClick(); break;
                case Keys.D5: Navigator.GotoRetain<SkinChoice, Designer>(); break;
                case Keys.D6: AddNailToGallery(); break;
                case Keys.D7: ResetDesignClick(); break;
            }
        }
        // WHEN THE FORM IS LOADED
        private void DesignerLoad(object sender, EventArgs e)
        {
            nail.Update();

            fingerImage = new Bitmap(nail.fingerShapeImage());
            nailImage = new Bitmap(nail.nailShapeImage());
            patternImage = new Bitmap(nail.patternImage());
            MergeImages();
        }


        // MERGES THE FINGER, NAIL & PATTERN IMAGE INTO ONE PICTURE
        public void MergeImages()
        {
            fingerView.BackgroundImage = NailUtil.MergeBitmaps(fingerImage, nailImage, patternImage);
        }

        // OPENS A COLOR DIALOG AND WITH THE SELECTED COLOR COLORS THE NAIL IMAGE
        void NailColorClick()
        {
            var res = nailColorDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                nail.shapeColor = nailColorDialog.Color;

                // kreiranje nove instance bitmape za bojenje nokte
                nailImage = NailUtil.ColorBitmap(new Bitmap(nail.nailShapeImage()), nailColorDialog.Color);
            }
            MergeImages();
        }
        // RUNS THE METHOD ABOVE WHEN THE NAIL COLOR BTN IS CLICKED
        private void NailColorBtnClick(object sender, EventArgs e) => NailColorClick();

        // OPENS A COLOR DIALOG AND WITH THE SELECTED COLOR COLORS THE PATTERN IMAGE
        void PatternColorClick()
        {
            var res = PaternColorDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                nail.patternColor = PaternColorDialog.Color;

                patternImage = NailUtil.ColorBitmap(new Bitmap(nail.patternImage()), PaternColorDialog.Color);
            }
            MergeImages();

        }
        // RUNS THE METHOD ABOVE WHEN THE PATTERN COLOR BTN IS CLICKED
        void PatternColorBtnClick(object sender, EventArgs e) => PatternColorClick();

        // RUNS WHEN THE SKIN COLOR BTN IS PRESSED
        void SkinColorBtnClick(object sender, EventArgs e)
        {
            Navigator.GotoRetain<SkinChoice, Designer>();
        }

        // RUNS WHEN THE NAIL SHAPE BTN IS PRESSED
        private void NailShapeBtnClick(object sender, EventArgs e)
        {
            Navigator.GotoRetain<ChooseShape, Designer>();
        }

        // RUNS WHEN THE DESIGNER IS VISIBLY CHANGED
        private void DesignerVisibleChanged(object sender, EventArgs e)
        {
            nail.Update();

            //kad god se ponovo pojavi ova forma, prst i nokat ce imati poslednju sacuvanu boju
            nailImage = NailUtil.ColorBitmap(new Bitmap(nail.nailShapeImage()), nail.shapeColor);
            fingerImage = NailUtil.ColorBitmap(new Bitmap(nail.fingerShapeImage()), nail.skinColor);
            patternImage = NailUtil.ColorBitmap(new Bitmap(nail.patternImage()), nail.patternColor);
            MergeImages();
        }

        // RUNS WHEN THE PATTERN SHAPE BTN IS PRESSED
        private void NailPatternBtnClick(object sender, EventArgs e)
        {
            Navigator.GotoRetain<ChoosePattern, Designer>();
        }

        // WHEN THE BACK BTN IS PRESSED
        private void BackBtnClick(object sender, EventArgs e)
        {
            Navigator.GotoRetain<FingerPreview, Designer>();
            FingerPreview.chosenField.Image = fingerView.BackgroundImage;
        }

        // LOADS THE NAILS FROM THE nails.json FILE
        // ADD A NEW NAIL TO THE nails LIST
        // AND SAVES THE NAILS TO THE nails.json FILE
        private void AddNailToGallery()
        {
            List<Nail> nails = JsonUtil.LoadNails();
            nails.Add(nail);
            JsonUtil.SaveNails(nails);
            MessageBox.Show("Successfully added to gallery!", "Add to Gallery", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // THE MOETHOD ABOVE IS CALLED WHEN THE ADD NAIL TO GALLERY BTN IS PRESSED
        private void AddNailToGalleryBtnClick(object sender, EventArgs e) => AddNailToGallery();

        // RESETS THE DESIGN OF THE CURRENT FINGER TO THE DEFAUL DESIGN
        void ResetDesignClick()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to reset the design?", "Reset Design", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                nail = NailUtil.GetDefaultData();
                fingerView.BackgroundImage = NailUtil.GetDefault();
            }
        }
        // THE METHOD ABOVE IS CALLED WHEN THE RESET DESIGN BNT IS PRESSED
        private void ResetDesignBtnClick(object sender, EventArgs e) => ResetDesignClick();
    }
}
