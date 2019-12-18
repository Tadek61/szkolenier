using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05__operatoryarytmetyczne_cwiczenia
{
    class Program
    {
        static void Main(string[] args)
        {
            //bmi waga dzielona na (wzrost do kwadratu)

            double waga;
            double wzrost;
            double wynik_bmi;

            Console.WriteLine("podaj wage:");
            waga = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Waga wpisany: {waga}");
            Console.WriteLine("podaj wzrost:");
            wzrost = Convert.ToDouble ( Console.ReadLine());
            //wzrost = 1;
            
            wzrost = wzrost - 100;
            wynik_bmi = waga / (wzrost * wzrost);
            Console.WriteLine(wynik_bmi);
 
            Console.ReadKey();
        }
    }
}
