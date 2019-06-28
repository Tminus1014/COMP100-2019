using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Write a program that allows the user to enter two integers and a character
 * If the character is A, add the two integers 
 * If it is S, subtract the second integer from the first 
 * If it is M, multiply the integers Display the results of the arithmetic
 */
namespace Q8_Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            int first, second;
            string operation;

            Console.Write("Enter first num: ");
            first = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second num: ");
            second = Convert.ToInt32(Console.ReadLine());

            Console.Write("Select operation (A/S/M): ");
            operation = Console.ReadLine();


        }
    }
}
