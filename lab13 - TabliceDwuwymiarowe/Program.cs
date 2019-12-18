using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13___TabliceDwuwymiarowe
{
    class Program
    {
        static void Main(string[] args)
        {
           int[,] tablica = new int[5,5];

           Random random = new Random();
            Console.WriteLine(random.Next(100));

            for (int rowNumber = 0, rowNumber < tablica.GetLength(0); rowNumber++)
            {
                tablica[rowNumber, columnNumber] = random.Next(100);
            }

           Console.ReadKey();
        }
    }
}
