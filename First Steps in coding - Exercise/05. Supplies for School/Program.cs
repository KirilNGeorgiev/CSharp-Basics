using System;

namespace _05._Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int cleaner = int.Parse(Console.ReadLine());
            int rate = int.Parse(Console.ReadLine());

            double pensPrice = pens * 5.80;
            double markersPrice = markers * 7.20;
            double cleanerPrice = cleaner * 1.20;

            double sum = pensPrice + markersPrice + cleanerPrice;
            double price = sum - sum * (rate / 100.0);
            
            Console.WriteLine(price);
        }
    }
}
