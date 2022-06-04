using System;

namespace Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int countOfWins = 0;
            int countOfLoses = 0;
            int countOfDayDayWins = 0;
            int countOfDayLosses = 0;
            double countOfMoneyEarned = 0;
            double finalMoney = 0;

            for (int day = 0; day < days; day++)
            {
                string input = Console.ReadLine();
                while (input != "Finish")
                {
                    string argss = Console.ReadLine();
                    if (argss == "win")
                    {
                        countOfWins++;
                        countOfMoneyEarned += 20;
                    }
                    else
                    {
                        countOfLoses++;
                    }
                    input = Console.ReadLine();
                }
                if (countOfWins > countOfLoses)
                {
                    countOfMoneyEarned += 0.1 * countOfMoneyEarned;
                    countOfDayDayWins++;
                }
                else
                {
                    countOfDayLosses++;
                }
                finalMoney += countOfMoneyEarned;
                countOfMoneyEarned = 0;
                countOfWins = 0;
                countOfLoses = 0;
            }
            if (countOfDayDayWins > countOfDayLosses)
            {
                finalMoney += 0.2 * finalMoney;
                Console.WriteLine($"You won the tournament! Total raised money: {finalMoney}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {finalMoney}");
            }
        }
    }
}
