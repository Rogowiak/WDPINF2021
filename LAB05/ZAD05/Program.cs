using System;

namespace ZAD05
{
    class Program
    {

        static long SumaKwadratow(int[] tab1, int[] tab2)
        {
            long a = 0 ;
            long b = 0;
            int d = 0;
            if (tab1 != null && tab1.Length != 0)
            {

                a = tab1[0] * tab1[0];

            }

            if (tab2 != null && tab2.Length != 0)
            {
                d = tab2.Length - 1;
                b = tab2[d];
                b = b * b;
            }
            long c = a + b;
            return c;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] tab1 = { 3 };
            int[] tab2 = { 6, 2147483 };

            Console.WriteLine(SumaKwadratow(tab1, tab2));
        }
    }
}
