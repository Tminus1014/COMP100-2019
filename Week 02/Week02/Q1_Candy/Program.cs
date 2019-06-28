using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * A confectionary store wants a program that will prompt 
 * the user for the price of the candy and the amount of 
 * money she would like to spend and then calculates and 
 * display the amount of candies that can be purchased.  
 */

namespace Q1_Candy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            double price;
            double budget;
            // Processing
            // Output
            double numberCandies;
            // Algorithm
            Console.Write("Enter price of a candy: $");
            price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter amount of cash: $");
            budget = Convert.ToDouble(Console.ReadLine());
            numberCandies = budget / price;
            Console.WriteLine($"With {budget:C}, you can get {numberCandies:N0} candies. :)");
        }
    }
}
