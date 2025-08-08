using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorsAndBalls
{
    public class MyColor
    {
        private int red;
        private int green;
        private int blue;
        private int alpha;

        public MyColor(int red, int green, int blue, int alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        public MyColor(int red, int green, int blue) : this(red, green, blue, 255) { }

        public int GetRed() => red;
        public void SetRed(int value) => red = value;

        public int GetGreen() => green;
        public void SetGreen(int value) => green = value;

        public int GetBlue() => blue;
        public void SetBlue(int value) => blue = value;

        public int GetAlpha() => alpha;
        public void SetAlpha(int value) => alpha = value;

        public int GetGrayscale()
        {
            return (red + green + blue) / 3;
        }
    }

}
