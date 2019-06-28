using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 2.	Write a program that allows the user to enter two integers and a 
 * character If the character is A, add the two integers If it is S, subtract 
 * the second integer from the first else multiply the integers Display 
 * the results of the arithmetic
 */
namespace Q2_Int
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Integer 1: ");
            int integer1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Integer 2: ");
            int integer2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nA - Addition");
            Console.WriteLine("S - Subtraction");
            Console.Write("Select operation: ");
            string operation = Console.ReadLine();

            switch (operation.ToUpper())
            {
                case "A":
                    int result = integer1 + integer2;
                    Console.WriteLine($"\n{integer1} + {integer2} = {result}");
                    break;
                case "S":
                    result = integer1 - integer2;
                    Console.WriteLine($"\n{integer1} - {integer2} = {result}");
                    break;
                default:
                    result = integer1 * integer2;
                    Console.WriteLine($"\n{integer1} * {integer2} = {result}");
                    break;
            }

        }
    }
}
