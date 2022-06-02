using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int dancerCount = int.Parse(Console.ReadLine());
            double pointsCount = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = Console.ReadLine();

            double moneyEarned = dancerCount * pointsCount;

            if (place == "Abroad")
            {
                    double percentBonus = 0.5 * moneyEarned;
                    moneyEarned = dancerCount * pointsCount + percentBonus;

            }
            else if (place == "Bulgaria")
            {
                moneyEarned = dancerCount * pointsCount;
            }
            {

            }
            if (season == "summer" && place == "Bulgaria")
            {
                moneyEarned = moneyEarned - moneyEarned * 0.05;
            }
            if (season == "summer" && place == "Abroad")
            {
                moneyEarned = moneyEarned - moneyEarned * 0.1;
            }
            if (season == "winter" && place == "Bulgaria")
            {
                moneyEarned = moneyEarned - moneyEarned * 0.08;
            }
            if (season == "winter" && place == "Abroad")
            {
                moneyEarned = moneyEarned - moneyEarned * 0.15;
            }


            double moneyForCharity = moneyEarned * 0.75;
            double moneyPerDancer = (moneyEarned - moneyForCharity) / dancerCount;

            Console.WriteLine($"Charity - {moneyForCharity:f2}");
            Console.WriteLine($"Money per dancer - {moneyPerDancer:f2}");
            }
        
    }
}
