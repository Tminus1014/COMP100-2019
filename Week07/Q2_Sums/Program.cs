using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 2.	Write a Program to compute the sum of eight numbers. You will prompt the 
 * user for each number. Your prompt should also indicate which number is currently 
 * being accepted e.g. your prompt can be "Please enter value #5: "
 */
namespace Q2_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            /* WHILE */

            //int prompt = 1, enterNumber = 0, totalSum = 0;

            //while (prompt < 9)
            //{

            //    Console.Write($"Enter value #{prompt}: ");
            //    enterNumber = Convert.ToInt32(Console.ReadLine());

            //    totalSum += enterNumber;
            //    prompt++;

            //}

            //Console.WriteLine($"The total sum is {totalSum}");

            /* FOR */

            int enterNumber = 0, totalSum = 0;

            for (int prompt = 1; prompt <= 8; prompt++)
            {
                Console.Write($"Enter value #{prompt}: ");
                enterNumber = Convert.ToInt32(Console.ReadLine());

                totalSum += enterNumber;
            }

            Console.WriteLine($"The total sum is {totalSum}");
        }
    }
}
