using System;

namespace ZAD06
{
    class Program
    {
        static double Srednia1(int[] tab)
        {
            double a = 0;
            double b = 0;
            double c = 0;
            int d = tab.Length - 1;
            if (tab != null && tab.Length != 0)
            {

                a = tab[0];
                b = tab[d];
                c = a + b;
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
