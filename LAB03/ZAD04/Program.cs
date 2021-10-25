using System;

namespace ZAD04
{
    class Program
    {
        static bool CzyPodzielnaPrzez3(int liczba)
        {
            if (liczba % 3 == 0)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
