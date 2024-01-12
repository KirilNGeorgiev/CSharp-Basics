using System;

namespace _05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine(); 

            string destination = string.Empty;
            string vacancy = string.Empty;

            if(budget <= 100)
            {
                destination = "Bulgaria";
                if(season == "summer")
                {
                    vacancy = "Camp";
                    budget = budget * 0.3;
                }
                else if(season == "winter")
                {
                    vacancy = "Hotel";
                    budget = budget * 0.7;
                }
            }
            else if(budget <= 1000)
            {
                destination = "Balkans";
                if(season == "summer")
                {
                    vacancy = "Camp";
                    budget = budget * 0.4;
                }
                else if(season == "winter")
                {
                    vacancy = "Hotel";
                    budget = budget * 0.8;
                }
            }
            else
            {
                destination = "Europe";
                vacancy = "Hotel";
                budget = budget * 0.9;
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{vacancy} - {budget :f2}");
        }
    }
}
