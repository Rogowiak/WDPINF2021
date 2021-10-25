using System;

namespace ZAD01
{
    class Program
    {
        static bool CzyPierwsza(int a)
        {
            if (a<=1)
            {
                return false;
            }
            for (int i = a/2; i > 1; i--)
            {
                if (a%i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CzyPierwsza(13));
            Console.WriteLine(CzyPierwsza(21));
            Console.WriteLine(CzyPierwsza(2));
            Console.WriteLine(CzyPierwsza(7));
            Console.ReadKey();
        }
    }
}
