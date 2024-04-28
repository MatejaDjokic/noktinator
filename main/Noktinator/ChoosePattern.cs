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
    public partial class ChoosePattern : Form
    {
        public ChoosePattern()
        {
            InitializeComponent();
        }


        public void choiceClick(NailPattern pattern)
        {
            FingerMenu fingerMenu = (FingerMenu)Application.OpenForms["FingerMenu"];
            
            FingerMenu.nail.nailPattern = pattern; //noktu u glavnom editoru za atribut pattern daje odredjeni pattern

            this.Hide();
            fingerMenu.Show();
        }

        private void FireStyle_Click(object sender, EventArgs e)
        {
            choiceClick(NailPattern.Fire);
        }

        private void LeafStyle_Click(object sender, EventArgs e)
        {
            choiceClick(NailPattern.Leaf);
        }

        private void StarsStyle_Click(object sender, EventArgs e)
        {
            choiceClick(NailPattern.Stars);
        }

        private void HeartsStyle_Click(object sender, EventArgs e)
        {
            choiceClick(NailPattern.Hearts);
        }

        private void LeavesStyle_Click(object sender, EventArgs e)
        {
            choiceClick(NailPattern.Leaves);
        }
    }
}
