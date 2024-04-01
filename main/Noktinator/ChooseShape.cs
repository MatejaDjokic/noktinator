﻿using System;
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
    public partial class ChooseShape : Form
    {
        public ChooseShape()
        {
            InitializeComponent();
        }

        public void choiceClick(NailShapes shapeEnum) 
        {
            FingerMenu fingerMenu = (FingerMenu)Application.OpenForms["FingerMenu"];
            FingerMenu.nail.nailShape = shapeEnum; //noktu u glavnom editoru za atribut shape daje odredjeni oblik
            
            this.Hide();
            fingerMenu.Show();
        }

        private void Almond_Click(object sender, EventArgs e)
        {
            choiceClick(NailShapes.Almond);
        }

        private void Ballerina_Click(object sender, EventArgs e)
        {
            choiceClick(NailShapes.Ballerina);
        }

        private void Lipstick_Click(object sender, EventArgs e)
        {
            choiceClick(NailShapes.Lipstick);
        }

        private void Mountain_peak_Click(object sender, EventArgs e)
        {
            choiceClick(NailShapes.MountainPeak);
        }

        private void Oval_Click(object sender, EventArgs e)
        {
            choiceClick(NailShapes.Oval);
        }

        private void Rounded_Click(object sender, EventArgs e)
        {
            choiceClick(NailShapes.Rounded);
        }

        private void Short_Click(object sender, EventArgs e)
        {
            choiceClick(NailShapes.Short);
        }

        private void Squoval_Click(object sender, EventArgs e)
        {
            choiceClick(NailShapes.Squoval);
        }

        private void Stiletto_Click(object sender, EventArgs e)
        {
            choiceClick(NailShapes.Stiletto);
        }

        private void Wide_Click(object sender, EventArgs e)
        {
            choiceClick(NailShapes.Wide);
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