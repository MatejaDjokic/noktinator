using System.Windows.Forms;
using System.Drawing;
using System;
using Noktinator.Util;

namespace Noktinator
{
    public partial class ChooseShape : BaseForm
    {
        public ChooseShape()
        {
            InitializeComponent();
            this.KeyDown += ChooseShapeKeyDown;
        }

        public void ChoiceClick(NailShape shapeEnum)
        {
            FingerMenu.nail.shape = shapeEnum; //noktu u glavnom editoru za atribut shape daje odredjeni oblik
            Navigator.GotoRetain<FingerMenu, ChooseShape>();
        }
        private void ChooseShapeKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
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
