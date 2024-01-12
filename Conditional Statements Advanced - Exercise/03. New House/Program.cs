using System;

namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeFlower = Console.ReadLine();
            int flowerCount = int.Parse(Console.ReadLine());
            int budget =int.Parse(Console.ReadLine());

            double sum = 0;

            if(typeFlower == "Roses")
            {
                sum = flowerCount * 5.00;
                if(flowerCount > 80)
                {
                    sum -= sum * 0.1;
                }
            }
            else if(typeFlower == "Dahlias")
            {
                sum = flowerCount * 3.80;
                if(flowerCount > 90)
                {
                    sum -= sum * 0.15;
                }
            }
            else if(typeFlower == "Tulips")
            {
                sum = flowerCount * 2.80;
                if(flowerCount > 80)
                {
                    sum -= sum * 0.15;
                }
            }
            else if(typeFlower == "Narcissus")
            {
                sum = flowerCount * 3.00;
                if(flowerCount < 120)
                {
                    sum += sum * 0.15;
                }
            }
            else if(typeFlower == "Gladiolus")
            {
                sum = flowerCount * 2.50;
                if(flowerCount < 80)
                {
                    sum += sum * 0.2;
                }
            }
            if(sum <= budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowerCount} {typeFlower} and {budget - sum :f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {sum - budget :f2} leva more.");
            }
        }
    }
}
