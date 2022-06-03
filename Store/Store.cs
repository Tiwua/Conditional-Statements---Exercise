using System;

namespace ConsoleApp2
{
    class Store
    {
        static void Main(string[] args)
        {
            const double LOVE_NOTE = 0.60;
            const double VOS_ROSE = 7.20;
            const double KEY_LOCKER = 3.60;
            const double KARIKATURE = 18.20;
            const double LUCKY_SURPRISE = 22;

            double priceForParty = double.Parse(Console.ReadLine());
            double loveNoteCount = double.Parse(Console.ReadLine());
            double vosRoseCount = double.Parse(Console.ReadLine());
            double keyLockerCount = double.Parse(Console.ReadLine());
            double karikatureCount = double.Parse(Console.ReadLine());
            double luckySurprisesCount = double.Parse(Console.ReadLine());

            double totalSum = loveNoteCount * LOVE_NOTE + vosRoseCount * VOS_ROSE + keyLockerCount * KEY_LOCKER + karikatureCount * KARIKATURE + luckySurprisesCount * LUCKY_SURPRISE;
            double totalItems = loveNoteCount + vosRoseCount + keyLockerCount + karikatureCount + luckySurprisesCount;
           
            if (totalItems >= 25)
            {
                totalSum = totalSum - totalSum * 0.35;
            }
            
            double hosting =  totalSum * 0.1;
            double finalSalary =  totalSum - hosting;
           
            

            if (finalSalary >= priceForParty)
            {
                double moneyLeft = finalSalary - priceForParty;
                Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");
            }
            else
            {
                double moneyNeeded = priceForParty - finalSalary;
                Console.WriteLine($"Not enough money! {moneyNeeded:f2} lv needed.");
            }

        }
    }
}
