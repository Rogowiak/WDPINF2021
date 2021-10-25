using System;

namespace ZAD11
{
    class Program
    {
        static bool CzyNalezyDoKola(double X1, double Y1, double Xs, double Ys, double r)
        {
            double d = Math.Pow(X1 - Xs, 2) + Math.Pow(Y1 - Ys, 2);
            if (d<=Math.Pow(r,2))
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
