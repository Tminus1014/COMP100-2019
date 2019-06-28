using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
 * Write a program that prompts the user for two integers. 
 * The program will display the result of summing and finding 
 * the difference. (If the user enters 8 and 3, the display 
 * should be 8 + 3 = 11 and 8 – 3 = 5).
 */
namespace Q3_Ints
{
    class Program
    {
        static void Main(string[] args)
        {
            int int1, int2;

            Console.Write("Enter first number: ");
            int1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\n{int1} + {int2} = {int1 + int2} and {int1} - {int2} = {int1 - int2}");
        }
    }
}
