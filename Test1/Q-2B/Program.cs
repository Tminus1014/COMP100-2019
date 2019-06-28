using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * ==================      Test #1 Winter 2019      ==================
 * 
 * Name: Trent B Minia
 * Student ID: 301041132
 *
 * Question 2b.
 * 12 Marks.
 *
 * Write a program that prompts the user for his current balance and his
 * name.The program displays his name and year end balance. You must 
 * match the  format exactly.
 * 
 * Hint: balance at the end of the year = current balance * 1.04;
 * [Solution: Question2B]
 */
namespace Question2B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your current balance: ");
            double userBalanceCurrent = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();

            double userBalanceFinal = userBalanceCurrent * 1.04;

            Console.WriteLine($"Hi {userName} your balance at the end of the year will be {userBalanceFinal:C}");
        }
    }
}
