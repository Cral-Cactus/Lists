using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace SumOfFlippedNumbers
{
    internal class Program
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            nums.Reverse();

            int sum = 0;

            for (int i = 0; i < nums.Count; i++)
            {
                int currentNum = nums[i];
                int reversedNum = 0;

                while (currentNum > 0)
                {
                    reversedNum = reversedNum * 10 + currentNum % 10;
                    currentNum /= 10;
                }

                sum += reversedNum;
            }

            Console.WriteLine(sum);
        }
    }
}