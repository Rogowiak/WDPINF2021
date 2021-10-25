using System;

namespace ZAD10
{
    class Program
    {
        static int SumaNaParzystych(int[] T1, int n = 0)
        {
            int d = T1.Length;
            if (d == 0)
            {
                return 0;
            }
            if (n >= d)
            {
                return 0;
            }
            return T1[n] + SumaNaParzystych(T1, n + 2);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
