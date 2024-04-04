using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nail_gallery
{
    public class Nail
    {
        Shape _shape;
        Pattern _pattern;
        Color _nailColor = Color.White;
        Color _patternColor = Color.Black;
        Color _skinColor = Color.White;

        Image _nailShapeImage;
        Image _fingerShapeImage;

        public Nail(
            Shape shape = Shape.Almond,
            Pattern pattern = Pattern.FireStyle,
            Color nailColor = default,
            Color patternColor = default,
            Color skinColor = default,
            Image nailShapeImage = default,
            Image fingerShapeImage = default)
        {
            _shape = shape;
            _pattern = pattern;
            _nailColor = nailColor;
            _patternColor = patternColor;
            _skinColor = skinColor;
            _nailShapeImage = nailShapeImage;
            _fingerShapeImage = fingerShapeImage;
            ChangeShape();
        }

        public Shape shape
        {
            get { return _shape; }
            set
            {
                _shape = value;
                ChangeShape();
            }
        }
        public Pattern pattern
        {
            get { return _pattern; }
            set
            {
                _pattern = value;
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

        public void ChangeShape()
        {
            switch (_shape)
            {
                case Shape.Almond:
                    _nailShapeImage = Properties.Resources.almond_tip;
                    _fingerShapeImage = Properties.Resources.almond_finger;
                    break;

                case Shape.Ballerina:
                    _nailShapeImage = Properties.Resources.ballerina_tip;
                    _fingerShapeImage = Properties.Resources.ballerina_finger;
                    break;

                case Shape.Lipstick:
                    _nailShapeImage = Properties.Resources.lipstick_tip;
                    _fingerShapeImage = Properties.Resources.lipstick_finger;
                    break;

                case Shape.MountainPeak:
                    _nailShapeImage = Properties.Resources.mountain_peak_tip;
                    _fingerShapeImage = Properties.Resources.mountain_peak_finger;
                    break;

                case Shape.Oval:
                    _nailShapeImage = Properties.Resources.oval_tip;
                    _fingerShapeImage = Properties.Resources.oval_finger;
                    break;

                case Shape.Rounded:
                    _nailShapeImage = Properties.Resources.rounded_tip;
                    _fingerShapeImage = Properties.Resources.rounded_finger;
                    break;

                case Shape.Short:
                    _nailShapeImage = Properties.Resources.short_tip;
                    _fingerShapeImage = Properties.Resources.short_finger;
                    break;

                case Shape.Squoval:
                    _nailShapeImage = Properties.Resources.squoval_tip;
                    _fingerShapeImage = Properties.Resources.squoval_finger;
                    break;

                case Shape.Stiletto:
                    _nailShapeImage = Properties.Resources.stiletto_tip;
                    _fingerShapeImage = Properties.Resources.stiletto_finger;
                    break;

                case Shape.Wide:
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
        private static Shape RandomShape()
        {
            return (Shape)Nail.RandomIndexForEnum<Shape>();
        }
        private static Pattern RandomPattern()
        {
            return (Pattern)Nail.RandomIndexForEnum<Pattern>();
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
            List<Color> skinColors = [
                Color.FromArgb(255, 195, 170),
                Color.FromArgb(240, 184, 160),
                Color.FromArgb(210, 161, 140),
                Color.FromArgb(150, 114, 100),
                Color.FromArgb(120, 92, 80),
                Color.FromArgb(90, 69, 60),
                Color.FromArgb(75, 57, 50),
                Color.FromArgb(60, 46, 60),
                Color.FromArgb(45, 34, 40),
            ];
            return skinColors[new Random().Next(skinColors.Count)];
        }
    }
}
