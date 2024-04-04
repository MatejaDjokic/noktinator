using System;
using System.Drawing;

namespace Noktinator
{
    public class Nail
    {
        public NailShape nailShape;
        public NailPattern nailPattern;
        public Color nailColor = Color.White;
        public Color patternColor = Color.Black;
        public Color skinColor = Color.White;

        public Image nailShapeImage;
        public Image fingerShapeImage;

        public Nail()
        {
            ChangeShape();
        }
        public void SetPattern(NailPattern newPattern)
        {
            this.nailPattern = newPattern;
        }
        public void SetNailColor(Color newNailColor)
        {
            this.nailColor = newNailColor;
        }
        public void SetPatternColor(Color newPatternColor)
        {
            this.patternColor = newPatternColor;
        }
        public void ChangeShape()
        {
            switch (nailShape)
            {
                case Noktinator.NailShape.Almond:
                    nailShapeImage = Properties.Resources.almond_tip;
                    fingerShapeImage = Properties.Resources.almond_finger;
                    break;

                case Noktinator.NailShape.Ballerina:
                    nailShapeImage = Properties.Resources.ballerina_tip;
                    fingerShapeImage = Properties.Resources.ballerina_finger;
                    break;

                case Noktinator.NailShape.Lipstick:
                    nailShapeImage = Properties.Resources.lipstick_tip;
                    fingerShapeImage = Properties.Resources.lipstick_finger;
                    break;

                case Noktinator.NailShape.MountainPeak:
                    nailShapeImage = Properties.Resources.mountain_peak_tip;
                    fingerShapeImage = Properties.Resources.mountain_peak_finger;
                    break;

                case Noktinator.NailShape.Oval:
                    nailShapeImage = Properties.Resources.oval_tip;
                    fingerShapeImage = Properties.Resources.oval_finger;
                    break;

                case Noktinator.NailShape.Rounded:
                    nailShapeImage = Properties.Resources.rounded_tip;
                    fingerShapeImage = Properties.Resources.rounded_finger;
                    break;

                case Noktinator.NailShape.Short:
                    nailShapeImage = Properties.Resources.short_tip;
                    fingerShapeImage = Properties.Resources.short_finger;
                    break;

                case Noktinator.NailShape.Squoval:
                    nailShapeImage = Properties.Resources.squoval_tip;
                    fingerShapeImage = Properties.Resources.squoval_finger;
                    break;

                case Noktinator.NailShape.Stiletto:
                    nailShapeImage = Properties.Resources.stiletto_tip;
                    fingerShapeImage = Properties.Resources.stiletto_finger;
                    break;

                case Noktinator.NailShape.Wide:
                    nailShapeImage = Properties.Resources.wide_tip;
                    fingerShapeImage = Properties.Resources.wide_finger;
                    break;
            }
        }
    }
}
