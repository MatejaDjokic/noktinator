namespace image_intersection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Image nail = (Image)ColorBitmap(Properties.Resources.almond_tip, Color.White);
            int nailWidth = nail.Width;
            int nailHeight = nail.Height;
            Image fireStyle = (Image)ColorBitmap(new Bitmap(Properties.Resources.LeafStyle, nailWidth / 3 * 2, nailHeight / 3 * 2), Color.White);
            this.pictureBox1.Image = OverlayBitmaps(new Bitmap(nail), new Bitmap(fireStyle));
        }

        public static Bitmap OverlayBitmaps(Bitmap baseBitmap, Bitmap overlayBitmap)
        {
            Bitmap resultBitmap = new Bitmap(baseBitmap.Width, baseBitmap.Height);

            using (Graphics g = Graphics.FromImage(resultBitmap))
            {
                g.DrawImage(baseBitmap, 0, 0);

                int x = (baseBitmap.Width - overlayBitmap.Width) / 2;
                int y = (baseBitmap.Height - overlayBitmap.Height) / 2;

                g.DrawImage(overlayBitmap, x, y);
            }

            return resultBitmap;
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
