using System;

namespace ZAD09
{
    class Program
    {
        static bool CzyNiepar(int a)
        {
            return Convert.ToBoolean(a % 2);
        }
        static long SumaNieparzystych(int[] T1, int n = 0)
        {
            int d = T1.Length;
            if (d == 0)
            {
                return 0;
            }
            if (n == d)
            {
                return 0;
            }
            if (CzyNiepar(T1[n]))
            {
                return T1[n] + SumaNieparzystych(T1, n + 1);
            }
            return SumaNieparzystych(T1, n + 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
