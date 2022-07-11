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
                string s = Console.ReadLine();

                var box = new Box<string>(s);

                Console.WriteLine(box);
            }
        }
    }
}
