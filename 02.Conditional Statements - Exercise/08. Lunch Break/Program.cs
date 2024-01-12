using System;

namespace _08._Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string seriesName = Console.ReadLine();
            int episodeTime = int.Parse(Console.ReadLine());
            int rest = int.Parse(Console.ReadLine());

            double lunchTime = rest / 8.0;
            double relaxation = rest / 4.0;
            double leftTime = rest - (lunchTime + relaxation);

            if(leftTime >= episodeTime)
            {
                Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(leftTime - episodeTime)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(episodeTime - leftTime)} more minutes.");
            }
        }
    }
}
