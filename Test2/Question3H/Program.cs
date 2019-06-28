using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * =======================      Test #2 Winter 2019      =======================
 * 
 * Name: Trent B Minia
 * Student ID: 301041132
 *
 * Question 3h.
 * 10 Marks.
 *
 * Write a program that prompt the user input for an end and a start value. The 
 * program all the multiples of four in ascending order on a single line.
 * 
 * Type of loop-> do-while
 * [Solution: Question3H]
 ---------------------------------------------------------------------------- */
namespace Question3H
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter ending value: ");
            int userValueEnd = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter starting value: ");
            int userValueStart = Convert.ToInt32(Console.ReadLine());

            int currentValue = userValueStart;
            do
            {
                if (currentValue % 4 == 0)
                {
                    Console.Write($"{currentValue} ");
                }
                currentValue++;
            } while (currentValue < userValueEnd);
        }
    }
}
