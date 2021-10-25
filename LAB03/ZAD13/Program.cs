using System;

namespace ZAD13
{
    class Program
    {
        static bool CzyTakieSame(string tekst1, string tekst2)
        {
            if (tekst1==tekst2)
            {
                return true;
            }

            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CzyTakieSame("AAA", "AAA"));
            Console.ReadKey();
        }
    }
}
