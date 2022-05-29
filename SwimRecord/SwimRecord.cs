using System;

namespace SwimRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                double record = double.Parse(Console.ReadLine());
                double meters = double.Parse(Console.ReadLine());
                double timePerMeter = double.Parse(Console.ReadLine());

                double swimTime = meters * timePerMeter;
                double delay = Math.Floor(meters / 15) * 12.5;

                double totalTime = swimTime + delay;

                if (totalTime < record)
                {
                    Console.WriteLine($" Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
                }

                else 
                {
                    double secondsNeeded = totalTime - record;
                    Console.WriteLine($"No, he failed! He was {secondsNeeded:F2} seconds slower.");
                }
            }  
        }
    }
}
