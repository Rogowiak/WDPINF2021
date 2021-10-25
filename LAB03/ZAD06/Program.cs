using System;

namespace ZAD06
{
    class Program
    {
        static bool CzyParzIDodINPrzez3(int a)
        {
            if (a%2==0 && a>0 && a%3!=0)
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
