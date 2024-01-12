using System;

namespace _05._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int extraPerson = int.Parse(Console.ReadLine());
            double dressPrice = double.Parse(Console.ReadLine());

            double decor = budget * 0.1;
            double sumDress = extraPerson * dressPrice;

            if(extraPerson > 150)
            {
                sumDress -= sumDress * 0.1;
            }
            double sum = decor + sumDress;

            if(sum > budget)
            {
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(budget - sum):f2} leva more.");
            }
            else
            {
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {Math.Abs(budget - sum):f2} leva left.");
            }
        }
    }
}
