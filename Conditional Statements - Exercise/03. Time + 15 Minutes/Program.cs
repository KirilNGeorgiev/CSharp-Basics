using System;

namespace _03._Time___15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            
            int total = (hour * 60) + minutes + 15;
            int sumHour = total / 60;
            
            if(sumHour >= 24)
            {
                sumHour -= 24;
            }
            int sumMin = total % 60;
            
            if(sumMin < 10)
            {
                Console.WriteLine($"{sumHour}:0{sumMin}");
            }
            else
            {
                Console.WriteLine($"{sumHour}:{sumMin}");
            }
            
        }
    }
}
