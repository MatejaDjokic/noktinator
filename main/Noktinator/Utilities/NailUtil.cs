using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Drawing;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;

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
        public static Nail GetDefaultData()
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
        public static Bitmap GetDefault()
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

        /// <summary>
        /// Shows a SaveFileDialog with which the user chooses a place to save the img image
        /// </summary>
        /// <param name="img"></param>
        public static void DownloadNailImage(Nail nail)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Images|*.png;*.jpg;*.jpeg";

            ImageFormat format = ImageFormat.Png;
            string strFormat = format.ToString().ToLower();
            string shape = nail.shape.ToString().ToLower();
            string pattern = nail.pattern.ToString().ToLower();

            string fileName = $"nail_{shape}_shape_with_{pattern}_pattern";

            string downloadFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";
            string[] files = Directory.GetFiles(downloadFolderPath);

            string[] onlyLocalFilepath = files.Select(x => x.Replace($"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\\Downloads\\", "")).ToArray();
            string[] thatStartWithNail = onlyLocalFilepath.Where(x => x.StartsWith("nail_")).ToArray();
            string[] withoutExtension = thatStartWithNail.Select(x => x.Replace(".png", "")).ToArray();
            string text = string.Join("\n", withoutExtension);

            int idx = 1;
            string newFileName = $"{fileName}_{idx}";
            if (withoutExtension.Contains(fileName))
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to download the nail again?",
                    "Save Nail Image Copy",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );
                if (result == DialogResult.Yes)
                    while (withoutExtension.Contains(newFileName))
                    {
                        newFileName = $"{fileName}_{idx}";
                        idx++;
                    }
            }
            dialog.FileName = newFileName;
            if (dialog.ShowDialog() == DialogResult.OK)
                nail.GetImage().Save(dialog.FileName, format);
        }

        public static void DownloadFinger(string fingerName, Image img)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Images|*.png;*.jpg;*.jpeg";

            ImageFormat format = ImageFormat.Png;
            dialog.FileName = $"{fingerName}.png";

            if (dialog.ShowDialog() == DialogResult.OK)
                img.Save(dialog.FileName, format);
        }

        public static void DownloadAllFingers(
            Image finger1,
            Image finger2,
            Image finger3,
            Image finger4,
            Image finger5)
        {
            int spacing = 20; // 20 px spacing between fingers
            int finger_width = new int[]
            {
                finger1.Width,
                finger2.Width,
                finger3.Width,
                finger4.Width,
                finger5.Width,
            }.Sum() / 5;
            int width = 5 * finger_width + 6 * spacing;

            int height = new int[]
            {
                finger1.Height,
                finger2.Height,
                finger3.Height,
                finger4.Height,
                finger5.Height,
            }.Sum() / 5 + 2 * spacing;

            Bitmap bmp = new Bitmap(width, height);

            Image[] fingers = new Image[] { finger1, finger2, finger3, finger4, finger5 };

            using (Graphics g = Graphics.FromImage(bmp))
                for (int i = 0; i < fingers.Length; i++)
                    g.DrawImage(fingers[i], (i + 1) * spacing + i * finger_width, spacing);

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Images|*.png;*.jpg;*.jpeg";

            ImageFormat format = ImageFormat.Png;
            dialog.FileName = $"all_fingers.png";

            if (dialog.ShowDialog() == DialogResult.OK)
                bmp.Save(dialog.FileName, format);
        }

        /// <summary>
        /// Opens the "Downloads" folder of the current user
        /// </summary>
        public static void OpenDownloadsFolder()
        {
            string downloadFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            Process.Start(downloadFolderPath);
        }

        /// <summary>
        /// Returns Color.Black if the color is a light color and Color.White if the color is a dark color
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public static Color GetContrastingColor(Color color)
        {
            double luminance = (0.299 * color.R + 0.587 * color.G + 0.114 * color.B) / 255;
            double threshold = 0.5;
            if (luminance > threshold)
                return Color.Black;
            else
                return Color.White;
        }
    }
}
