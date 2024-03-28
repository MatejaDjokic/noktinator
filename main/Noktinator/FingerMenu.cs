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
    public partial class FingerMenu : Form
    {
        public FingerMenu()
        {
            InitializeComponent();
        }
        
        Color bojaNokta = Color.Transparent;
        Color bojaPaterna = Color.Transparent;


        private void BojaNokta_Click(object sender, EventArgs e)
        {
            var res = NokatColorDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                bojaNokta = NokatColorDialog.Color;
            }
        }
        private void BojaPaterna_Click(object sender, EventArgs e)
        {
            var res = PaternColorDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                bojaPaterna = PaternColorDialog.Color;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        
    }
}
