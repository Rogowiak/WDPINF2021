using System;

namespace ZAD05
{
    class Program
    {
        static int Ile(int[] T1)
        {
            int licznik = 0;
            for (int i = 0; i < T1.Length - 1; i++)
            {
                long tmp1 = T1[i];
                long tmp2 = T1[i + 1];
                long tmp = tmp1 + tmp2;
                if (tmp %3==0)
                {
                    licznik++;
                }
            }
            return licznik;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
