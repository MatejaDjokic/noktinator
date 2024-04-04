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


        public void choiceClick(NailPattern patternEnum)
        {
            FingerMenu fingerMenu = (FingerMenu)Application.OpenForms["FingerMenu"];
            
            FingerMenu.nail.nailPattern = patternEnum; //noktu u glavnom editoru za atribut pattern daje odredjeni pattern

            this.Hide();
            fingerMenu.Show();
        }

        private void FireStyle_Click(object sender, EventArgs e)
        {
            choiceClick(NailPattern.FireStyle);
        }

        private void LeafStyle_Click(object sender, EventArgs e)
        {
            choiceClick(NailPattern.LeafStyle);
        }

        private void StarsStyle_Click(object sender, EventArgs e)
        {
            choiceClick(NailPattern.StarsStyle);
        }

        private void HeartsStyle_Click(object sender, EventArgs e)
        {
            choiceClick(NailPattern.HeartsStyle);
        }

        private void LeavesStyle_Click(object sender, EventArgs e)
        {
            choiceClick(NailPattern.LeavesStyle);
        }
    }
}
