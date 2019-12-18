#define cwiczenie2
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06_instrukcja_if
{
    class Program
    {
        static void Main(string[] args)
        {
#if (cwiczenie1)
            int a = 40;
            int b = 40;

            if (a > b)
            {
                Console.WriteLine("a jest wieksze od b");
            }
            else if (a < b)
            {
                Console.WriteLine("b jest wieksze od a");
            }
            else
                Console.WriteLine("b rowne a");
#elif (cwiczenie2)
            int liczba1;
            int liczba2; 
            int liczba3;

            Console.WriteLine("podaj liczbe calkowita 1:");
            liczba1 = Convert.Toint(Console.ReadLine());

            Console.ReadKey();
/*
 && operator and
 || operator or
 * 
 */ 


#endif
        }
    }
}
