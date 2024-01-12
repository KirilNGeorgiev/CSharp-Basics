using System;

namespace _01._Pipes_In_Pool
{
        internal class Program
        {
            static void Main(string[] args)
            {
                int v = int.Parse(Console.ReadLine());
                int p1 = int.Parse(Console.ReadLine());
                int p2 = int.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());

                double firstPipe = h * p1;
                double secondPipe = h * p2;
                double total = firstPipe + secondPipe;

                if (total <= v)
                {
                    Console.WriteLine($"The pool is {total / v * 100:f2}% full. Pipe 1: {firstPipe * 100 / total:f2}%. Pipe 2: {secondPipe * 100 / total:f2}%.");
                }
                else
                {
                    Console.WriteLine($"For {h:f2} hours the pool overflows with {total - v:f2} liters.");
                }
            }
        }
}

    

