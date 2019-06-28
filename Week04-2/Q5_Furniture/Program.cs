using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*5.	Write a program for a furniture company. Ask the user to choose Pine,
 * Oak or Mahogany. Show the price of a table manufactured with the chosen wood 
 * Pine tables cost $100, Oak tables cost $225, and Mahogany tables cost $310. 
 * Use named constants and switch.
 */
namespace Q5_Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("P - Pine");
            Console.WriteLine("O - Oak");
            Console.WriteLine("M - Mahogany");
            Console.Write("Make selection: ");
            string furnitureType = Console.ReadLine();

            const double Pine = 100, Oak = 225, Mahogany = 310;

            switch (furnitureType.ToUpper())
            {
                case "P":
                    Console.WriteLine($"\nCost of Pine Tables: {Pine:C}");
                    break;
                case "0":
                    Console.WriteLine($"\nCost of Oak Tables: {Oak:C}");
                    break;
                case "M":
                    Console.WriteLine($"\nCost of Mahogany Tables: {Mahogany:C}");
                    break;
                default:
                    Console.WriteLine("\ninvalid type");
                    break;
            }
        }
    }
}
