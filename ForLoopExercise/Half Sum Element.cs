using System;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfRows = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;


            for (int n = 0; n < numOfRows; n++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;

                if (num > max)
                {
                    max = num;
                }
            }

            int sumWithoutMaxNumber = sum - max;
            if (max == sumWithoutMaxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = " + max);
            }
            else
            {
                int diff = Math.Abs(max - sumWithoutMaxNumber);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = " + diff);
            }

        }
    }
}