using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Write a program that declares four variables to hold the 
 * number of eggs produced in a month by each of four hens. 
 * Your program should sum the eggs, and then display the 
 * total in dozens. For example, a total of 127 eggs is 10 
 * dozens and 7 eggs.
 */

namespace _2_Q1_Hens
{
    class Program
    {
        static void Main(string[] args)
        {
            // I
            int hen1;
            int hen2;
            int hen3;
            int hen4;

            // P
            // O
            int eggTotal; // total number of eggs
            int eggDozen; // number of dozen of eggs
            int eggSingle; // number of remaining eggs

            // A

            // Input number of eggs per hen
            Console.WriteLine("Enter # of eggs for each hen.\n");

            Console.Write("Hen 1: ");
            hen1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Hen 2: ");
            hen2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Hen 3: ");
            hen3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Hen 4: ");
            hen4 = Convert.ToInt32(Console.ReadLine());

            // Sum total of eggs

            eggTotal = hen1 + hen2 + hen3 + hen4;
            eggDozen = eggTotal / 12;
            eggSingle = eggTotal % 12;
            
            if (eggDozen == 1)
            {
                Console.WriteLine($"\nYou have a total of {eggDozen} dozen and {eggSingle} eggs.");
            } else
            {
                Console.WriteLine($"\nYou have a total of {eggDozen} dozens and {eggSingle} eggs.");
            }
            
        }
    }
}
