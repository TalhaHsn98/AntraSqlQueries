using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorsAndBalls
{
    public class Ball
    {
        private int size;
        private MyColor color;
        private int throwCount;

        public Ball(int size, MyColor color)
        {
            this.size = size;
            this.color = color;
            this.throwCount = 0;
        }

        public void Pop()
        {
            size = 0;
        }

        public void Throw()
        {
            if (size > 0)
                throwCount++;
        }

        public int GetThrowCount()
        {
            return throwCount;
        }
    }

}
