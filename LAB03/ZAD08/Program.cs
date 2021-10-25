using System;

namespace ZAD08
{
    class Program
    {
        static bool CzyDuzaLitera(char a)
        {
            int x = Convert.ToInt32(a);
            if (x >= 65 && x <= 90)
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
