using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03___Zmienne
{
    class Program
    {
        static void Main(string[] args)
        {
            string /*typ danych*/ zmienna = "jakis text";
            zmienna = "jakis tekst";

            //LICZBY CALKOWITE

            byte vByte = 255;
            Console.WriteLine($"zmienna vByte - [ {vByte}]");
            Console.WriteLine($"min: [{Byte.MinValue} max: [{Byte.MaxValue} ]");

            sbyte vsbyte = 100;
            Console.WriteLine($"zmienna vByte - [ { vByte}]"); 
            Console.WriteLine($"min: [{Byte.MinValue} max: [{Byte.MaxValue} ]");
                
            short vshort = 100;
            Console.WriteLine($"zmienna vByte - [ { vByte}]"); 
            Console.WriteLine($"min: [{Byte.MinValue} max: [{Byte.MaxValue} ]");

            ushort vUshort = 100;

            int vInt = 100;

            uint vuint = 100;

            long vlong = 100;

            ulong vulog = 100;
         

            //LICZBY ZMIENNOPRZECINKOWE

            float vFloat = 1.5f;
            Console.WriteLine($"zmienna vFloat - [ {vFloat} ]");
            Console.WriteLine($"min: {Single.MinValue} ] max: [{Single.MaxValue} ]");
            
            double VDouble  = 1.5;

            decimal vDecimal = 1.5M;

            //BOOLEAN

            bool vBool = true;

            //NULLABLE

            int? zmiennaNulla = null;

            //TYP ZNAKOWY

            char vChar = 'a';
            Console.WriteLine($"zmienna vChar -[ {vChar} ]");

            //LANCUCH ZNAKOW

            string vImie = "Jan";
            string vNazwisko = "  Kowalski  ";
            Console.WriteLine($"{vImie} { vNazwisko.Substring(2, 3)}");

            Console.WriteLine("d:\\moje_pliki\\plik.txt");
            Console.WriteLine($@"d:\moje_pliki\plik.txt");

            //VAR

            var vZmienna = "abc";
            Console.WriteLine(vZmienna);
            Console.WriteLine(vZmienna.GetType());

            var vVarInt = 22;

            var vVarFloat = 22f;

            //DYNAMIC

            dynamic dynamicInt;
            dynamicInt = 12;
            Console.WriteLine(dynamicInt);
            Console.WriteLine(dynamicInt.GetType());

            //OBJECT

            object vObject = 0;
            Console.WriteLine(vObject);
            Console.WriteLine(vObject.GetType());
            vObject = "abc";
            Console.WriteLine(vObject);
            Console.WriteLine(vObject.GetType());

            //DATA
            Console.WriteLine($"teraz: [ {DateTime.Now} ]");
            Console.WriteLine($"dzis: [ {DateTime.Today} ]");
            Console.WriteLine($"wczoraj: [ {DateTime.Today.AddDays(-1)} ]");
            Console.WriteLine($"jutro: [ {DateTime.Today.AddDays(1)} ]");
            Console.WriteLine($"dzien roku: [ {DateTime.Today.DayOfYear} ]");
            Console.WriteLine($"dzien roku: [ {DateTime.} ]");

            DateTime jakasData = DateTime.Now;
            Console.WriteLine(jakasData);

            DateTime jakasDatatc = DateTime.Now;
            Console.WriteLine(jakasData);

            Console.ReadKey();
        }
    }
}
