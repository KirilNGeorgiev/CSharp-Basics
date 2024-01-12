using System;

namespace _09._Yard_Greening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double squareMetres = double.Parse(Console.ReadLine());

            double price = squareMetres * 7.61;
            double discount = price * 0.18;
            double sum = price - discount;

            Console.WriteLine($"The final price is: {sum} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
