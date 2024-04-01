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
    public partial class FingerPreview : Form
    {
       
        public static PictureBox ChosenField;

        Image TempImage;


        public FingerPreview()
        {
            InitializeComponent();
        }
        FingerMenu fingerMenu = new FingerMenu();

        public void FingerChoiceClick(PictureBox Field) 
        {
            ChosenField = Field;
            fingerMenu.Show();
            this.Hide();
        }

        private void MaliPrst_Click(object sender, EventArgs e)
        {
            FingerChoiceClick(MaliPrst);
        }

        private void DomaliPrst_Click(object sender, EventArgs e)
        {
            FingerChoiceClick(DomaliPrst);
        }

        private void SrednjiPrst_Click(object sender, EventArgs e)
        {
            FingerChoiceClick(SrednjiPrst);
        }

        private void KaziPrst_Click(object sender, EventArgs e)
        {
            FingerChoiceClick(KaziPrst);
        }

        private void Palac_Click(object sender, EventArgs e)
        {
            FingerChoiceClick(Palac);
        }

        //shadeovanje pri hoverovanju misem
        private void Darken(object sender, EventArgs e) 
        {
            PictureBox picBox = (PictureBox)sender;
            picBox.BackColor = Color.Plum;
        }

        private void Lighten(object sender, EventArgs e)
        {
            PictureBox picBox = (PictureBox)sender;
            picBox.BackColor = Color.Transparent;
        }


       
        //kopiranje slika
        private void MaliCopy_Click(object sender, EventArgs e)
        {
            TempImage = MaliPrst.Image;
        }

        private void DomaliCopy_Click(object sender, EventArgs e)
        {
            TempImage = DomaliPrst.Image;
        }

        private void SrednjiCopy_Click(object sender, EventArgs e)
        {
            TempImage = SrednjiPrst.Image;
        }

        private void KaziCopy_Click(object sender, EventArgs e)
        {
            TempImage = KaziPrst.Image;
        }

        private void PalacCopy_Click(object sender, EventArgs e)
        {
            TempImage = Palac.Image;
        }

        private void MaliPaste_Click(object sender, EventArgs e)
        {
            MaliPrst.Image = TempImage;
        }

        private void DomaliPaste_Click(object sender, EventArgs e)
        {
            DomaliPrst.Image = TempImage;
        }

        private void SrednjiPaste_Click(object sender, EventArgs e)
        {
            SrednjiPrst.Image = TempImage;
        }

        private void KaziPaste_Click(object sender, EventArgs e)
        {
            KaziPrst.Image = TempImage;
        }

        private void PalacPaste_Click(object sender, EventArgs e)
        {
            Palac.Image = TempImage;
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            StartMenu start = new StartMenu();
            start.Show();
            this.Hide();
        }
    }
}
