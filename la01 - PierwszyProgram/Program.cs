#define przyklad1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace la01___PierwszyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
#if (przyklad1)
            string imie = "rafal";
            string nazwisko = "czarnkowwski";
        Console.WriteLine("Witaj {0} {1}", imie , nazwisko );

#elif (przyklad2)


        Console.write("Podaj jakiś tekst");

        string jaisTekst;

        jakisTekst + Console.Readline();

#elif (przyklad3)

        int liczba;
        
        Consle.write("Podaj jakas liczbe: ");

        liczba = int.parse(Console.readline());

#elif (przyklad4)
            Console.Write("Podaj jakiś tekst");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("drugi komunikat");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("trzeci komunikat");
            Console.ResetColor();

#endif
            Console.ReadKey();
            Console.Write("Podaj jakiś tekst");
        }
    }
}
