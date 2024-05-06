using System.Windows.Forms;
using Noktinator.Util;
using System;
using System.CodeDom;

namespace Noktinator
{
    public partial class ChooseShape : BaseForm
    {
        public ChooseShape()
        {
            InitializeComponent();
            this.KeyDown += ChooseShapeKeyDown;
        }

        // WHAT TO DO WHEN A KEY IS PRESSED
        private void ChooseShapeKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape: Navigator.GotoRetain<Designer, ChooseShape>(); break;
                case Keys.D1: ChoiceClick(NailShape.Almond); break;
                case Keys.D2: ChoiceClick(NailShape.Ballerina); break;
                case Keys.D3: ChoiceClick(NailShape.Lipstick); break;
                case Keys.D4: ChoiceClick(NailShape.MountainPeak); break;
                case Keys.D5: ChoiceClick(NailShape.Oval); break;
                case Keys.D6: ChoiceClick(NailShape.Rounded); break;
                case Keys.D7: ChoiceClick(NailShape.Short); break;
                case Keys.D8: ChoiceClick(NailShape.Squoval); break;
                case Keys.D9: ChoiceClick(NailShape.Stiletto); break;
                case Keys.D0: ChoiceClick(NailShape.Wide); break;
            }
        }

        // SET NAIL SHAPE FROM THE CLICKED NAIL BTN
        public void ChoiceClick(NailShape shapeEnum)
        {
            Designer.nail.shape = shapeEnum; //noktu u glavnom editoru za atribut shape daje odredjeni oblik
            Navigator.GotoRetain<Designer, ChooseShape>();
        }

        // BY USING THE METHOD ABOVE THE CORRESPONDING NAIL SHAPE IS SET
        private void AlmondBtnClick(object sender, EventArgs e)
        {
            ChoiceClick(NailShape.Almond);
        }
        private void BallerinaBtnClick(object sender, EventArgs e)
        {
            ChoiceClick(NailShape.Ballerina);
        }
        private void LipstickBtnClick(object sender, EventArgs e)
        {
            ChoiceClick(NailShape.Lipstick);
        }
        private void MountainPeakBtnClick(object sender, EventArgs e)
        {
            ChoiceClick(NailShape.MountainPeak);
        }
        private void OvalBtnClick(object sender, EventArgs e)
        {
            ChoiceClick(NailShape.Oval);
        }
        private void RoundedBtnClick(object sender, EventArgs e)
        {
            ChoiceClick(NailShape.Rounded);
        }
        private void ShortBtnClick(object sender, EventArgs e)
        {
            ChoiceClick(NailShape.Short);
        }
        private void SquovalBtnClick(object sender, EventArgs e)
        {
            ChoiceClick(NailShape.Squoval);
        }
        private void StilettoBtnClick(object sender, EventArgs e)
        {
            ChoiceClick(NailShape.Stiletto);
        }
        private void WideBtnClick(object sender, EventArgs e)
        {
            ChoiceClick(NailShape.Wide);
        }

        // METHODS TO MAKE THE HOVER EFFECT WHEN HOVERING OVER A PICTURE BOX 
        private void Darken(object sender, EventArgs e) => NailUtil.Darken((PictureBox)sender);
        private void Lighten(object sender, EventArgs e) => NailUtil.Lighten((PictureBox)sender);

        // RUNS WHEN THE BACK BTN IS PRESSED
        private void BackBtnClick(object sender, EventArgs e)
        {
            Navigator.GotoRetain<Designer, ChooseShape>();
        }
    }
}
