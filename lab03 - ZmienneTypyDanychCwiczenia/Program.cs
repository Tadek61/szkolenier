#define cwiczenie4
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03___ZmienneTypyDanychCwiczenia
{
    class Program
    {
        static void Main(string[] args)
        {
#if (cwiczenie1)
            /*
            Napisz program wypisujacy dzien roku i sprawdzajacy czy aktualny rok jest przestepny. Skorzystaj z klasy DateTime.
            1. zadeklaruj zmienne typu Date
            2.wypisz na konsoli obecny dzien roku 
            3.wpisz na konsoli czy biezacy rok jest przestepny (metoda "IsleapYear")
            */

            DateTime aktualnaData = DateTime.Today;

            Console.WriteLine(aktualnaData.DayofYear);
#elif (cwiczenie2)
            /*
             
             Sprawdz jaki bedzie jutro dzien tygodnia
             1. zadeklaruj zmienna typu Date time 
             2. przypisz do niej kolejny dzien tygodnia
             3. wypisz na konsoli dzie tygodnia dla nowej zmiennej
    */
            DateTime aktualnaData = DateTime.Today;
            DateTime aktualnaData_next = DateTime.Today;
            Console.WriteLine((aktualnaData));
            aktualnaData_next = aktualnaData.AddDays(1);
            Console.WriteLine(aktualnaData_next);
            Console.WriteLine(aktualnaData_next.DayOfYear);
            Console.WriteLine(aktualnaData_next.DayOfWeek);
            Console.WriteLine(aktualnaData_next.DayOfWeek);
            
#elif (cwiczenie3)

            string imie;
            string nazwisko;

            Console.WriteLine($"Podaj imie i nazwisko: ");
            imie = Console.ReadLine(); 
            nazwisko = Console.ReadLine();

            Console.ReadKey();
#elif (cwiczenie4)
            float iks;
            float igrek;
            iks = 0.0f;
            igrek = 0f;
            Console.WriteLine(iks / igrek)


#endif

        }
    }
}
