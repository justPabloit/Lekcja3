using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja3
{
    class Program
    {
        static void Main(string[] args)
        {
            // INSTRUKCJE WARUNKOWE

            int a = 4;

            if (a > 0 && a>5)
            {
                Console.WriteLine("A jest większe od 0");
                Console.WriteLine("A jest większe od 5");
            }
            else if(a > 0)
            {
                Console.WriteLine("A jest większe od 0");
            }
            else if(a == 0)
            {
                Console.WriteLine("A jest równe 0");
            }
            else
            {
                Console.WriteLine("A jest mniejsze od 0");
            }
        }
    }
}
