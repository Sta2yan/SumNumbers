using System;
using System.Collections.Generic;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int maximumNumber = 101;
            int number = random.Next(0, maximumNumber);
            int sumNumbers = 0;
            int multipleThree = 3;
            int multipleFive = 5;

            for (int i = 0; i <= number; i++)
            {
                if (i % multipleThree == 0)
                {
                    sumNumbers += i;
                }
                else if (i % multipleFive == 0)
                {
                    sumNumbers += i;
                }
            }

            Console.WriteLine($"Сумма найденных чисел: {sumNumbers}");
        }
    }
}