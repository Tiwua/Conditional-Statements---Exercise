using System;

namespace Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            const double priceForPuzzel = 2.60;
            const double priceForDoll = 3;
            const double priceForBear = 4.10;
            const double priceForMinion = 8.20;
            const double priceForTruck = 2;

            double priceForVacation = double.Parse(Console.ReadLine());
            double countOfPuzzles = double.Parse(Console.ReadLine());
            double countOfDolls = double.Parse(Console.ReadLine());
            double countOfBears = double.Parse(Console.ReadLine());
            double countOfMinions = double.Parse(Console.ReadLine());
            double countOfTrucks = double.Parse(Console.ReadLine());

            double countOfToys = countOfPuzzles + countOfDolls + countOfBears + countOfMinions + countOfTrucks;
            double priceOfAllToys = countOfPuzzles * priceForPuzzel + countOfDolls * priceForDoll + priceForBear * countOfBears + countOfMinions * priceForMinion + priceForTruck * countOfTrucks;

            double discount = 0;
            if (countOfToys >= 50)
            {
                discount = priceOfAllToys * 0.25;
            }
            double finalSum = priceOfAllToys - discount;
            double rent = finalSum * 0.10;
            double moneyMade = finalSum - rent;
            if (priceForVacation > moneyMade)
            {
                double neededMoney = priceForVacation - moneyMade;
                Console.WriteLine($"Not enough money! {neededMoney:f2} lv needed. ");
            }
            else 
            {
                double moneyLeft = moneyMade - priceForVacation;
                Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");
            }

        }
    }
}
