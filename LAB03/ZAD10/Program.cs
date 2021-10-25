using System;

namespace ZAD10
{
    class Program
    {
        bool CzyCyfra(char znak)
        {
            int x = Convert.ToInt32(znak);
            if (x >= 48 && x <= 57)
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
