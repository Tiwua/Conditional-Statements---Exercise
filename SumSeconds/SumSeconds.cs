﻿using System;

namespace _01.SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int time1 = int.Parse(Console.ReadLine());
            int time2 = int.Parse(Console.ReadLine());
            int time3 = int.Parse(Console.ReadLine());

            int totalTime = time1 + time2 + time3;

            int minutes = totalTime / 60;
            int seconds = totalTime % 60;

            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else if (seconds >= 10)
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }


        }
    }
}
