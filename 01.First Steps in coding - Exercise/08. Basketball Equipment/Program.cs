using System;

namespace _08._Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int payment = int.Parse(Console.ReadLine());

            double shoes = payment -( payment * 0.4);
            double outfit =shoes -( shoes * 0.2);
            double ball = outfit / 4;
            double accessory = ball / 5;

            double sum = payment + shoes + outfit + ball + accessory;

            Console.WriteLine(sum);
        }
    }
}
