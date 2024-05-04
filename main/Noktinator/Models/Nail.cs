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
        private Image _patternImage;

        public Nail(
            Color nailColor,
            Color skinColor,
            NailShape shape = NailShape.Almond,
            NailPattern pattern = NailPattern.Empty,
            Image nailShapeImage = default,
            Image fingerShapeImage = default,
            Image patternImage = default)
        {
            _nailColor = nailColor;
            _patternColor = Color.Transparent;
            _skinColor = skinColor;
            _nailShape = shape;
            _nailPattern = pattern;
            _nailShapeImage = nailShapeImage;
            _fingerShapeImage = fingerShapeImage;
            _patternImage = patternImage;
            Update();
        }

        public NailShape shape
        {
            get { return _nailShape; }
            set
            {
                _nailShape = value;
                Update();
            }
        }
        public NailPattern pattern
        {
            get { return _nailPattern; }
            set
            {
                _nailPattern = value;
                Update();
            }
        }
        public Color shapeColor
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
        public Image fingerShapeImage()
        {
            return _fingerShapeImage;
        }
        public Image patternImage()
        {
            return _patternImage;
        }

        public void Update()
        {
            ChangePattern();
            ChangeShape();
        }
        public void ChangeShape()
        {
            switch (_nailShape)
            {
                case NailShape.Almond:
                    _nailShapeImage = Properties.Resources.almond_tip;
                    _fingerShapeImage = Properties.Resources.almond_finger;
                    break;

                case NailShape.Ballerina:
                    _nailShapeImage = Properties.Resources.ballerina_tip;
                    _fingerShapeImage = Properties.Resources.ballerina_finger;
                    break;

                case NailShape.Lipstick:
                    _nailShapeImage = Properties.Resources.lipstick_tip;
                    _fingerShapeImage = Properties.Resources.lipstick_finger;
                    break;

                case NailShape.MountainPeak:
                    _nailShapeImage = Properties.Resources.mountain_peak_tip;
                    _fingerShapeImage = Properties.Resources.mountain_peak_finger;
                    break;

                case NailShape.Oval:
                    _nailShapeImage = Properties.Resources.oval_tip;
                    _fingerShapeImage = Properties.Resources.oval_finger;
                    break;

                case NailShape.Rounded:
                    _nailShapeImage = Properties.Resources.rounded_tip;
                    _fingerShapeImage = Properties.Resources.rounded_finger;
                    break;

                case NailShape.Short:
                    _nailShapeImage = Properties.Resources.short_tip;
                    _fingerShapeImage = Properties.Resources.short_finger;
                    break;

                case NailShape.Squoval:
                    _nailShapeImage = Properties.Resources.squoval_tip;
                    _fingerShapeImage = Properties.Resources.squoval_finger;
                    break;

                case NailShape.Stiletto:
                    _nailShapeImage = Properties.Resources.stiletto_tip;
                    _fingerShapeImage = Properties.Resources.stiletto_finger;
                    break;

                case NailShape.Wide:
                    _nailShapeImage = Properties.Resources.wide_tip;
                    _fingerShapeImage = Properties.Resources.wide_finger;
                    break;
            }
        }
        public void ChangePattern()
        {
            switch (pattern)
            {
                case NailPattern.Empty:
                    _patternImage = NailUtil.none;
                    break;
                case NailPattern.Fire:
                    switch (shape)
                    {
                        case NailShape.Almond:
                            _patternImage = Properties.Resources.fire_pattern_almond;
                            break;
                        case NailShape.Ballerina:
                            _patternImage = Properties.Resources.fire_pattern_almond;
                            break;
                        case NailShape.Lipstick:
                            _patternImage = Properties.Resources.fire_pattern_almond;
                            break;
                        case NailShape.MountainPeak:
                            _patternImage = Properties.Resources.fire_pattern_almond;
                            break;
                        case NailShape.Oval:
                            _patternImage = Properties.Resources.fire_pattern_almond;
                            break;
                        case NailShape.Rounded:
                            _patternImage = Properties.Resources.fire_pattern_rounded;
                            break;
                        case NailShape.Short:
                            _patternImage = Properties.Resources.fire_pattern_short;
                            break;
                        case NailShape.Squoval:
                            _patternImage = Properties.Resources.fire_pattern_squoval;
                            break;
                        case NailShape.Stiletto:
                            _patternImage = Properties.Resources.fire_pattern_stiletto;
                            break;
                        case NailShape.Wide:
                            _patternImage = Properties.Resources.fire_pattern_almond;
                            break;
                    }
                    break;

                case NailPattern.Leaf:
                    switch (shape)
                    {
                        case NailShape.Almond:
                            _patternImage = Properties.Resources.leaf_pattern_almond;
                            break;
                        case NailShape.Ballerina:
                            _patternImage = Properties.Resources.leaf_pattern_almond;
                            break;
                        case NailShape.Lipstick:
                            _patternImage = Properties.Resources.leaf_pattern_lipstick;
                            break;
                        case NailShape.MountainPeak:
                            _patternImage = Properties.Resources.leaf_pattern_almond;
                            break;
                        case NailShape.Oval:
                            _patternImage = Properties.Resources.leaf_pattern_oval;
                            break;
                        case NailShape.Rounded:
                            _patternImage = Properties.Resources.leaf_pattern_almond;
                            break;
                        case NailShape.Short:
                            _patternImage = Properties.Resources.leaf_pattern_short;
                            break;
                        case NailShape.Squoval:
                            _patternImage = Properties.Resources.leaf_pattern_almond;
                            break;
                        case NailShape.Stiletto:
                            _patternImage = Properties.Resources.leaf_pattern_stiletto;
                            break;
                        case NailShape.Wide:
                            _patternImage = Properties.Resources.leaf_pattern_wide;
                            break;
                    }
                    break;

                case NailPattern.Stars:
                    switch (shape)
                    {
                        case NailShape.Almond:
                            _patternImage = Properties.Resources.stars_pattern_almond;
                            break;
                        case NailShape.Ballerina:
                            _patternImage = Properties.Resources.stars_pattern_almond;
                            break;
                        case NailShape.Lipstick:
                            _patternImage = Properties.Resources.stars_pattern_almond;
                            break;
                        case NailShape.MountainPeak:
                            _patternImage = Properties.Resources.stars_pattern_almond;
                            break;
                        case NailShape.Oval:
                            _patternImage = Properties.Resources.stars_pattern_oval;
                            break;
                        case NailShape.Rounded:
                            _patternImage = Properties.Resources.stars_pattern_almond;
                            break;
                        case NailShape.Short:
                            _patternImage = Properties.Resources.stars_pattern_short;
                            break;
                        case NailShape.Squoval:
                            _patternImage = Properties.Resources.stars_pattern_almond;
                            break;
                        case NailShape.Stiletto:
                            _patternImage = Properties.Resources.stars_pattern_stiletto;
                            break;
                        case NailShape.Wide:
                            _patternImage = Properties.Resources.stars_pattern_wide;
                            break;
                    }
                    break;

                case NailPattern.Hearts:
                    switch (shape)
                    {
                        case NailShape.Almond:
                            _patternImage = Properties.Resources.heart_pattern_almond;
                            break;
                        case NailShape.Ballerina:
                            _patternImage = Properties.Resources.heart_pattern_almond;
                            break;
                        case NailShape.Lipstick:
                            _patternImage = Properties.Resources.heart_pattern_almond;
                            break;
                        case NailShape.MountainPeak:
                            _patternImage = Properties.Resources.heart_pattern_almond;
                            break;
                        case NailShape.Oval:
                            _patternImage = Properties.Resources.heart_pattern_almond;
                            break;
                        case NailShape.Rounded:
                            _patternImage = Properties.Resources.heart_pattern_rounded;
                            break;
                        case NailShape.Short:
                            _patternImage = Properties.Resources.heart_pattern_short;
                            break;
                        case NailShape.Squoval:
                            _patternImage = Properties.Resources.heart_pattern_squoval;
                            break;
                        case NailShape.Stiletto:
                            _patternImage = Properties.Resources.heart_pattern_stiletto;
                            break;
                        case NailShape.Wide:
                            _patternImage = Properties.Resources.heart_pattern_almond;
                            break;
                    }
                    break;

                case NailPattern.Leaves:
                    switch (shape)
                    {
                        case NailShape.Almond:
                            _patternImage = Properties.Resources.leaves_pattern_almond;
                            break;
                        case NailShape.Ballerina:
                            _patternImage = Properties.Resources.leaves_pattern_almond;
                            break;
                        case NailShape.Lipstick:
                            _patternImage = Properties.Resources.leaves_pattern_almond;
                            break;
                        case NailShape.MountainPeak:
                            _patternImage = Properties.Resources.leaves_pattern_almond;
                            break;
                        case NailShape.Oval:
                            _patternImage = Properties.Resources.leaves_pattern_almond;
                            break;
                        case NailShape.Rounded:
                            _patternImage = Properties.Resources.leaves_pattern_rounded;
                            break;
                        case NailShape.Short:
                            _patternImage = Properties.Resources.leaves_pattern_short;
                            break;
                        case NailShape.Squoval:
                            _patternImage = Properties.Resources.leaves_pattern_squoval;
                            break;
                        case NailShape.Stiletto:
                            _patternImage = Properties.Resources.leaves_pattern_stiletto;
                            break;
                        case NailShape.Wide:
                            _patternImage = Properties.Resources.leaves_pattern_almond;
                            break;
                    }
                    break;

                case NailPattern.Snowflake:
                    switch (shape)
                    {
                        case NailShape.Almond:
                            _patternImage = Properties.Resources.snowflake_pattern_almond;
                            break;
                        case NailShape.Ballerina:
                            _patternImage = Properties.Resources.snowflake_pattern_almond;
                            break;
                        case NailShape.Lipstick:
                            _patternImage = Properties.Resources.snowflake_pattern_almond;
                            break;
                        case NailShape.MountainPeak:
                            _patternImage = Properties.Resources.snowflake_pattern_almond;
                            break;
                        case NailShape.Oval:
                            _patternImage = Properties.Resources.snowflake_pattern_almond;
                            break;
                        case NailShape.Rounded:
                            _patternImage = Properties.Resources.snowflake_pattern_almond;
                            break;
                        case NailShape.Short:
                            _patternImage = Properties.Resources.snowflake_pattern_short;
                            break;
                        case NailShape.Squoval:
                            _patternImage = Properties.Resources.snowflake_pattern_almond;
                            break;
                        case NailShape.Stiletto:
                            _patternImage = Properties.Resources.snowflake_pattern_stiletto;
                            ;
                            break;
                        case NailShape.Wide:
                            _patternImage = Properties.Resources.snowflake_pattern_almond;
                            break;
                    }
                    break;

                case NailPattern.Triangles:
                    switch (shape)
                    {
                        case NailShape.Almond:
                            _patternImage = Properties.Resources.triangles_pattern_almond;
                            break;
                        case NailShape.Ballerina:
                            _patternImage = Properties.Resources.triangles_pattern_almond;
                            break;
                        case NailShape.Lipstick:
                            _patternImage = Properties.Resources.triangles_pattern_almond;
                            break;
                        case NailShape.MountainPeak:
                            _patternImage = Properties.Resources.triangles_pattern_almond;
                            break;
                        case NailShape.Oval:
                            _patternImage = Properties.Resources.triangles_pattern_almond;
                            break;
                        case NailShape.Rounded:
                            _patternImage = Properties.Resources.triangles_pattern_almond;
                            break;
                        case NailShape.Short:
                            _patternImage = Properties.Resources.triangles_pattern_almond;
                            break;
                        case NailShape.Squoval:
                            _patternImage = Properties.Resources.triangles_pattern_almond;
                            break;
                        case NailShape.Stiletto:
                            _patternImage = Properties.Resources.triangles_pattern_almond;
                            break;
                        case NailShape.Wide:
                            _patternImage = Properties.Resources.triangles_pattern_almond;
                            break;
                    }
                    break;

                case NailPattern.Yinyang:
                    switch (shape)
                    {
                        case NailShape.Almond:
                            _patternImage = Properties.Resources.yinyang_pattern_almond;
                            break;
                        case NailShape.Ballerina:
                            _patternImage = Properties.Resources.yinyang_pattern_almond;
                            break;
                        case NailShape.Lipstick:
                            _patternImage = Properties.Resources.yinyang_pattern_almond;
                            break;
                        case NailShape.MountainPeak:
                            _patternImage = Properties.Resources.yinyang_pattern_almond;
                            break;
                        case NailShape.Oval:
                            _patternImage = Properties.Resources.yinyang_pattern_almond;
                            break;
                        case NailShape.Rounded:
                            _patternImage = Properties.Resources.yinyang_pattern_almond;
                            break;
                        case NailShape.Short:
                            _patternImage = Properties.Resources.yinyang_pattern_almond;
                            break;
                        case NailShape.Squoval:
                            _patternImage = Properties.Resources.yinyang_pattern_almond;
                            break;
                        case NailShape.Stiletto:
                            _patternImage = Properties.Resources.yinyang_pattern_stiletto;
                            break;
                        case NailShape.Wide:
                            _patternImage = Properties.Resources.yinyang_pattern_almond;
                            break;
                    }
                    break;

                case NailPattern.Butterfly:
                    switch (shape)
                    {
                        case NailShape.Almond:
                            _patternImage = Properties.Resources.butterfly_pattern_almond;
                            break;
                        case NailShape.Ballerina:
                            _patternImage = Properties.Resources.butterfly_pattern_almond;
                            break;
                        case NailShape.Lipstick:
                            _patternImage = Properties.Resources.butterfly_pattern_almond;
                            break;
                        case NailShape.MountainPeak:
                            _patternImage = Properties.Resources.butterfly_pattern_almond;
                            break;
                        case NailShape.Oval:
                            _patternImage = Properties.Resources.butterfly_pattern_almond;
                            break;
                        case NailShape.Rounded:
                            _patternImage = Properties.Resources.butterfly_pattern_almond;
                            break;
                        case NailShape.Short:
                            _patternImage = Properties.Resources.butterfly_pattern_almond;
                            break;
                        case NailShape.Squoval:
                            _patternImage = Properties.Resources.butterfly_pattern_almond;
                            break;
                        case NailShape.Stiletto:
                            _patternImage = Properties.Resources.butterfly_pattern_stiletto;
                            break;
                        case NailShape.Wide:
                            _patternImage = Properties.Resources.butterfly_pattern_almond;
                            break;
                    }
                    break;


                case NailPattern.Snake:
                    switch (shape)
                    {
                        case NailShape.Almond:
                            _patternImage = Properties.Resources.snake_patern_almond;
                            break;
                        case NailShape.Ballerina:
                            _patternImage = Properties.Resources.snake_patern_almond;
                            break;
                        case NailShape.Lipstick:
                            _patternImage = Properties.Resources.snake_patern_almond;
                            break;
                        case NailShape.MountainPeak:
                            _patternImage = Properties.Resources.snake_patern_almond;
                            break;
                        case NailShape.Oval:
                            _patternImage = Properties.Resources.snake_patern_almond;
                            break;
                        case NailShape.Rounded:
                            _patternImage = Properties.Resources.snake_patern_almond;
                            break;
                        case NailShape.Short:
                            _patternImage = Properties.Resources.snake_patern_almond;
                            break;
                        case NailShape.Squoval:
                            _patternImage = Properties.Resources.snake_patern_almond;
                            break;
                        case NailShape.Stiletto:
                            _patternImage = Properties.Resources.snake_patern_almond;
                            break;
                        case NailShape.Wide:
                            _patternImage = Properties.Resources.snake_patern_almond;
                            break;
                    }
                    break;


            }
        }

        public Image GetImage()
        {
            Bitmap coloredNail = NailUtil.ColorBitmap((Bitmap)_nailShapeImage, _nailColor);
            Bitmap coloredFinger = NailUtil.ColorBitmap((Bitmap)_fingerShapeImage, _skinColor);
            Bitmap coloredPattern = NailUtil.ColorBitmap((Bitmap)_patternImage, _patternColor);
            Bitmap fullFinger = NailUtil.MergeBitmaps(coloredNail, coloredFinger, coloredPattern);
            return fullFinger;
        }
    }
}
