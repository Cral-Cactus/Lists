using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfEvenNumbers
{
    internal class Program
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] % 2 != 0)
                {
                    nums.RemoveAt(i);
                    i--;
                }
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}