using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfExtremes
{
    internal class Program
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int min = nums[0];
            int max = nums[0];

            for (int i = 1; i < nums.Count; i++)
            {
                if (nums[i] < min)
                {
                    min = nums[i];
                }

                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }

            List<int> result = new List<int>();

            foreach (int num in nums)
            {
                if (num == min || num == max)
                {
                    result.Add(num);
                }
            }
            
            result.Sort();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}