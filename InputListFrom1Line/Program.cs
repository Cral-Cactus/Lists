using System;
using System.Collections.Generic;
using System.Linq;

namespace InputListFrom1Line
{
    internal class Program
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < nums.Count; i++)
            {
                Console.WriteLine($"nums[{i}] = {nums[i]}");
            }
        }
    }
}