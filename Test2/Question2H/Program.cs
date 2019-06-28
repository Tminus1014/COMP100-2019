using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * =========================     Test #2 Winter 2019   =======================
 * 
 * Name: Trent B Minia
 * Student ID: 301041132
 *
 * Question 2h.
 * 10 Marks.
 *
 * Write a program that displays a conversion table for a fabric merchant. The 
 * program prompts the user for the start inch and the end inch. The table
 * must be in 0.25 increments. You must match the format exactly.
 * 
 * Type of loop-> for
 * 1 inch = 2.54 cms
 * [Solution: Question2H]
 ---------------------------------------------------------------------------- */
namespace Question2H
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter starting inch: ");
            double startInch = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter ending inch: ");
            double endInch = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(" Inch       CM");

            for (double start = startInch; start <= endInch; start+=0.25)
            {
                double conversionCm = start * 2.54;
                Console.WriteLine($"{start,5:F2}{conversionCm,9:F2}");
            }
        }
    }
}
