using System;

namespace CircleEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2, x3, y3;
            Console.WriteLine("Enter coordinates of three points on the circle:");
            Console.Write("Input x1: ");
            x1 = double.Parse(Console.ReadLine());
            Console.Write("Input y1: ");
            y1 = double.Parse(Console.ReadLine());
            Console.Write("Input x2: ");
            x2 = double.Parse(Console.ReadLine());
            Console.Write("Input y2: ");
            y2 = double.Parse(Console.ReadLine());
            Console.Write("Input x3: ");
            x3 = double.Parse(Console.ReadLine());
            Console.Write("Input y3: ");
            y3 = double.Parse(Console.ReadLine());

            double a,b,c,d,e,f;
             a = 2 * (x2 - x1);
             b = 2 * (y2 - y1);
             c = x2 * x2 + y2 * y2 - x1 * x1 - y1 * y1;
             d = 2 * (x3 - x2);
             e = 2 * (y3 - y2);
             f = x3 * x3 + y3 * y3 - x2 * x2 - y2 * y2;

            double h, k, r;
            h = (b * f - e * c) / (b * d - e * a);
            k = (d * c - a * f) / (b * d - e * a);
            r = Math.Sqrt((x1 - h) * (x1 - h) + (y1 - k) * (y1 - k));

            Console.WriteLine("Center of the circle 1: {0:F5}",h);
            Console.WriteLine("Center of the circle 2: {0:F5}",k);
            Console.WriteLine("Radius of the circle: {0:F5}",r);
        }
    }
}
