using System.Drawing;
using System;

namespace Noktinator
{
    public static class NailUtil
    {
        /// <summary>
        /// An empty bitmap of size 100x330
        /// </summary>
        public static readonly Bitmap none = new Bitmap(100, 330);

        /// <summary>
        /// Retuns the class data for a default nail
        /// </summary>
        /// <returns></returns>
        public static Nail GetDefaultNailData()
        {
            return new Nail(
               shape: NailShape.Almond,
               nailColor: Color.White,
               skinColor: Color.FromArgb(240, 184, 160)
            );
        }

        /// <summary>
        /// Returns a bitmap for a default nail
        /// </summary>
        /// <returns></returns>
        public static Bitmap GetDefaultNail()
        {
            Bitmap tip = ColorBitmap(Properties.Resources.almond_tip, Color.White);
            Bitmap finger = ColorBitmap(Properties.Resources.almond_finger, Color.FromArgb(240, 184, 160));
            return MergeBitmaps(tip, finger, none);
        }

        /// <summary>
        /// Merges 3 bitmaps together into one bitmap 
        /// <br></br> nail - bitmap representing the tip of the finger, the nail
        /// <br></br> finger - bitmap representing everything below the tip of the finger
        /// <br></br> pattern - bitmap representing the pattern that will be placed on the nail
        /// <param name="nail"></param>
        /// <param name="finger"></param>
        /// <param name="pattern"></param>
        /// <returns></returns>
        public static Bitmap MergeBitmaps(Bitmap nail, Bitmap finger, Bitmap pattern)
        {
            Bitmap merge = new Bitmap(finger.Width, finger.Height);
            using (Graphics g = Graphics.FromImage(merge))
            {
                g.DrawImage(finger, 0, 0);
                g.DrawImage(nail, 0, 0);
                g.DrawImage(pattern, 0, 0);
            }
            return merge;
        }

        /// <summary>
        /// Returs a bitmap with all white pixels on it colored to the given color
        /// </summary>
        /// <param name="bitmap"></param>
        /// <param name="color"></param>
        /// <returns></returns>
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

        /// <summary>
        /// A helper method for the ColorBitmap() method that checks if the color is withing the tolerance to paint it
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
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
