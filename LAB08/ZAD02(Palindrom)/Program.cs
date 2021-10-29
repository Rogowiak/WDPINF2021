using System;
using System.Runtime;
using System.Linq;
using System.IO;

namespace Palindrom
{
    class Program
    {
        public static bool CzyLiterka(char znak)
        {
            return char.IsLetter(znak);
        }

        public static int IleWyrazów(string tekst)
        {
            int d = tekst.Length;
            int w = 0;
            for (int i = 0; i < d; i++)
            {
                if (tekst[i] == ' ')
                {
                    w++;
                }
            }
            w++;
            return w;
        }

        public static string[] ZwrocTabliceWyrazow(string tekst)
        {
            int a = IleWyrazów(tekst);
            string[] tab = new string[a];
            for (int w = 0; w < a; w++)
            {
                for (int i = 0; i < tekst.Length; i++)
                {
                    string tmp = "";
                    while (i < tekst.Length && tekst[i] != ' ')
                    {
                        tmp = tmp + tekst[i];
                        i++;
                    }

                    tab[w] = tmp;
                }
            }
            return tab;
            
        }

        public static string[] UsunDuplikaty(string[] wyrazy)
        {
            return wyrazy.Distinct().ToArray();
        }

        
        public static bool CzyPalindrom(string tekst)
        {
            tekst = tekst.ToLower();
            string odwrocony = "";
            for (int i = 0; i < tekst.Length; i++)
            {
                odwrocony = tekst[i] + odwrocony;
            }
            if (tekst == odwrocony)
            {
                return true;

            }
            return false;

        }

        public static string[] ZnajdzPalindromy(string path)
        {
            StreamReader sr = new StreamReader(path);
            string text = sr.ReadToEnd();
            string[] tab = UsunDuplikaty(ZwrocTabliceWyrazow(text));
            string palindromy = "";
            for (int i = 0; i < tab.Length; i++)
            {
                if (CzyPalindrom(tab[i]))
                {
                    palindromy = palindromy + " " + tab[i];
                }

            }
            palindromy = palindromy.Remove(0, 1);
            return ZwrocTabliceWyrazow(palindromy);

        }

        public static void wypisz(string[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }
        }


        static void Main(string[] args)
        {
            wypisz(ZnajdzPalindromy("tekst.txt"));
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
