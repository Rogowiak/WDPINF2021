using System;

namespace Zad04
{
    class Program
    {
        static int Potega(int a, int b)
        {
            return Convert.ToInt32(Math.Pow(a, b));
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Potega(2,4));
            Console.ReadKey();
        }
    }
}
