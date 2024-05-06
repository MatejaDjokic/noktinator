using System.Windows.Forms;
using Noktinator.Util;
using System;

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
                case Keys.Escape: Navigator.GotoRetain<Designer, SkinChoice>(); break;
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

        // METHOD THAT SETS THE COLOR IN THE NAIL CLASS
        // TO THE COLOR OF THE SELECTED SKIN COLOR
        // AND RETURNS BACK TO THE FINGER MENU PAGE
        public void SkinSelection(Button btn)
        {
            Designer.nail.skinColor = btn.BackColor;
            Navigator.GotoRetain<Designer, SkinChoice>();
        }

        // METHODS FOR CHOOSING YOUR SKIN COLOR
        private void skin1Click(object sender, EventArgs e)
        {
            SkinSelection(button1);
        }
        private void skin2Click(object sender, EventArgs e)
        {
            SkinSelection(button2);
        }
        private void skin3Click(object sender, EventArgs e)
        {
            SkinSelection(button3);
        }
        private void sking4Click(object sender, EventArgs e)
        {
            SkinSelection(button4);
        }
        private void sking5Click(object sender, EventArgs e)
        {
            SkinSelection(button5);
        }
        private void skin6Click(object sender, EventArgs e)
        {
            SkinSelection(button6);
        }
        private void sking7Click(object sender, EventArgs e)
        {
            SkinSelection(button7);
        }
        private void skin8Click(object sender, EventArgs e)
        {
            SkinSelection(button8);
        }
        private void skin9Click(object sender, EventArgs e)
        {
            SkinSelection(button9);
        }

        // WHEN BACK BTN IS PRESSED
        private void BackBtnClick(object sender, EventArgs e)
        {
            Navigator.GotoRetain<Designer, SkinChoice>();
        }
    }
}
