using System;

namespace Zad05
{
    class Program
    {
        static double Podziel(int x, int y)
        {
            double a = Convert.ToDouble(x);
            double b = Convert.ToDouble(y);
            return a / b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Podziel(6,10));
            Console.ReadKey();
        }
    }
}
