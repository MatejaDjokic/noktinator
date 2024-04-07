namespace nail_gallery
{
    public static class NailUtils
    {
        public static Bitmap OverlapBitmaps(Bitmap a, Bitmap b)
        {
            //
            Bitmap merge = new Bitmap(a.Width, a.Height);

            using (Graphics g = Graphics.FromImage(merge))
            {
                g.DrawImage(a, 0, 0);
                g.DrawImage(b, 0, 0);
            }

            return merge;
        }
        public static Bitmap ColorBitmap(Bitmap bitmap, Color color)
        {
            for (int x = 0; x < bitmap.Width; x++)
                for (int y = 0; y < bitmap.Height; y++)
                {
                    Color pixelColor = bitmap.GetPixel(x, y);
                    if (ColorWithinTolerance(pixelColor))
                        bitmap.SetPixel(x, y, color);
                }
            return bitmap;
        }
        private static bool ColorWithinTolerance(Color color)
        {
            Color check = Color.White;
            const int tolerance = 50;
            return Math.Abs(color.R - check.R) <= tolerance &&
                   Math.Abs(color.G - check.G) <= tolerance &&
                   Math.Abs(color.B - check.B) <= tolerance;
        }
    }
}
