using System;

namespace _05._Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double dogFoodPerDay = double.Parse(Console.ReadLine());
            double catFoodPerDay = double.Parse(Console.ReadLine());
            double turtleFoodPerDay = double.Parse(Console.ReadLine()) / 1000;

            double totalFood = (days * dogFoodPerDay) + (days * catFoodPerDay) + (days * turtleFoodPerDay);

            if(totalFood <= food)
            {
                Console.WriteLine($"{Math.Floor(food - totalFood)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(totalFood - food)} more kilos of food are needed.");
            }
        }
    }
}
