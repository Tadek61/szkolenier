using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10___metody
{
    class Program
    {
        static string PobierzTekst(string tekst)
        {
            Console.WriteLine(tekst);
            return Console.ReadLine();
        }
        static string DajInicjaly(string imie, string nazwisko)
        {
            return imie[0] + "." + nazwisko[0] + ".";
        }
        static void DrukujDane(string imie, string nazwisko)
        {
            Console.WriteLine($"Nazywasz sie: {imie} {nazwisko}");
        }
        static int ZwrocDlugoscTekstu(string tekst, out int dlugosc)
        {
                dlugosc = tekst.Length;
                return dlugosc;
        }
        static void Main(string[] args)
        {
            string imie = PobierzTekst("Podaj imie:");
            string nazwisko = PobierzTekst("Podaj nazwisko:"); 
            Console.WriteLine($"{ imie} { nazwisko}");
            Console.Write("Twoje inicjaly to: ");
            Console.WriteLine(DajInicjaly(imie, nazwisko));
          //  Console.WriteLine(ZwrocDlugoscTekstu("QWERTY"));

            ZwrocDlugoscTekstu("QWERTY", out int dlugosc);
            Console.ReadKey();
        }
    }
}
