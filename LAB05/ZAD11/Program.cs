using System;

namespace ZAD11
{
    class Program
    {
        static bool CzyNiepar(int a)
        {
            return Convert.ToBoolean(a % 2);
        }
        static bool CzyNiepodzielna3(int a)
        {
            if (a%3!=0)
            {
                return true;
            }
            return false;
        }
        static int IleSpelnia(int[] T1, int n = 0)
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
            if (CzyNiepar(T1[n]) && CzyNiepodzielna3(T1[n]))
            {
                return 1 + IleSpelnia(T1,n+1);
            }
            return IleSpelnia(T1, n + 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
