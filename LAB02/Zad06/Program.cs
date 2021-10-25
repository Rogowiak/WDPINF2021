using System;

namespace Zad06
{
    class Program
    {
        static int SprawdzWartość(char znak)
        {
            return Convert.ToInt32(znak);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SprawdzWartość('%'));
            Console.ReadKey();
        }
    }
}
