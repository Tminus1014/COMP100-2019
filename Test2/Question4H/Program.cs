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
 * Question 4h.
 * 12 Marks.
 *
 * Write a program that displays the table shown in the sample executable.
 * 
 * the relationship is given by the quadratic equation
 *             y = 2x^2 + x - 3
 *             
 * Type of loop-> your favorite (you MUST use a loop)
 * Hints:
 *  1) Generate the first column using a place holder (increment = 0.25)
 *  2) Generate successive columns one at a time by adding another placeholder
 *  3) Format using column specifier (do not use tabs)
 *     
 * [Solution: Question4H]
 ---------------------------------------------------------------------------- */
namespace Question4H
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("    x   2x^2     +x     -3      y");
            Console.WriteLine(" ----   ----   ----   ----   ----");
            for (double firstColumn = -1.60; firstColumn <= 1.15; firstColumn += 0.25)
            {
                double secondColumn = 2 * Math.Pow(firstColumn, 2);
                double thirdColumn = firstColumn;
                const double fourthColumn = -3;
                double fifthColumn = secondColumn + thirdColumn + fourthColumn;
                
                Console.WriteLine($"{firstColumn,5:F2}{secondColumn,7:F2}{thirdColumn,7:F2}{fourthColumn,7:F2}{fifthColumn,7:F2}");
            }
        }
    }
}
