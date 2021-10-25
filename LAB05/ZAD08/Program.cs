using System;

namespace ZAD08
{
    class Program
    {
        static bool CzyJest(int[] T1, int a, int n = 0)
        {
            int d = T1.Length;
            if (d == 0)
            {
                return false;
            }
            if (n == d)
            {
                return false;
            }
            if (T1[n] == a)
            {
                return true;
            }
            return CzyJest(T1, a, n + 1);


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
