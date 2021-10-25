using System;

namespace ZAD07
{
    class Program
    {
        static bool CzyMalaLitera(char a)
        {
            int x = Convert.ToInt32(a);
            if (x>= 97 && x<=122)
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
