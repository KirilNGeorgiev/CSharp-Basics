using System;

namespace _04._Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            double trip = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            //act
            int toys = puzzles + dolls + bears + minions + trucks;
            double price = (puzzles * 2.60) + (dolls * 3) + (bears * 4.10) + (minions * 8.20) + (trucks * 2);

            if(toys >= 50)
            {
                price -= price * 0.25;
            }
            double totalSum = price -( price * 0.1);

            //output
            if(trip <= totalSum)
            {
                Console.WriteLine($"Yes! {Math.Abs(trip - totalSum):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {Math.Abs(trip - totalSum):f2} lv needed.");
            }
        }
    }
}
