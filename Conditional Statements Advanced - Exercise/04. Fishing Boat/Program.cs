using System;

namespace _04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fisherMen = int.Parse(Console.ReadLine());

            double price = 0;

            if(season == "Spring")
            {
                price = 3000;
            }
            else if(season == "Summer" || season == "Autumn")
            {
                price = 4200;
            }
            else if(season == "Winter")
            {
                price = 2600;
            }
            if(fisherMen <= 6)
            {
                price -= price * 0.1;
            }
            else if(fisherMen <= 11)
            {
                price -= price * 0.15;
            }
            else
            {
                price -= price * 0.25;
            }
            if(fisherMen % 2 == 0 && season != "Autumn")
            {
                price -= price * 0.05;
            }
            if(price <= budget)
            {
                Console.WriteLine($"Yes! You have {budget - price :f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {price - budget :f2} leva.");
            }
        }
    }
}
