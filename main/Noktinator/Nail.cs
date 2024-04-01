using System;
using System.Drawing;

namespace Noktinator
{
    public class Nail
    {
        public NailShapes nailShape;
        public NailPatterns nailPattern;
        public Color nailColor = Color.White;
        public Color patternColor = Color.Black;
        public Color skinColor = Color.White;


        public Image NailShape;
        public Image FingerShape;


        public Nail() 
        {
            ChangeShape();
        }

        public void setPattern(NailPatterns newPattern)
        {
            this.nailPattern = newPattern;
        }

        public void setNailColor(Color newNailColor)
        {
            this.nailColor = newNailColor;
        }

        public void setPatternColor(Color newPatternColor)
        {
            this.patternColor = newPatternColor;
        }

        public Bitmap getImage()
        {
            throw new Exception("Not yet implemented!");
        }

        public void ChangeShape()
        {
            switch (nailShape)
            {
                case NailShapes.Almond:
                    NailShape = Properties.Resources.almond_tip;
                    FingerShape = Properties.Resources.almond_finger;
                    break;

                case NailShapes.Ballerina:
                    NailShape = Properties.Resources.ballerina_tip;
                    FingerShape = Properties.Resources.ballerina_finger;
                    break;

                case NailShapes.Lipstick:
                    NailShape = Properties.Resources.lipstick_tip;
                    FingerShape = Properties.Resources.lipstick_finger;
                    break;

                case NailShapes.MountainPeak:
                    NailShape = Properties.Resources.mountain_peak_tip;
                    FingerShape = Properties.Resources.mountain_peak_finger;
                    break;

                case NailShapes.Oval:
                    NailShape = Properties.Resources.oval_tip;
                    FingerShape = Properties.Resources.oval_finger;
                    break;

                case NailShapes.Rounded:
                    NailShape = Properties.Resources.rounded_tip;
                    FingerShape = Properties.Resources.rounded_finger;
                    break;

                case NailShapes.Short:
                    NailShape = Properties.Resources.short_tip;
                    FingerShape = Properties.Resources.short_finger;
                    break;

                case NailShapes.Squoval:
                    NailShape = Properties.Resources.squoval_tip;
                    FingerShape = Properties.Resources.squoval_finger;
                    break;

                case NailShapes.Stiletto:
                    NailShape = Properties.Resources.stiletto_tip;
                    FingerShape = Properties.Resources.stiletto_finger;
                    break;

                case NailShapes.Wide:
                    NailShape = Properties.Resources.wide_tip;
                    FingerShape = Properties.Resources.wide_finger;
                    break;
            }
        }
    }



    public enum NailShapes
    {
        Almond,
        Ballerina,
        Lipstick,
        MountainPeak,
        Oval,
        Rounded,
        Short,
        Squoval,
        Stiletto,
        Wide
    }

    public enum NailPatterns
    {
        FireStyle,
        LeafStyle,
        StarsStyle,
        HeartsStyle,
        LeavesStyle
    }
}
