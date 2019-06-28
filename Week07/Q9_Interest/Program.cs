using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 9	Write and run a C# program that calculates and displays the amount of money available in a bank account that initially has $1,000 deposited in it and that earns 8 percent interest 
 * a year. Your program should display the amount available at the end of each year for a period of ten years. Use the relationship that the money available at the end of each year equals 
 * the amount of money in the account at the start of the year plus .08 times the amount available at the start of the year.
 */
namespace Q9_Interest
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 1;
            double currentBalance = 1000;
            const double Interest = 0.08;

            Console.WriteLine("Year     Balance");
            Console.WriteLine("----     -------");

            //while (year < 11)
            //{
            //    currentBalance += currentBalance * Interest;
            //    Console.WriteLine($"{year,-9}{currentBalance:C}");
            //    year++;
            //}

            for (year = 1; year < 11; year++) {
                currentBalance += currentBalance * Interest;
                Console.WriteLine($"{year,-9}{currentBalance:C}");
            }
        }
    }
}
