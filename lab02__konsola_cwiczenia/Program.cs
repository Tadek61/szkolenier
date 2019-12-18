using System;

namespace lab02__konsola_cwiczenia
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            zdefiniuj dwie zmienne (nic do nich jeszcze nie przypisuj)
            pierwsza z nich typu "string"
            druga typu "int" 

            Uruchom konsole:
            popros uzytkownika aby podal swoje imie (utrwal je w zmiennej typu "string"

            popros uzytkownika rowniez o to aby podal swioj wiek (zmiuenna typu "int")

            wyczysc konsole

            wypisz na konsoli komunikat "Witaj IMIE , masz X lat"
            */

            string imie;
            int wiek;

            Console.Write("Podaj swoje imie: ");
            imie = Console.ReadLine();

            Console.Write("Podaj swoj wiek: ");
            wiek = int.Parse(Console.ReadLine());

            Console.Clear();

        }
    }
}
