using System.Windows.Forms;
using System;
using Noktinator.Util;

namespace Noktinator
{
    public partial class SkinChoice : BaseForm
    {
        public SkinChoice()
        {
            InitializeComponent();
            this.KeyDown += SkinChoiceKeyDown;
        }

        void SkinChoiceKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D1: SkinSelection(button1); break;
                case Keys.D2: SkinSelection(button2); break;
                case Keys.D3: SkinSelection(button3); break;
                case Keys.D4: SkinSelection(button4); break;
                case Keys.D5: SkinSelection(button5); break;
                case Keys.D6: SkinSelection(button6); break;
                case Keys.D7: SkinSelection(button7); break;
                case Keys.D8: SkinSelection(button8); break;
                case Keys.D9: SkinSelection(button9); break;
            }
        }

        public void SkinSelection(Button btn)
        {
            FingerMenu.nail.skinColor = btn.BackColor;
            Navigator.GotoRetain<FingerMenu, SkinChoice>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SkinSelection(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SkinSelection(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SkinSelection(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SkinSelection(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SkinSelection(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SkinSelection(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SkinSelection(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SkinSelection(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SkinSelection(button9);
        }
    }
}
