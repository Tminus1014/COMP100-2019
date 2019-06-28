using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 4.	Write a program that prompts the user for the number of siblings his has. The program should display a message, 
 * “I have 4 siblings” (assuming that the user enters 3).
 */
namespace Q4_SiblingsP2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numSiblings;

            Console.Write("How many siblings u have?: ");
            numSiblings = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nlmao i have {numSiblings + 1} siblings");
        }
    }
}
