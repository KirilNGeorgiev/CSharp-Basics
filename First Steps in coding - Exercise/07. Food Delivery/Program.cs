using System;

namespace _07._Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chicken = int.Parse(Console.ReadLine());
            int fish = int.Parse(Console.ReadLine());
            int veganMenu = int.Parse(Console.ReadLine());

            double chickenPrice = chicken * 10.35;
            double fishPrice = fish * 12.40;
            double veganMenuPrice = veganMenu * 8.15;

            double sum = chickenPrice + fishPrice + veganMenuPrice;
            double desert = sum * 0.2;

            Console.WriteLine(sum + desert + 2.50);

        }
    }
}
