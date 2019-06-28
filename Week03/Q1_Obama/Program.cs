using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Create a program that prompts the user for her first name, middle initial and last name. The program will display the user name three 
 * times using the following three formats: 
 * 
 * first name and last name
 * first name middle initial and last name
 * last name, first name and middle initial
 * 
 * For inputs Barack H Obama
 * Barack Obama
 * Barack H Obama
 * Obama, Barack H

 */

namespace Q1_Obama
{
    class Program
    {
        static void Main(string[] args)
        {
            string fName, mName, lName;

            Console.Write("First name: ");
            fName = Console.ReadLine();

            Console.Write("Middle name initial: ");
            mName = Console.ReadLine();

            Console.Write("Last name: ");
            lName = Console.ReadLine();

            Console.WriteLine($"\n{fName} {lName}");
            Console.WriteLine($"{fName} {mName} {lName}");
            Console.WriteLine($"{lName}, {fName} {mName}");
        }
    }
}
