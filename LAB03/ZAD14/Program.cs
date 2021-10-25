using System;

namespace ZAD14
{
    class Program
    {
        static string ZwrocNapis1(string tekst, char znak)
        {
            int d = tekst.Length;
            if (d % 2 == 1)
            {
                return tekst + Convert.ToString(znak);
            }
            return Convert.ToString(znak);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
