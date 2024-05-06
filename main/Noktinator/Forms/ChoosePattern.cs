using System.Windows.Forms;
using Noktinator.Util;
using System;

namespace Noktinator
{
    public partial class ChoosePattern : BaseForm
    {
        public ChoosePattern()
        {
            InitializeComponent();
            this.KeyDown += ChoosePatternKeyDown;
        }

        // WHAT TO DO WHEN A KEY IS PRESSED
        private void ChoosePatternKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape: Navigator.GotoRetain<Designer, ChoosePattern>(); break;
                case Keys.D1: ChoiceClick(NailPattern.Fire); break;
                case Keys.D2: ChoiceClick(NailPattern.Leaf); break;
                case Keys.D3: ChoiceClick(NailPattern.Stars); break;
                case Keys.D4: ChoiceClick(NailPattern.Hearts); break;
                case Keys.D5: ChoiceClick(NailPattern.Leaves); break;
                case Keys.D6: ChoiceClick(NailPattern.Snowflake); break;
                case Keys.D7: ChoiceClick(NailPattern.Triangles); break;
                case Keys.D8: ChoiceClick(NailPattern.Yinyang); break;
                case Keys.D9: ChoiceClick(NailPattern.Butterfly); break;
                case Keys.D0: ChoiceClick(NailPattern.Snake); break;
                case Keys.F: ChoiceClick(NailPattern.FrenchTip); break; // Parlez-vous français?
                case Keys.D: ChoiceClick(NailPattern.Empty); break;
            }
        }

        // SET NAIL PATTERN FROM THE CLICKED NAIL BTN
        public void ChoiceClick(NailPattern pattern)
        {
            Designer.nail.pattern = pattern;
            Navigator.GotoRetain<Designer, ChoosePattern>();
        }

        // BY USING THE METHOD ABOVE THE CORRESPONDING NAIL SHAPE IS SET
        private void FireStyleClick(object sender, EventArgs e)
        {
            ChoiceClick(NailPattern.Fire);
        }
        private void LeafStyleClick(object sender, EventArgs e)
        {
            ChoiceClick(NailPattern.Leaf);
        }
        private void StarsStyleClick(object sender, EventArgs e)
        {
            ChoiceClick(NailPattern.Stars);
        }
        private void HeartsStyleClick(object sender, EventArgs e)
        {
            ChoiceClick(NailPattern.Hearts);
        }
        private void LeavesStyleClick(object sender, EventArgs e)
        {
            ChoiceClick(NailPattern.Leaves);
        }
        private void SnowFlakeStyleClick(object sender, EventArgs e)
        {
            ChoiceClick(NailPattern.Snowflake);
        }
        private void TrianglesClick(object sender, EventArgs e)
        {
            ChoiceClick(NailPattern.Triangles);
        }
        private void YinYangClick(object sender, EventArgs e)
        {
            ChoiceClick(NailPattern.Yinyang);
        }
        private void ButterflyClick(object sender, EventArgs e)
        {
            ChoiceClick(NailPattern.Butterfly);
        }
        private void SnakeClick(object sender, EventArgs e)
        {
            ChoiceClick(NailPattern.Snake);
        }
        private void FrenchTipClick(object sender, EventArgs e)
        {
            ChoiceClick(NailPattern.FrenchTip);
        }
        private void EmptyPicBoxClick(object sender, EventArgs e)
        {
            ChoiceClick(NailPattern.Empty);
        }

        // METHODS TO MAKE THE HOVER EFFECT WHEN HOVERING OVER A PICTURE BOX 
        private void Darken(object sender, EventArgs e) => NailUtil.Darken((PictureBox)sender);
        private void Lighten(object sender, EventArgs e) => NailUtil.Lighten((PictureBox)sender);

        // WHEN THE BACK BTN IS PRESSED
        private void BackBtnClick(object sender, EventArgs e)
        {
            Navigator.GotoRetain<Designer, ChoosePattern>();
        }
    }
}
