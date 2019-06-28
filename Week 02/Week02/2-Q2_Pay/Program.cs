using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Write a program that prompts the user for a name,
 * Social Insurance Number, hourly pay rate and the 
 * number of hours worked. In an attractive format 
 * display all the input data as well as the following:
 * 
 * Gross pay is hourly pay rate times hours worked
 * Federal tax is 15 percent of gross pay
 * Provincial tax is 10 percent of gross pay
 * Net pay is gross minus federal and provincial taxes
 */
namespace _2_Q2_Pay
{
    class Program
    {
        static void Main(string[] args)
        {
            // I

            string name;
            string sin;
            double payRate;
            double hours;

            // P
            // O

            double grossPay;
            double federalTax;
            double provTax;
            double netPay;

            // A

            // Gather user info

            Console.Write("Name: ");
            name = Console.ReadLine();

            Console.Write("Social Insurance Number: ");
            sin = Console.ReadLine();

            Console.Write("Hourly Pay Rate: $");
            payRate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Hours Worked: ");
            hours = Convert.ToDouble(Console.ReadLine());

            // Calculate pay

            grossPay = payRate * hours;
            federalTax = grossPay * 0.15;
            provTax = grossPay * 0.10;
            netPay = grossPay - federalTax - provTax;

            // Display user info

            Console.WriteLine($"\nPayroll summary for {name}");
            Console.WriteLine($"SIN: {sin}");
            Console.WriteLine($"\nYou worked {hours} hours at a rate of {payRate:C}/hr");

            // Display pay

            Console.Write("\nGross Pay: ".PadRight(25)); Console.WriteLine($"{grossPay:C}");
            Console.Write("Federal Tax: ".PadRight(25)); Console.WriteLine($"{federalTax:C}");
            Console.Write("Provincial Tax: ".PadRight(25)); Console.WriteLine($"{provTax:C}");
            Console.WriteLine("".PadRight(35, '-'));
            Console.Write("Net Pay: ".PadRight(25)); Console.WriteLine($"{netPay:C}\n");

            /* 
             * To get the table at the bottom, you will need to ensure the lines with 
             * the dollar value end at the same column then use a column indicator with 
             * the placeholder. {«data value»,«number of columns to utilize»:«format 
             * specifier»}
             * 
             * e.g. {grossPay, 8:C} means put the second data value, display in currency 
             * format and occupy 8 columns
             */
        }
    }
}
