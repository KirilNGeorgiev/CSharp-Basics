using System;

namespace _06._Concatenate_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string surName = Console.ReadLine();
            string age = Console.ReadLine();
            string town = Console.ReadLine();

            Console.WriteLine($"You are {name} {surName}, a {age}-years old person from {town}.");
        }
    }
}
