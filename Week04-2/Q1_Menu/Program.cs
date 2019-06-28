using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1.	Write a program that prompts the user for a menu choice. The program 
 * will display a message based on the following table:
 * 
 * 1 - Calculate area
 * 2 - Calculate volume
 * 3 - Calculate surface area
 * 4 - Exit the program
 * 5 - ERROR: Invalid choice*/

namespace Q1_Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Calculate area");
            Console.WriteLine("2 - Calculate volume");
            Console.WriteLine("3 - Calculate surface area");
            Console.WriteLine("0 - Exit");

            Console.Write("\nWhat would you like to do today?: ");

            int userSelection = Convert.ToInt32(Console.ReadLine());

            switch (userSelection)
            {
                case 1:
                    Console.WriteLine("\nCalculate area");
                    break;
                case 2:
                    Console.WriteLine("\nCalculate volume");
                    break;
                case 3:
                    Console.WriteLine("\nCalculate surface area");
                    break;
                case 0:
                    Console.WriteLine("\nExit");
                    break;
                default:
                    Console.WriteLine("\nerror invalid choice :(");
                    break;
            }
        }
    }
}
