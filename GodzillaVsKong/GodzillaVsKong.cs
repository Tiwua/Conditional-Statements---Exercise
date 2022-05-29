using System;

namespace _06.GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int countStatists = int.Parse(Console.ReadLine());
            double pricePerStatist = double.Parse(Console.ReadLine());

            double decorPrice = 0.10 * budget;
            double clothesPrice = countStatists * pricePerStatist;

            if (countStatists > 150)
            {
                clothesPrice = clothesPrice * 0.9;
            }

            double expenses = decorPrice + clothesPrice;

            if (budget >= expenses)
            {
                Console.WriteLine("Action!");
                double leftMoney = budget - expenses;
                Console.WriteLine($"Wingard starts filming with {leftMoney:F2} leva left.");
            }
            else if (expenses > budget)
            {
                Console.WriteLine("Not enough money!");
                double needMoney = expenses - budget;
                Console.WriteLine($"Wingard needs {needMoney:F2} leva more.");
            }
        }
    }
}
