using System;
using System.IO;

namespace Liczba
{
    class Program
    {
        static void Zapisz (int liczba, string path)
        {
            StreamWriter sw = new StreamWriter(path);
            sw.Write(liczba);
            sw.Close();

        }

        static int OdczytajLiczbę(string path)
        {
            StreamReader sr = new StreamReader(path);
            int w = Convert.ToInt16(sr.ReadLine());
            sr.Close();
            return w;
            
        }



        static void Main(string[] args)
        {
            Zapisz(12, "tekst.txt");
            Console.WriteLine(OdczytajLiczbę("tekst.txt"));
            Zapisz(420, "tekst.txt");
            Console.WriteLine(OdczytajLiczbę("tekst.txt"));
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
