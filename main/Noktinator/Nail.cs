using System;
using System.Drawing;

namespace Noktinator
{
    public class Nail
    {
        public NailShapes nailShape = NailShapes.Almond;
        public NailPatterns nailPattern = NailPatterns.Leaf;
        public Color nailColor = Color.White;
        public Color patternColor = Color.Black;

        public Nail() { }

        public void setShape(NailShapes newShape)
        {
            this.nailShape = newShape;
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



    }
    public enum NailShapes
    {
        Almond,
        MountainPeak,
        Lipstick,
    }

    public enum NailPatterns
    {
        Fire,
        Leaf,
        Stars,
    }
}
