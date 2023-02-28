using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxSequenceOfNumbers
{
    internal class Program
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            
            int maxCount = 0;
            int maxNum = 0;
            int count = 1;
            
            for (int i = 0; i < nums.Count - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    maxNum = nums[i];
                }
            }
            
            for (int i = 0; i < maxCount; i++)
            {
                Console.Write(maxNum + " ");
            }
        }
    }
}