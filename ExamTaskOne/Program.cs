using System;

namespace ExamTaskOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = int.Parse(Console.ReadLine());
            double mousePrice = int.Parse(Console.ReadLine());
            double keyboardPrice = int.Parse(Console.ReadLine());
            double displayPrice = int.Parse(Console.ReadLine());


            double headsetCost = (lostGames / 2) * headsetPrice;
            double miceCost = (lostGames / 3) * mousePrice;
            double keyboardCost = (lostGames / 6) * keyboardPrice;
            double displayCost = (lostGames / 12) * displayPrice;
            double expenses = headsetCost + miceCost + keyboardCost + displayCost;

            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}
