using System;

namespace Za08
{
    class Program
    {
        static int IleZnaków(string tekst1, string tekst2)
        {
            string a = tekst1 + tekst2;
            return a.Length;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IleZnaków("Hello","World"));
            Console.ReadKey();
        }
    }
}
