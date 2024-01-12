using System;

namespace _04._Transport_Price
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string word = Console.ReadLine();

            double taxiPrice = 0;
            if(word == "day")
            {
                taxiPrice = n * 0.79;
            }
            else if(word == "night")
            {
                taxiPrice = n * 0.90;
            }
            if(n < 20)
            {
                 taxiPrice += 0.70;
                Console.WriteLine($"{taxiPrice:f2}");
            }
            else if(n < 100)
            {
                double busPrice = n * 0.09;
                Console.WriteLine($"{busPrice:f2}");
            }
            else
            {
                double trainPrice = n * 0.06;
                Console.WriteLine($"{trainPrice:f2}");
            }
        }
    }
}
