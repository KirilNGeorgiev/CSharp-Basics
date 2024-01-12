using System;

namespace _02._Summer_Outfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            string outfit = string.Empty;
            string shoes = string.Empty;

            if(degrees <= 18)
            {
                if(text == "Morning")
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if(text == "Afternoon")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if(text == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if(degrees <= 24)
            {
                if(text == "Morning")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (text == "Afternoon")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (text == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else
            {
                if(text == "Morning")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (text == "Afternoon")
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
                else if (text == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
        }
    }
}
