using System;

namespace ZAD03
{
    class Program
    {
        static bool CzyWNapisie(string tekst, char znak)
        {
            int a = tekst.Length;
            for (int i = 0; i < a; i++)
            {
                if (tekst[i] == znak)
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
