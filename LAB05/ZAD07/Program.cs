using System;

namespace ZAD07
{
    class Program
    {
        static double Srednia2(int[] tab, int a, int b)
        {
            double x = 0;
            double y = 0;
            double c = 0;
            int d = tab.Length - 1;
            if (tab!=null && tab.Length != 0 && a <= d && b <=d)
            {
                x = tab[a];
                y = tab[b];
                c = x + y;
                c = c / 2;

            }
            return c;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
