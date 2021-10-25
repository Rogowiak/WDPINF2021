using System;

namespace ZAD05
{
    class Program
    {
        static bool CzyParzystaIDodatnia(int x)
        {
            if (x>0)
            {
                if (x%2 ==0)
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
