using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Color
    {
        private UInt16 red;
        private UInt16 green;
        private UInt16 blue;
        private UInt16 alpha = 255;
        public Color(UInt16 red, UInt16 green, UInt16 blue, UInt16 alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }
        public Color(UInt16 red, UInt16 green, UInt16 blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            
        }
        public UInt16 GetRed()
        {
            return red;
        }
        public void SetRed(UInt16 value)
        {
            this.red = value;
        }

        public UInt16 GetGreen()
        {
            return green;
        }
        public void SetGreen(UInt16 value)
        {
            this.green = value;
        }

        public UInt16 GetBlue()
        {
            return blue;
        }
        public void SetBlue(UInt16 value)
        {
            this.blue = value;
        }
        public UInt16 GetAlpha()
        {
            return alpha;
        }
        public void SetAlpha(UInt16 value)
        {
            this.alpha = value;
        }
    }
}
