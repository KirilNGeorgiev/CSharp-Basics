using System;

namespace _04._Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lilysAge = int.Parse(Console.ReadLine());
            double washingMachine = double.Parse(Console.ReadLine());
            int singleToyPrice = int.Parse(Console.ReadLine());

            int sum = 0;
            int toys = 0;
            for (int i = 1; i <= lilysAge; i++)
            {
                if(i % 2 == 0)
                {
                    sum += i * 5 - 1;
                }
                else
                {
                    toys++;
                }
            }
            sum += toys * singleToyPrice;
            if(sum >= washingMachine)
            {
                Console.WriteLine($"Yes! {sum - washingMachine :f2}");
            }
            else
            {
                Console.WriteLine($"No! {washingMachine - sum :f2}");
            }
        }
    }
}
