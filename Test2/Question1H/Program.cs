using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * =========================    Test #2 Winter 2019    =========================
 * 
 * Name: Trent B. Minia
 * Student ID: 301041132
 *
 * Question 1h.
 * 8 Marks.
 *
 * Write a program that sums five numbers specified by the user. The program 
 * doubles any even input when adding.
 * 
 * Type of loop-> while
 * [Solution: Question1H]
 ----------------------------------------------------------------------------*/
namespace Question1H
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentValue = 1;
            int userInputValue = 0;
            int userTotalValue = 0;

            while (currentValue <= 5)
            {
                Console.Write($"Enter Value {currentValue}: ");
                userInputValue = Convert.ToInt32(Console.ReadLine());

                if (userInputValue % 2 == 0)
                {
                    userTotalValue += userInputValue * 2;
                } else
                {
                    userTotalValue += userInputValue;
                }

                currentValue++;
            }

            Console.WriteLine($"Total value: {userTotalValue}");
        }
    }
}
