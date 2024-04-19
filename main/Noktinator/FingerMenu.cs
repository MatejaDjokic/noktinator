using System.Windows.Forms;
using System.Drawing;
using System;

namespace Noktinator
{
    public partial class FingerMenu : Form
    {
        public FingerMenu()
        {
            InitializeComponent();

            this.FormClosing += FormClose;
        }

        public static Nail nail = new Nail();

        //slika koja se menja iz ChooseShape metode iz Nail.cs
        public static Image shape;
        public static Image pattern;

        //slika koja sluzi za kopiranje na FingerPreview
        public static Image copyImage;

        public static Bitmap fingerImage;
        private Bitmap nailImage;
        private Bitmap mergedImage;

        private void FingerMenuLoad(object sender, EventArgs e)
        {
            nail.ChangeShape();
            fingerImage = new Bitmap(nail.fingerShapeImage());
            nailImage = new Bitmap(nail.nailShapeImage());

            MergeImages();
        }

        private void FormClose(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //spajanje slike prsta i odgovarajuceg nokta
        public void MergeImages()
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

            fingerView.BackgroundImage = mergedImage;
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
        private void BojaNoktaClick(object sender, EventArgs e)
        {
            var res = NokatColorDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                nail.nailColor = NokatColorDialog.Color;

                // kreiranje nove instance bitmape za bojenje nokte
                nailImage = ColorBitmap(new Bitmap(nail.nailShapeImage()), NokatColorDialog.Color);
            }
            MergeImages();
        }

        //biranje boje paterna
        private void BojaPaternaClick(object sender, EventArgs e)
        {
            var res = PaternColorDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                nail.patternColor = NokatColorDialog.Color;
            }
        }

        //biranje boje koze
        private void RasaClick(object sender, EventArgs e)
        {
            SkinChoice a = new SkinChoice();
            a.Show();
            this.Hide();
        }

        //biranje oblika
        private void OblikNoktaClick(object sender, EventArgs e)
        {
            //ChooseShape forma na kojoj se biraju oblici noktiju
            ChooseShape chooseShape = new ChooseShape();
            chooseShape.Show();
            this.Hide();
        }


        private void FingerMenuVisibleChanged(object sender, EventArgs e)
        {
            nail.ChangeShape();

            //kad god se ponovo pojavi ova forma, prst i nokat ce imati poslednju sacuvanu boju
            nailImage = ColorBitmap(new Bitmap(nail.nailShapeImage()), nail.nailColor);
            fingerImage = ColorBitmap(new Bitmap(nail.fingerShapeImage()), nail.skinColor);
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
