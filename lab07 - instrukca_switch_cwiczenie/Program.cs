using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab07___instrukca_switch_cwiczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            switch (DateTime.Now.DayOfweek)
            {
                case DayOfWeek.Sunday:
                    Console.WriteLine("jest niedziela");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("dwa");
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:

                case DayOfWeek.Wensday:
                case DayOfWeek.Wensday:
                case DayOfWeek.Wensday:
                case DayOfWeek.Wensday:
                    Console.WriteLine("jeden");
                    break;
                default:
                    Console.WriteLine("niezidentyfikowana");

            }
        }
}
