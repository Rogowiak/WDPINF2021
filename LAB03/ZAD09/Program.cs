using System;

namespace ZAD09
{
    class Program
    {
        static bool CzyLitera(char a)
        {
            int x = Convert.ToInt32(a);
            if (x >= 65 && x <= 90)
            {
                return true;
            }
            if (x >= 97 && x <= 122)
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
