using System;

namespace _08._Fuel_Tank___Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double quantityFuel = double.Parse(Console.ReadLine());
            string card = Console.ReadLine();

            double fuelPerLitre = 0;

            if(fuelType == "Gasoline")
            {
                fuelPerLitre = 2.22;
                if(card == "Yes")
                {
                    fuelPerLitre -= 0.18;
                }
            }
            else if(fuelType == "Diesel")
            {
                fuelPerLitre = 2.33;
                if( card == "Yes")
                {
                    fuelPerLitre -= 0.12;
                }
            }
            else if(fuelType == "Gas")
            {
                fuelPerLitre = 0.93;
                if(card == "Yes")
                {
                    fuelPerLitre -= 0.08;
                }
            }
            double totalFuel = quantityFuel * fuelPerLitre;

            if(quantityFuel >= 20 && quantityFuel <= 25)
            {
                totalFuel -= totalFuel * 0.08;
            }
            else if(quantityFuel >= 26)
            {
                totalFuel -= totalFuel * 0.1;
            }
            Console.WriteLine($"{totalFuel :f2} lv.");
        }
    }
}
