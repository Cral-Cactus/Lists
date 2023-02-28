using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfNames
{
    internal class Program
    {
        static void Main()
        {
            List<string> names = Console.ReadLine().Split(' ').ToList();

            names.Reverse();

            Console.WriteLine(string.Join("; ", names));
        }
    }
}