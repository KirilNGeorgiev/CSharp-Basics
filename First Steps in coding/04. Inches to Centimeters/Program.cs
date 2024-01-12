using System;

namespace _04._Inches_to_Centimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            number = number * 2.54;

            Console.WriteLine(number);
        }
    }
}
