using System;

namespace ZAD04
{
    class Program
    {
        static long Suma(int[] tab)
        {
            int a = tab.Length;
            if (tab == null)
            {
                return 0;
            }
            if (a == 0)
            {
                return 0;
            }
            long b = tab[a - 1];
            long c = tab[0];
            return b + c;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
