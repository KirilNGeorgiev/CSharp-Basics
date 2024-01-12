using System;

namespace _07._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videoCards = int.Parse(Console.ReadLine());
            int processors = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            int videocardsPrice = videoCards * 250;
            double processorsPrice =processors * (videocardsPrice * 0.35);
            double ramPrice = ram * (videocardsPrice * 0.1);
            double sum = videocardsPrice + processorsPrice + ramPrice;

            if(videoCards > processors)
            {
                sum -= sum * 0.15;
            }
            if(budget >= sum)
            {
                Console.WriteLine($"You have {Math.Abs(budget - sum):f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(budget - sum):f2} leva more!");
            }
        }
    }
}
