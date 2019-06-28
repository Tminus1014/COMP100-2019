using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 2.	Write a program that prompts the user for the number of siblings his has. The program should display a message, 
 * “I also have 4 siblings” (assuming that the user enters 4).
 */
namespace Q2_Siblings
{
    class Program
    {
        static void Main(string[] args)
        {
            string numSiblings;

            Console.Write("How many siblings u have?: ");
            numSiblings = Console.ReadLine();

            Console.WriteLine($"\nOh cool, I also have {numSiblings} siblings!");
        }
    }
}
