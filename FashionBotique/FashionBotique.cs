using System;

namespace FashionBotique
{
    class Program
    {
        static void Main(string[] args)
        {
            int pricePerDay = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();


            const int mens = 15;
            const int ladies = 20;
            const int kids = 10;

            const int touchUp = 20;
            const int fullColor = 30;

            int moneyEarned = 0;

            while (input != "closed")
            {
                if (moneyEarned >= pricePerDay)
                {
                    break;
                }
                input = Console.ReadLine();
                if (input == "mens")
                {
                    moneyEarned += mens;
                    
                }
                if (input == "ladies")
                {
                    moneyEarned += ladies;

                }
                 if (input == "kids")
                {
                    moneyEarned += kids;

                }
                if (input == "touch up")
                {
                    moneyEarned += touchUp;

                }
                if (input == "full color")
                {
                    moneyEarned += fullColor;

                }
            }
            if (pricePerDay > moneyEarned)
            {
            int moneyNeeded = pricePerDay - moneyEarned;
            Console.WriteLine($"Target not reached! You need {moneyNeeded}lv. more.");
            Console.WriteLine($"Earned money: {moneyEarned}lv.");

            }
            else
            {
                Console.WriteLine("You have reached your target for the day!") ;
                Console.WriteLine($"Earned money: {moneyEarned}lv.");
            }

        }
    }
}
