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

        public static Nail nail = new Nail();
        
        //slika koja se menja iz ChooseShape metode iz Nail.cs
        public static Image shape;
        public static Image pattern;

        //slika koja sluzi za kopiranje na FingerPreview
        public static Image CopyImage;


        public static Bitmap fingerImage;
        private Bitmap nailImage;
        private Bitmap mergedImage;



        private void FingerMenu_Load_1(object sender, EventArgs e)
        {
            nail.ChangeShape();
            fingerImage = new Bitmap(nail.FingerShape);
            nailImage = new Bitmap(nail.NailShape);
            
            MergeImages(); 
        }
      
        public void MergeImages() //spajanje slike prsta i odgovarajuceg nokta
        {
            // nova bitmapa za drzanje spojenih slika
            mergedImage = new Bitmap(fingerImage.Width, fingerImage.Height);

            using (Graphics g = Graphics.FromImage(mergedImage))
            {
                //crtanje slike prsta
                g.DrawImage(fingerImage, new Point(0, 0));
                //crtanje slike nokta
                g.DrawImage(nailImage, new Point(0, 0));
            }

            // rezultat
            fingerView.Image = mergedImage;
        }

        Bitmap ColorBitmap(Bitmap bmp, Color color)
        {
            int tolerance = 120;

            for (int x = 0; x < bmp.Width; x++)
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color pixelColor = bmp.GetPixel(x, y);
                    if (ColorWithinTolerance(pixelColor, Color.White, tolerance))
                        bmp.SetPixel(x, y, color);
                }
            return bmp;
        }
        static bool ColorWithinTolerance(Color color1, Color color2, int tolerance)
        {
            return Math.Abs(color1.R - color2.R) <= tolerance &&
                   Math.Abs(color1.G - color2.G) <= tolerance &&
                   Math.Abs(color1.B - color2.B) <= tolerance;
        }

        //biranje boje nokta 
        private void BojaNokta_Click(object sender, EventArgs e)
        {
            var res = NokatColorDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                nail.nailColor = NokatColorDialog.Color;

                // kreiranje nove instance bitmape za bojenje nokte
                nailImage = ColorBitmap(new Bitmap(nail.NailShape), NokatColorDialog.Color);
            }
            MergeImages();
        }

        //biranje boje paterna
        private void BojaPaterna_Click(object sender, EventArgs e)
        {
            var res = PaternColorDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                nail.patternColor = NokatColorDialog.Color;
            }
        }

        //biranje boje koze
        private void Rasa_Click(object sender, EventArgs e)
        {
            SkinChoice a = new SkinChoice();
            a.Show();
            this.Hide();
        }

        //biranje oblika
        private void OblikNokta_Click(object sender, EventArgs e)
        {
           //ChooseShape forma na kojoj se biraju oblici noktiju
           ChooseShape chooseShape = new ChooseShape();
           chooseShape.Show();
           this.Hide();
        }

        
        private void FingerMenu_VisibleChanged(object sender, EventArgs e)
        {
            nail.ChangeShape();
            
            //kad god se ponovo pojavi ova forma, prst i nokat ce imati poslednju sacuvanu boju
            nailImage = ColorBitmap(new Bitmap(nail.NailShape), nail.nailColor);
            fingerImage = ColorBitmap(new Bitmap(nail.FingerShape), nail.skinColor);
            MergeImages();            
        }

        //biranje paterna
        private void Patern_Click(object sender, EventArgs e)
        {
            ChoosePattern choosePattern = new ChoosePattern();
            choosePattern.Show();
            this.Hide();
        }

            
        //kada se stisne nazad onda 
        private void Nazad_Click(object sender, EventArgs e)
        {
            FingerPreview fingerPreview = (FingerPreview)Application.OpenForms["FingerPreview"];
            FingerPreview.ChosenField.Image = fingerView.Image;

            fingerPreview.Show();
            this.Hide();
        }
    }
}
