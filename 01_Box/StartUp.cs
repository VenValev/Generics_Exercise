using System;
using System.Collections.Generic;
using System.Linq;

namespace Box
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var listBox = new List<string>();
            for(int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();

                listBox.Add(s);
            }

            var box = new Box<string>(listBox);

            int[] indexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            box.Swap(listBox, indexes[0], indexes[1]);

            Console.WriteLine(box);
        }
    }
}
