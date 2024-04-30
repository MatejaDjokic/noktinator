using System.Windows.Forms;
using System.Drawing;
using System;

namespace Noktinator
{
    public partial class ChooseShape : Form
    {
        public ChooseShape()
        {
            InitializeComponent();
        }

        public void ChoiceClick(NailShape shapeEnum)
        {
            FingerMenu.nail.nailShape = shapeEnum; //noktu u glavnom editoru za atribut shape daje odredjeni oblik
            Navigator.Open<FingerMenu>();
            this.Hide();
            //Navigator.Goto<FingerMenu, ChoosePattern>();
        }

        private void Almond_Click(object sender, EventArgs e)
        {
            ChoiceClick(NailShape.Almond);
        }

        private void Ballerina_Click(object sender, EventArgs e)
        {
            ChoiceClick(NailShape.Ballerina);
        }

        private void Lipstick_Click(object sender, EventArgs e)
        {
            ChoiceClick(NailShape.Lipstick);
        }

        private void Mountain_peak_Click(object sender, EventArgs e)
        {
            ChoiceClick(NailShape.MountainPeak);
        }

        private void Oval_Click(object sender, EventArgs e)
        {
            ChoiceClick(NailShape.Oval);
        }

        private void Rounded_Click(object sender, EventArgs e)
        {
            ChoiceClick(NailShape.Rounded);
        }

        private void Short_Click(object sender, EventArgs e)
        {
            ChoiceClick(NailShape.Short);
        }

        private void Squoval_Click(object sender, EventArgs e)
        {
            ChoiceClick(NailShape.Squoval);
        }

        private void Stiletto_Click(object sender, EventArgs e)
        {
            ChoiceClick(NailShape.Stiletto);
        }

        private void Wide_Click(object sender, EventArgs e)
        {
            ChoiceClick(NailShape.Wide);
        }


        private void Darken(object sender, EventArgs e)
        {
            PictureBox senderPic = (PictureBox)sender;
            senderPic.BackColor = Color.Plum;
        }

        private void Lighten(object sender, EventArgs e)
        {
            PictureBox senderPic = (PictureBox)sender;
            senderPic.BackColor = Color.Transparent;
        }
    }
}
