﻿using System.Drawing.Drawing2D;
using System.Drawing;
using System;

namespace Noktinator
{
    public static class NailUtil
    {
        public static readonly Bitmap none = new Bitmap(100, 330);
        //public static readonly Bitmap none = (Bitmap)Properties.Resources.fire_pattern_almond;
        public static Bitmap GetDefaultNail()
        {
            Bitmap tip = NailUtil.ColorBitmap(Properties.Resources.almond_tip, Color.White);
            Bitmap finger = NailUtil.ColorBitmap(Properties.Resources.almond_finger, Color.FromArgb(240, 184, 160));
            return NailUtil.MergeBitmaps(tip, finger, none);
        }
        public static Bitmap MergeBitmaps(Bitmap finger, Bitmap nail, Bitmap pattern)
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