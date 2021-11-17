using System;
using System.IO;
using System.Text;

namespace _11._01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static string ZwrocStudenta(Student s)
        {
            return s.imię + ";" + s.nazwisko + ";" + s.rokUrodzenia + ";" + s.ocena;
        }
        static void ZapiszStudenta(Student s, StreamWriter sw)
        {
            sw.WriteLine(ZwrocStudenta(s));
        }
        static Student OdczytajStudenta(StreamReader sr)
        {
            string imię = "", nazwisko = "", rok = "", ocena = "";
            string linia = sr.ReadLine();
            int i = 0;
            while (linia[i] != ';')
            {
                imię += linia[i];
                i++;
            }
            i++;
            while (linia[i] != ';')
            {
                nazwisko += linia[i];
                i++;
            }
            i++;
            while (i < linia.Length && linia[i] != ';')
            {
                rok += linia[i];
                i++;
            }

            i++;
            while (i < linia.Length && linia[i] != ';')
            {
                ocena += linia[i];
                i++;
            }
            Student s = new Student(imię, nazwisko,
                Convert.ToInt32(rok),
                Convert.ToDouble(ocena));
            return s;
        }
        static void ZapiszListęStudentów(ListaStudentów ls, string nazwapliku)
        {
            StreamWriter sw = new StreamWriter(nazwapliku, true, Encoding.UTF8);

            for (int i = 0; i < ls.licznik; i++)
            {
                ZapiszStudenta(ls.lista[i], sw);
            }

            sw.Close();
        }
        static ListaStudentów OdczytajListę(string nazwapliku)
        {
            StreamReader sr = new StreamReader(nazwapliku);
            ListaStudentów ls = new ListaStudentów(10);

            while (!sr.EndOfStream)
            {
                Student s = OdczytajStudenta(sr);
                ls.DodajDoListy(s);
            }
            sr.Close();

            return ls;
        }
        static void Konwertuj(string wejscie, string wyjscie)
        {
            StreamWriter sw = new StreamWriter(wyjscie, true, Encoding.UTF8);

            ListaStudentów ls = OdczytajListę(wejscie);
            double średnia = ObliczŚrednią(ls);
            int aktualnyrok = DateTime.Now.Year;

            for (int i = 0; i < ls.licznik; i++)
            {
                Student s = ls.lista[i];
                string nowaLinia = ZwrocStudenta(s);
                nowaLinia += ";" + (aktualnyrok - s.rokUrodzenia);
                // zamiana przecinka na kropkę w liczbie double
                nowaLinia += ";" + ZmienPrzecinekNaKropke(Convert.ToString(średnia - s.ocena));
                sw.WriteLine(nowaLinia);
            }

            sw.Close();

        }
        static double ObliczŚrednią(ListaStudentów ls)
        {
            double średnia = 0;
            double suma = 0;
            int licznik = 0;
            for (int i = 0; i < ls.licznik; i++)
            {
                suma += ls.lista[i].ocena;
                licznik++;
            }
            średnia = suma / licznik;
            return średnia;
        }
        static string ZmienPrzecinekNaKropke(string wejscie)
        {
            string wyjscie = "";
            for (int i = 0; i < wejscie.Length; i++)
            {
                if (wejscie[i] == ',')
                    wyjscie += ".";
                else
                    wyjscie += wejscie[i];
            }
            return wyjscie;
        }
    }
    class Student
    {
        public string imię;
        public string nazwisko;
        public int rokUrodzenia;
        public double ocena;
        // konstruktor struktury
        // należy zainicjalizować wszystkie pola struktury
        public Student(string I, string nazwisko, int rokUrodzenia, double ocena)
        {
            imię = I;
            this.nazwisko = nazwisko; // this - odwołanie do pola struktury
            this.rokUrodzenia = rokUrodzenia;
            this.ocena = ocena;
        }
        public string ZwróćInformacje()
        {
            return imię + " " + nazwisko + " " + rokUrodzenia;
        }
        public void Edytuj(string imie, string nazwisko, int rokUrodzenia, double ocena)
        {
            this.imię = imie;
            this.nazwisko = nazwisko;
            this.rokUrodzenia = rokUrodzenia;
            this.ocena = ocena;
        }
    }
    class ListaStudentów
    {
        // tablica studentów
        public Student[] lista;
        // liczy, ile studentów jest na liście
        public int licznik;

        public ListaStudentów(Student[] lista)
        {
            this.lista = lista;
            licznik = 0;
        }

        public ListaStudentów(int rozmiar)
        {
            this.lista = new Student[rozmiar];
            licznik = 0;
        }
        // dodaje studenta do listy
        public void DodajDoListy(Student o)
        {
            // jeśli w tablicy jest jeszcze miejsce, dodajemy studenta
            if (licznik < lista.Length)
            {
                lista[licznik] = o;
                licznik++;
            }
            else
            {
                // jeśli tablica jest wypełniona, zwiększamy jej rozmiar
                Array.Resize(ref lista, lista.Length + 4);
                // i dodajemy studenta
                lista[licznik] = o;
                licznik++;
            }
        }
        public void UsuńZListy(int doUsuniecia)
        {
            if (doUsuniecia < licznik && doUsuniecia >= 0)
            {
                // usunięcie polega na przesunięciu wszystkich elementów "za" usuwanym elementem o jedną pozycję wyżej
                for (int i = doUsuniecia; i < this.licznik - 1; i++)
                {
                    lista[i] = lista[i + 1];
                }
                licznik--;
            }
        }
        public string ZwróćInformacje()
        {
            string text = "";
            // zwraca wszystkie elementy tablicy
            for (int i = 0; i < licznik; i++)
            {
                text += "" + (i + 1) + " " + lista[i].ZwróćInformacje() + "\n";
            }
            return text;
        }
    }
}
