using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfNamesV2
{
    internal class Program
    {
        static void Main()
        {
            List<string> names = Console.ReadLine().Split(',').ToList();

            //names.Reverse();

            foreach (string name in names)
            {
                string[] parts = name.Trim().Split(' ');
                Console.WriteLine($"{parts[1]} {parts[0]}");
            }
        }
    }
}