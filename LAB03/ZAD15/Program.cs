using System;

namespace ZAD15
{
    class Program
    {
        static string ZwrocNapis2(string tekst1, string tekst2)
        {
            double t1 = tekst1.Length / 2;
            double t2 = tekst2.Length;
            if (t1>t2)
            {
                return tekst1 + tekst2;
            }
            return tekst1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
