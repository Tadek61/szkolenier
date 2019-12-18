using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab07__instrukcjaswitch
{
    class Program
    {
        static void Main(string[] args)
        {
            switch(6)
            {
                case 1:
                    Console.WriteLine("jeden");
                    break;
                case 2:
                    Console.WriteLine("dwa");
                case 3:
                case 4:
                    Console.WriteLine("jeden");
                    break;
                default:
                    Console.WriteLine("niezidentyfikowana");

            }
            Console.ReadKey();
        }
    }
}
