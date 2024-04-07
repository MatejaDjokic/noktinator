using System;
using System.Collections.Generic;
using System.Drawing;

namespace Noktinator
{
    public class Nail
    {
        private NailShape _nailShape;
        private NailPattern _nailPattern;
        private Color _nailColor = Color.White;
        private Color _patternColor = Color.Black;
        private Color _skinColor = Color.White;

        private Image _nailShapeImage;
        private Image _fingerShapeImage;

        public Nail(
            NailShape shape = NailShape.Almond,
            NailPattern pattern = NailPattern.FireStyle,
            Color nailColor = default,
            Color patternColor = default,
            Color skinColor = default,
            Image nailShapeImage = default,
            Image fingerShapeImage = default)
        {
            _nailShape = shape;
            _nailPattern = pattern;
            _nailColor = nailColor;
            _patternColor = patternColor;
            _skinColor = skinColor;
            _nailShapeImage = nailShapeImage;
            _fingerShapeImage = fingerShapeImage;
            ChangeShape();
        }

        public NailShape nailShape
        {
            get { return _nailShape; }
            set
            {
                _nailShape = value;
                ChangeShape();
            }
        }
        public NailPattern nailPattern
        {
            get { return _nailPattern; }
            set
            {
                _nailPattern = value;
                ChangeShape();
            }
        }
        public Color nailColor
        {
            get { return _nailColor; }
            set { _nailColor = value; }
        }
        public Color patternColor
        {
            get { return _patternColor; }
            set { _patternColor = value; }
        }
        public Color skinColor
        {
            get { return _skinColor; }
            set { _skinColor = value; }
        }

        public Image nailShapeImage()
        {
            return _nailShapeImage;
        }
        public Image nailPatternImage()
        {
            return _nailShapeImage;
        }
        public Image fingerShapeImage()
        {
            return _fingerShapeImage;
        }

        public void ChangeShape()
        {
            switch (_nailShape)
            {
                case Noktinator.NailShape.Almond:
                    _nailShapeImage = Properties.Resources.almond_tip;
                    _fingerShapeImage = Properties.Resources.almond_finger;
                    break;

                case Noktinator.NailShape.Ballerina:
                    _nailShapeImage = Properties.Resources.ballerina_tip;
                    _fingerShapeImage = Properties.Resources.ballerina_finger;
                    break;

                case Noktinator.NailShape.Lipstick:
                    _nailShapeImage = Properties.Resources.lipstick_tip;
                    _fingerShapeImage = Properties.Resources.lipstick_finger;
                    break;

                case Noktinator.NailShape.MountainPeak:
                    _nailShapeImage = Properties.Resources.mountain_peak_tip;
                    _fingerShapeImage = Properties.Resources.mountain_peak_finger;
                    break;

                case Noktinator.NailShape.Oval:
                    _nailShapeImage = Properties.Resources.oval_tip;
                    _fingerShapeImage = Properties.Resources.oval_finger;
                    break;

                case Noktinator.NailShape.Rounded:
                    _nailShapeImage = Properties.Resources.rounded_tip;
                    _fingerShapeImage = Properties.Resources.rounded_finger;
                    break;

                case Noktinator.NailShape.Short:
                    _nailShapeImage = Properties.Resources.short_tip;
                    _fingerShapeImage = Properties.Resources.short_finger;
                    break;

                case Noktinator.NailShape.Squoval:
                    _nailShapeImage = Properties.Resources.squoval_tip;
                    _fingerShapeImage = Properties.Resources.squoval_finger;
                    break;

                case Noktinator.NailShape.Stiletto:
                    _nailShapeImage = Properties.Resources.stiletto_tip;
                    _fingerShapeImage = Properties.Resources.stiletto_finger;
                    break;

                case Noktinator.NailShape.Wide:
                    _nailShapeImage = Properties.Resources.wide_tip;
                    _fingerShapeImage = Properties.Resources.wide_finger;
                    break;
            }
        }
        public Image GetImage()
        {
            Bitmap coloredNail = NailUtils.ColorBitmap((Bitmap)_nailShapeImage, _nailColor);
            Bitmap coloredFinger = NailUtils.ColorBitmap((Bitmap)_fingerShapeImage, _skinColor);
            Bitmap fullFinger = NailUtils.OverlapBitmaps(coloredNail, coloredFinger);
            return fullFinger;
        }

        public static Nail Random()
        {
            return new Nail(
                shape: Nail.RandomShape(),
                pattern: Nail.RandomPattern(),
                nailColor: Nail.RandomColor(),
                patternColor: Nail.RandomColor(),
                skinColor: Nail.RandomSkinColor()
            );
        }
        private static NailShape RandomShape()
        {
            return (NailShape)Nail.RandomIndexForEnum<NailShape>();
        }
        private static NailPattern RandomPattern()
        {
            return (NailPattern)Nail.RandomIndexForEnum<NailPattern>();
        }
        private static int RandomIndexForEnum<T>()
        {
            Random rnd = new Random();
            int enumLength = Enum.GetValues(typeof(T)).Length;
            return rnd.Next(enumLength);
        }
        private static Color RandomColor()
        {
            Random rnd = new Random();
            return Color.FromArgb(
                red: rnd.Next(256),
                green: rnd.Next(256),
                blue: rnd.Next(256)
            );
        }
        private static Color RandomSkinColor()
        {
            List<Color> skinColors = new List<Color> {
                Color.FromArgb(255, 195, 170),
                Color.FromArgb(240, 184, 160),
                Color.FromArgb(210, 161, 140),
                Color.FromArgb(150, 114, 100),
                Color.FromArgb(120, 92, 80),
                Color.FromArgb(90, 69, 60),
                Color.FromArgb(75, 57, 50),
                Color.FromArgb(60, 46, 60),
                Color.FromArgb(45, 34, 40),
            };
            return skinColors[new Random().Next(skinColors.Count)];
        }
    }
}
