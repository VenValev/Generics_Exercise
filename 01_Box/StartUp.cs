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
            /*var listBox = new List<int>();
            for(int i = 0; i < n; i++)
            {
                int s = int.Parse(Console.ReadLine());

                listBox.Add(s);
            }

            var box = new Box<int>(listBox);

            int[] indexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            box.Swap(listBox, indexes[0], indexes[1]);

            Console.WriteLine(box);*/

            List<double> list = new List<double>();

            for(int i = 0; i < n; i++)
            {
                list.Add(double.Parse(Console.ReadLine()));
            }

            var box = new Box<double>(list);
            var element = double.Parse(Console.ReadLine());
            var count = box.CountElements(list, element);
            Console.WriteLine(count);

        }
    }
}
