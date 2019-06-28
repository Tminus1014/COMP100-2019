using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Write a console-based program that prompts the user for an hourly pay rate. If the value entered is less than $7.50, display an error message
 */
namespace Q1_HourlyRate
{
    class Program
    {
        static void Main(string[] args)
        {
            double payRate;

            Console.Write("Hourly Pay Rate: ");
            payRate = Convert.ToDouble(Console.ReadLine());

            if (payRate < 7.50)
            {
                Console.WriteLine($"\nERROR: Your hourly pay rate of {payRate:C} is too low. :(");
            }
        }
    }
}
