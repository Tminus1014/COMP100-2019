using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1.	Write a program to print the numbers 2 to 10 in increments of two on the same line.The output of your program should be 2 4 6 8 10*/
namespace Q1_Even
{
    class Program
    {
        static void Main(string[] args)
        {
            /* using do-while */

            //int start = 2, end = 10;

            //do
            //{
            //    Console.Write($"{start} ");
            //    start += 2;

            //} while (start <= end);

            //Console.WriteLine();

            /* using while */

            //int start = 2, end = 10;

            //while (start <= end)
            //{
            //    Console.Write($"{start} ");
            //    start += 2;
            //}

            /* using for */

            for (int start = 2, end = 10; start <= end; start += 2)
            {
                Console.Write($"{start} ");

            }


        }
    }
}
