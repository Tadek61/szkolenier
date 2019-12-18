#define doWhile
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab09___Petle
{
    class Program
    {
        static void Main(string[] args)
        {
#if (for1)
            for (int i = 0; i < 10; i++)
                Console.WriteLine(i);
#elif (for2)

            List<int> lista = new List<int>()
            {
               44,  12, 78,3
            }
            for (int i = 0; i < lista.Count; i++)
            {
            Console.Writeline(${i} -> {lista[i]}");
        forech (var    }
#elif (foreach)

            foreach (var item in lista)
#elif (while)
            int licznik = 0;
            while (licznik < 0)
            {
                licznik++
            }
#elif  (doWhile)
            int licznik = 0;
            do
            {
                Console.WriteLine(licznik);
                licznik++;
            } while (licznik < 10);

            Console.ReadKey();
 //break przerywa petle
 //continue przerywa dana iteracje i przechodzi do nastepnej
#endif


        }
    }
}
