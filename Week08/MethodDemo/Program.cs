using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("DEMO 1");
            //DisplayPersonalInformation();
            //Console.WriteLine("------");

            //Console.WriteLine("DEMO 2");
            //DisplayAreaCircle(1);
            //DisplayAreaCircle(10);
            //Console.WriteLine("------");

            Console.WriteLine("DEMO 3");
            Console.Write("Purchase Price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            double tax = CalculateTax(price);
            double cost = price + tax;

            Console.WriteLine();
            Console.WriteLine($"Price: {price:C}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("------");
        }

        /* 
         * DEMO: Write a method to display personal information.
         */

        static void DisplayPersonalInformation()
        {
            Console.WriteLine("TM");
            Console.WriteLine("Stoodent");
            Console.WriteLine("CenCol");
        }

        /*
         * DEMO: Write a method to take radius of a circle and calculate and display the area
         * 
         * Call this method twice with argument 1 and 10.
         */

        static void DisplayAreaCircle(double radius)
        {
            double area = Math.PI * radius * radius;
            Console.WriteLine($"A circle of radius {radius:f2} will have an areuh of {area:f2}");
        }

        /*
         * DEMO: Write a method that takes the price of an article and calculates and returns the tax ($0.13)
         * 
         * Prompt for price of purchase in main method, then call this method to display cost.
         */

        static double CalculateTax(double price)
        {

            double tax = 0.13 * price;

            return tax;
        }
    }
}
