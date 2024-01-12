using System;

namespace _01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colons = int.Parse(Console.ReadLine());

            double price = 0;

            if(projection == "Premiere")
            {
                price = 12.00;
            }
            else if(projection == "Normal")
            {
                price = 7.50;
            }
            else if(projection == "Discount")
            {
                price = 5.00;
            }
            double sum = price * (rows * colons);
            Console.WriteLine($"{sum:f2} leva");
        }
    }
}
