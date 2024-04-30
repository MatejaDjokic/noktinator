using Noktinator.Util;
using System;
using System.Windows.Forms;

namespace Noktinator
{
    public partial class ChoosePattern : BaseForm
    {
        public ChoosePattern()
        {
            InitializeComponent();
            this.KeyDown += ChoosePatternKeyDown;
        }


        public void ChoiceClick(NailPattern pattern)
        {
            FingerMenu.nail.nailPattern = pattern; //noktu u glavnom editoru za atribut pattern daje odredjeni pattern
            Navigator.GotoRetain<FingerMenu, ChoosePattern>();
        }
        private void ChoosePatternKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D1: ChoiceClick(NailPattern.Fire); break;
                case Keys.D2: ChoiceClick(NailPattern.Leaf); break;
                case Keys.D3: ChoiceClick(NailPattern.Stars); break;
                case Keys.D4: ChoiceClick(NailPattern.Hearts); break;
                case Keys.D5: ChoiceClick(NailPattern.Leaves); break;
            }
        }

        private void FireStyle_Click(object sender, EventArgs e)
        {
            ChoiceClick(NailPattern.Fire);
        }

        private void LeafStyle_Click(object sender, EventArgs e)
        {
            ChoiceClick(NailPattern.Leaf);
        }

        private void StarsStyle_Click(object sender, EventArgs e)
        {
            ChoiceClick(NailPattern.Stars);
        }

        private void HeartsStyle_Click(object sender, EventArgs e)
        {
            ChoiceClick(NailPattern.Hearts);
        }

        private void LeavesStyle_Click(object sender, EventArgs e)
        {
            ChoiceClick(NailPattern.Leaves);
        }

        private void SnowFlakeStyle_Click(object sender, EventArgs e)
        {
            ChoiceClick(NailPattern.Snowflake);
        }

        private void Triangles_Click(object sender, EventArgs e)
        {
            ChoiceClick(NailPattern.Triangles);
        }
    }
}
