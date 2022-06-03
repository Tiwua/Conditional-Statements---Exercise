using System;

namespace ConsoleApp4
{
    class RunningDistance
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double M = double.Parse(Console.ReadLine());

            double kmPerDay = M;

            for (int day = 2; day <= N; day++)
            {
                double percentInreace = double.Parse(Console.ReadLine());
               
                 kmPerDay =  kmPerDay + kmPerDay *  (percentInreace / 100);
                 
            }
            if (kmPerDay >= 1000)
            {

             Console.WriteLine($"You've done a great job running {kmPerDay} more   kilometers!");
            }
            else
            {
                double neededKm = 1000 - kmPerDay;
                Console.WriteLine($"Sorry Mrs.Ivanova, you need to run {neededKm} more kilometers");
                
            }
        }
    }
}
