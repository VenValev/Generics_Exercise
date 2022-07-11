using System;

namespace Box
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                int s = int.Parse(Console.ReadLine());

                var box = new Box<int>(s);

                Console.WriteLine(box);
            }
        }
    }
}
