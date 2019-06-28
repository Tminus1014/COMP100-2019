using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 6.	Write a console-based program that prompts the user for an hourly pay rate and hours worked. Compute gross pay (hours times pay rate), withholding tax, and net pay (gross pay 
 * minus withholding tax). Withholding tax is computed as a percentage of gross pay based on the following:
 * Gross Pay        Witholding Pct
 * <= 300.00        0.10
 *  > 300.00        0.12
 */
namespace Q6_Pay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hourly Pay Rate: $");
            double payRate = Convert.ToDouble(Console.ReadLine());

            Console.Write("# of Hours Worked: ");
            double hrs = Convert.ToDouble(Console.ReadLine());

            double grossPay = hrs * payRate;

            /*calculate withholding tax based on user's grosspay*/
            double withhTax = 0;
            double netPay = 0;

            if (grossPay <= 300.00) 
            {
                withhTax = withhTax + grossPay * 0.10;
                netPay = grossPay - withhTax;
            } else if (grossPay > 300.00)
            {
                withhTax = grossPay * 0.12;
                netPay = grossPay - withhTax;
            }

            Console.WriteLine($"\nGross Pay: {grossPay:C}");
            Console.WriteLine($"Withholding Tax: {withhTax:C}");
            Console.WriteLine($"Net Pay: {netPay:C}");
        }
    }
}
