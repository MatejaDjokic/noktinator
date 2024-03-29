using System.IO;
using System.IO.Packaging;
using System.Reflection;

namespace image_coloring
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.pictureBox1.Image = (Image)ColorBitmap(Properties.Resources.almond_tip, Color.Orange);
        }

        Bitmap ColorBitmap(Bitmap bmp, Color color)
        {
            int tolerance = 50;

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
    }
}
