using System;

namespace Zad07
{
    class Program
    {
        static string Złącz(string tekst1, string tekst2)
        {
            return tekst1 + " " + tekst2;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Złącz("Hello", "World"));
            Console.ReadKey();
        }
    }
}
