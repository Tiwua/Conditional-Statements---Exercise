using System;

namespace ConsoleApp3
{
    class TeamGame
    {
        static void Main(string[] args)
        {
            string teamName = Console.ReadLine();
            int matchPlayed = int.Parse(Console.ReadLine());

            int totalPoints = 0;
            int winsCounts = 0;
            int drawCounts = 0;
            int lostCounts = 0;

            for (int i = 0; i < matchPlayed; i++)
            {
                string result = Console.ReadLine();
                if (result == "W")
                {
                    totalPoints += 3;
                    winsCounts++;
                }
                else if (result == "D")
                {
                    totalPoints++;
                    drawCounts++;
                }
                else if (result == "L")
                {
                    lostCounts++;
                }
            }
            if (matchPlayed == 0)
            {
                Console.WriteLine($"{teamName} hasn't played any games during this season");
            }
            else
            {
                double winRate = winsCounts * 1.0 / matchPlayed * 100;
                Console.WriteLine($"{teamName} has won {totalPoints} points during this season");
                Console.WriteLine("Total stats:");
                Console.WriteLine($"## W:{winsCounts}");
                Console.WriteLine($"## D:{drawCounts}");
                Console.WriteLine($"## L:{lostCounts}");
                Console.WriteLine($"Win rate:{winRate:f2}%");
            }

        }
    }
}
