using System;

namespace ZAD12
{
    class Program
    {

        static int IlePierwiastkow(double delta)
        {
            if (delta>0)
            {
                return 2;
            }
            if (delta == 0)
            {
                return 1;
            }
            return 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
