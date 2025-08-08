using System;

namespace ColorsAndBalls
{
    public class Program
    {
        public static void Main()
        {
            var red = new MyColor(255, 0, 0);
            var blue = new MyColor(0, 0, 255);

            var ball1 = new Ball(10, red);
            var ball2 = new Ball(12, blue);

            ball1.Throw();
            ball1.Throw();
            ball2.Throw();

            ball1.Pop();
            ball1.Throw();

            Console.WriteLine($"Ball 1 thrown {ball1.GetThrowCount()} times.");
            Console.WriteLine($"Ball 2 thrown {ball2.GetThrowCount()} times.");
        }
    }
}
