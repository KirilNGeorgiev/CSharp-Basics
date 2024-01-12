using System;

namespace _06._Flower_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int magnolias = int.Parse(Console.ReadLine());
            int hyacinths =int.Parse(Console.ReadLine());
            int roses =int.Parse(Console.ReadLine());
            int cactuses =int.Parse(Console.ReadLine());
            double presentPrice = double.Parse(Console.ReadLine());

            double sum = (magnolias * 3.25) + (hyacinths * 4) + (roses * 3.50) + (cactuses * 8);
            double sumAfterTax = sum -(sum * 0.05); 

            if(sumAfterTax >= presentPrice)
            {
                Console.WriteLine($"She is left with {Math.Floor(sumAfterTax - presentPrice)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(presentPrice - sumAfterTax)} leva.");
            }
        }
    }
}
