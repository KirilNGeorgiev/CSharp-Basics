﻿using System;

namespace _08._Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogFood = int.Parse(Console.ReadLine());
            int catFood = int.Parse(Console.ReadLine());

            double dogFoodPrice = dogFood * 2.50;
            double catFoodPrice = catFood * 4;

            double sum = dogFoodPrice + catFoodPrice;

            Console.WriteLine($"{sum} lv.");
        }
    }
}
