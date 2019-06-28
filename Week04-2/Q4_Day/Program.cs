using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*4.	Write a program that prompts the user for a day of the week. The program 
 * will display a message based on the following table:
 * 
 * Sun - Home
 * Mon - Work
 * Tue - Work
 * Wed - Home
 * Thu - Work
 * Fri - Work
 * Sat - Work
 */
namespace Q4_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sun - Sunday");
            Console.WriteLine("Mon - Monday");
            Console.WriteLine("Tue - Tuesday");
            Console.WriteLine("Wed - Wednesday");
            Console.WriteLine("Thu - Thursday");
            Console.WriteLine("Fri - Friday");
            Console.WriteLine("Sat - Saturday");
            Console.Write("Enter day of week: ");

            string day = Console.ReadLine();

            switch (day.ToUpper())
            {
                case "SUN":
                    Console.WriteLine("\nHome");
                    break;
                case "MON":
                    Console.WriteLine("\nWork");
                    break;
                case "TUE":
                    Console.WriteLine("\nWork");
                    break;
                case "WED":
                    Console.WriteLine("\nHome");
                    break;
                case "THU":
                    Console.WriteLine("\nWork");
                    break;
                case "FRI":
                    Console.WriteLine("\nWork");
                    break;
                case "SAT":
                    Console.WriteLine("\nWork");
                    break;
                default:
                    Console.WriteLine("\nidk");
                    break;
            }
        }
    }
}
