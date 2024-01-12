using System;

namespace _02._Sleepy_Tom_Cat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Обща норма на Том за игра 30 000 минути

            int number = int.Parse(Console.ReadLine()); //броят почивни дни 

            int workDays = 365 - number;
            int play = (workDays * 63) + (number * 127);
            int playLimit = 30000 - play;

            if (play > 30000) // ако времето е над нормата
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{Math.Abs(playLimit / 60)} hours and {Math.Abs(playLimit % 60)} minutes more for play");
            }
            else // ако времето е под нормата
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{playLimit / 60} hours and {playLimit % 60} minutes less for play");
            }
        }
    }
}
