using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 8.	Write a program that displays a conversion table from Fahrenheit to Celsius. The program must request the starting Fahrenheit value, the ending Fahrenheit value, and the 
 * increment. Thus, instead of the condition checking for a fixed count, the condition checks for the ending Fahrenheit value. Your table must look professional!
 */
namespace Q8_Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter starting temperature in Fahrenheit: ");
            double fahrenheitStart = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter ending temperature in Fahrenheit: ");
            double fahrenheitEnd = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter increment: ");
            double increment = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Fahrenheit     Celsius");
            Console.WriteLine("----------     -------");

            /* WHILE */

            double loopStart = fahrenheitStart;

            if (fahrenheitStart < fahrenheitEnd)
            {
                while (loopStart <= fahrenheitEnd)
                {
                    double celsius = (loopStart - 32) * 5 / 9;
                    Console.WriteLine($"{loopStart,6}{celsius,14:F1}");
                    loopStart += increment;
                }
            } else
            {
                while (loopStart >= fahrenheitEnd)
                {
                    double celsius = (loopStart - 32) * 5 / 9;
                    Console.WriteLine($"{loopStart,6}{celsius,14:F1}");
                    loopStart -= increment;
                }
            }

            /* FOR */

            //if (fahrenheitStart < fahrenheitEnd)
            //{
            //    for (double loopStart = fahrenheitStart; loopStart <= fahrenheitEnd; loopStart += increment)
            //    {
            //        double celsius = (loopStart - 32) * 5 / 9;
            //        Console.WriteLine($"{loopStart,6}{celsius,14:F1}");
            //    }
            //} else
            //{
            //    for (double loopStart = fahrenheitStart; loopStart >= fahrenheitEnd; loopStart -= increment)
            //    {
            //        double celsius = (loopStart - 32) * 5 / 9;
            //        Console.WriteLine($"{loopStart,6}{celsius,14:F1}");
            //    }
            //}
        }
    }
}
