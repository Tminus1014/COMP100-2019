using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * =========================      Test #2 Winter 2019      =========================
 * 
 * Name: Trent B Minia
 * Student ID: 301041132
 *
 * Question 5h.
 * 14 Marks.
 *
 * Write a program that displays the pattern show in the sample executable.
 * 
 * Type of loop-> your favorite (your must use a pair of nested loops)
 * Hints:
 *  1) Use counters that increments
 *  2) For columns use values between 61 and 76
 *  3) For rows use values between 16 and 21
 *  4) Start with a vertical line of "o" then repeat it as necessary (use the % operator)
 *  5) Again start with a horizontal line of "o" then repeat it as necessary 
 *     (use the % operator)
 *  6) Now combine the two above conditions
 *  
 * [Solution: Question5H]
 -------------------------------------------------------------------------------- */
namespace Question5H
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of columns: ");
            int userColumn = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number of rows: ");
            int userRow = Convert.ToInt32(Console.ReadLine());

            for (int row = 1; row <= userRow; row++)
            {
                for (int column = 1; column <= userColumn; column++)
                {
                    if (row % 3 == 0 && column % 3 == 0)
                    {
                        Console.Write(" ");
                    }
                    else {
                        Console.Write("o");
                    }
                }
                Console.WriteLine();
            }
        }   
    }
}
