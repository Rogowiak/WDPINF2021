using System;

namespace Zad03
{
    class Program
    {
        static bool CzyParzysta(int a)
        {
            bool x = Convert.ToBoolean(a % 2);
            return !x;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CzyParzysta(2));
            Console.ReadKey();
        }
    }
}
