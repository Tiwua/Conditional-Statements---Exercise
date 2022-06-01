using System;

namespace Demo
{
    class Histogram
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int countOfGroups1 = 0;
            int countOfGroups2 = 0;
            int countOfGroups3 = 0;
            int countOfGroups4 = 0;
            int countOfGroups5 = 0;

            for (int number = 1; number <= n; number++)
            {
                int value = int.Parse(Console.ReadLine());
                if (value < 200)

                {
                    countOfGroups1++;
                }
                else if (value >= 200 && value <= 399)
                {
                    countOfGroups2++;
                }
                else if (value >= 400 && value <= 599)
                {
                    countOfGroups3++;
                }
                else if (value >= 600 && value <= 799)
                {
                    countOfGroups4++;
                }
                else if (value >= 800)
                {
                    countOfGroups5++;
                }

            }
            double percentGroup1 = countOfGroups1 * 1.0 / n * 100;
            double percentGroup2 = countOfGroups2 * 1.0 / n * 100;
            double percentGroup3 = countOfGroups3 * 1.0 / n * 100;
            double percentGroup4 = countOfGroups4 * 1.0 / n * 100;
            double percentGroup5 = countOfGroups5 * 1.0 / n * 100;

            Console.WriteLine($"{percentGroup1:f2}%");
            Console.WriteLine($"{percentGroup2:f2}%");
            Console.WriteLine($"{percentGroup3:f2}%");
            Console.WriteLine($"{percentGroup4:f2}%");
            Console.WriteLine($"{percentGroup5:f2}%");
        }
    }
}


