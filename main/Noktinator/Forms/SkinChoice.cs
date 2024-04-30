using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Noktinator
{
    public partial class SkinChoice : Form
    {
        public SkinChoice()
        {
            InitializeComponent();
        }

        private void SkinChoice_Load(object sender, EventArgs e)
        {

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
