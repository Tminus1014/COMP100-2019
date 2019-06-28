using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 4.	Write a C# program that displays a conversion table from gallons to liters. 
 * The program should display gallons from 10 to 20 in one-gallon increments and the 
 * corresponding liter equivalents. Use the relationship that 1 gallon contains 3.785 
 * liters. Your table must look professional!
 */
namespace Q4_GallonLiter
{
    class Program
    {
        static void Main(string[] args)
        {
            /* WHILE */

            int gallonStart = 10;
            double liter = 0;

            Console.WriteLine("Gallon     Liter");
            Console.WriteLine("------     -----");

            while (gallonStart <= 20)
            {
                liter = gallonStart * 3.785;

                Console.WriteLine($"{gallonStart,-11}{liter,0}");

                gallonStart++;
            }
        }
    }
}
