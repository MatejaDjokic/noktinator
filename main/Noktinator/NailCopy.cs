using System;
using System.Drawing;

namespace Noktinator
{
    class NailCopy
    {
        public NailShapes nailShape = NailShapes.Almond;
        public NailPatterns nailPattern = NailPatterns.Leaf;
        public Color nailColor = Color.White;
        public Color patternColor = Color.Black;

        public NailCopy() { }

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

    enum NailShapes
    {
        Almond,
        MountainPeak,
        Lipstick,
    }

    enum NailPatterns
    {
        Fire,
        Leaf,
        Stars,
    }
}
