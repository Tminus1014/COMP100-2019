using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 3.	Write a Program to compute the average of ten numbers. You will prompt the 
 * user for each number
 */
namespace Q3_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            /* WHILE */

            int prompt = 0, enterNumber = 0, average = 0;

            while (prompt < 10)
            {
                prompt++;

                Console.Write($"Enter value #{prompt}: ");
                enterNumber = Convert.ToInt32(Console.ReadLine());

                average += enterNumber;

            }

            average /= 10;

            Console.WriteLine($"Average is {average}");
        }
    }
}
