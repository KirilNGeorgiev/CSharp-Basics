using System;

namespace _03._Harvest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine()); 
            double y = double.Parse(Console.ReadLine()); 
            int z = int.Parse(Console.ReadLine()); 
            int workers = int.Parse(Console.ReadLine());

            double grapes = x * y;
            double wine = (grapes * 0.4) / 2.5;
            double wineLeft = wine - z;

            if(wine < z)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(z - wine)} liters wine needed.");
            }
            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{Math.Ceiling(wineLeft)} liters left -> {Math.Ceiling(wineLeft / workers)} liters per person.");
            }
        }
    }
}
