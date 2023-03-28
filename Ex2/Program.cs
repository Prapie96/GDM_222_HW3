using System;

class Program
{
    static void Main()
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        double r1 = double.Parse(Console.ReadLine());
        double r2 = double.Parse(Console.ReadLine());

        double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); 

       if(d > r1+r2){
            System.Environment.Exit(0);
       }
        else if (d == r1 + r2)
        {
            double x = (r1 * x2 + r2 * x1) / (r1 + r2);
            double y = (r1 * y2 + r2 * y1) / (r1 + r2);
            Console.WriteLine("{0:F2}", x);
            Console.WriteLine("{0:F2}", y);
        }
        else
        {
            double keep1 = (r1 * r1 - r2 * r2 + d * d) / (2 * d); 
            double keep2 = Math.Sqrt(r1 * r1 - keep1 * keep1); 

            double x3 = x1 + keep1 * (x2 - x1) / d; 
            double y3 = y1 + keep1 * (y2 - y1) / d; 

            double x4_f = x3 - keep2 * (y2 - y1) / d; 
            double y4_f = y3 + keep2 * (x2 - x1) / d; 

            double x4_a = x3 + keep2 * (y2 - y1) / d; 
            double y4_a = y3 - keep2 * (x2 - x1) / d; 
            
            Console.WriteLine("*******************");
            Console.WriteLine("{0:F2}", x4_f);
            Console.WriteLine("{0:F2}", y4_f);
            Console.WriteLine("{0:F2}", x4_a);
            Console.WriteLine("{0:F2}", y4_a);
        }
    }
}
