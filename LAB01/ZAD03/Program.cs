using System;

namespace ZAD03
{
    class Program
    {
        static double PoleProstokata(double a, double b)
        {
            double wynik = a * b;
            Console.WriteLine(wynik);
            return wynik;
        }
        static void Main(string[] args)
        {
            PoleProstokata(21, 2);
            Console.ReadKey();
        }
    }
}
