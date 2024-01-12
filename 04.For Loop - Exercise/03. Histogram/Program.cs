using System;

namespace _03._Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;
            int p1Counter = 0;
            int p2Counter = 0;
            int p3Counter = 0;
            int p4Counter = 0;
            int p5Counter = 0;
            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 200)
                {
                    p1Counter++;
                    p1 = 100.00 / n * p1Counter;
                }
                else if(number <= 399)
                {
                    p2Counter++;
                    p2 = 100.00 / n * p2Counter;
                }
                else if(number <= 599)
                {
                    p3Counter++;
                    p3 = 100.00 / n * p3Counter;
                }
                else if(number <= 799)
                {
                    p4Counter++;
                    p4 = 100.00 / n * p4Counter;
                }
                else
                {
                    p5Counter++;
                    p5 = 100.00 / n * p5Counter;
                }
            }
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
