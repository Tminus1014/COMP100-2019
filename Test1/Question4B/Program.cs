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
 * Question 4b.
 * 14 Marks.
 *
 * Enterprise Car Rentals has asked you to write a program that prompts 
 * the user for the type of rider. Based on the user's input the program 
 * will display the following:
 * 
 * Input: sedan
 * Message: sedan cost 21.40 per day
 * 
 * Input: COMPACT
 * Message: COMPACT cost 18.90 per day
 * 
 * Input: Sports
 * Message: Sports cost 32.80 per day
 * 
 * any other input
 * Message: I am sorry I don't know of that kind of car
 * 
 * You may use either the ToUpper() or ToLower() methods 
 * 
 * You MUST USE ONLY A SWITCH statement to solve this problem
 * [For full marks you need to accept all permutations of sedan, 
 * compact and sports]
 * 
 * [Solution: Question4B]
 */
namespace Question4B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What kind of car would you like to rent? ");
            string userCarRent = Console.ReadLine();

            string selectedCar = userCarRent.ToUpper();

            switch (selectedCar) {
                case "SEDAN":
                    Console.WriteLine($"{userCarRent} costs 21.40 per day.");
                    break;
                case "COMPACT":
                    Console.WriteLine($"{userCarRent} costs 18.90 per day.");
                    break;
                case "SPORTS":
                    Console.WriteLine($"{userCarRent} costs 32.80 per day.");
                    break;
                default:
                    Console.WriteLine($"I am sorry I don't know of that kind of car");
                    break;
            }
        }
    }
}
