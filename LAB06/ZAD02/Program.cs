using System;

namespace ZAD02
{
    class Program
    {
        
        static string ZwrocBinarnie(long liczba)
        {
            if (liczba<=0)
            {
                return "0";
            }
            string a = "";
            while (liczba>0)
            {
                a = liczba % 2 + a;
                liczba = liczba / 2;
            }
            return a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ZwrocBinarnie(5));
            Console.ReadKey();
        }
    }
}
