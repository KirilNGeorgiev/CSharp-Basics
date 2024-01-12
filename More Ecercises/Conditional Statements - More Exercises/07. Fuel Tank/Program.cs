using System;

namespace _07._Fuel_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine().ToLower();
            double litres = double.Parse(Console.ReadLine());

            if(fuel == "diesel")
            {
                if(litres >= 25)
                {
                    Console.WriteLine($"You have enough {fuel}");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with {fuel}!");
                }
            }
            else if(fuel == "gasoline")
            {
                if(litres >= 25)
                {
                    Console.WriteLine($"You have enough {fuel}.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with {fuel}!");
                }
            }
            else if(fuel == "gas")
            {
                if(litres >= 25)
                {
                    Console.WriteLine($"You have enough {fuel}.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with {fuel}!");
                }
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}
