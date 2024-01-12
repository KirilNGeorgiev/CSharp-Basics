using System;

namespace _07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsQuantity = int.Parse(Console.ReadLine());

            double studio = 0;
            double apartment = 0;

            if(month == "May" || month == "October")
            {
                studio = nightsQuantity * 50;
                apartment = nightsQuantity * 65;
                if(nightsQuantity > 7 && nightsQuantity < 14)
                {
                    studio -= studio * 0.05;
                }
                else if(nightsQuantity > 14)
                {
                    studio -= studio * 0.3;
                }
                if(nightsQuantity > 14)
                {
                    apartment -= apartment * 0.1;
                }
            }
            else if(month == "June" || month == "September")
            {
                studio = nightsQuantity * 75.20;
                apartment = nightsQuantity * 68.70;
                if(nightsQuantity > 14)
                {
                    studio -= studio * 0.2;
                }
                if(nightsQuantity > 14)
                {
                    apartment -= apartment * 0.1;
                }
            }
            else if(month == "July" || month == "August")
            {
                studio = nightsQuantity * 76;
                apartment = nightsQuantity * 77;
                if(nightsQuantity > 14)
                {
                    apartment -= apartment * 0.1;
                }
            }
            Console.WriteLine($"Apartment: {apartment :f2} lv.");
            Console.WriteLine($"Studio: {studio :f2} lv.");
        }
    }
}
