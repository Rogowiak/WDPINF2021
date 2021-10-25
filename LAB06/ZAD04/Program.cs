using System;

namespace ZAD04
{
    class Program
    {
        static long SumaNieparzystych(int[] T1)
        {
            long w = 0;
            for (int i = 0; i < T1.Length; i++)
            {
                if (T1[i] % 2 == 1)
                {
                    w += T1[i];
                }
            }
            return w;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
