using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Tile Limited wants a program allows its salesclerk to 
 * enter the length and width (in meters) of a rectangle 
 * and the price of a square meter of tile. The program 
 * should display the area of the rectangle and the total 
 * cost of the tile.
 */
namespace Q3_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            // I
            double length;
            double width;
            double price;
            // P
            // O
            double totalArea;
            double totalCost;
            // A
            Console.Write("Enter length: ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter width: ");
            width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter price of square meter/tile: $");
            price = Convert.ToDouble(Console.ReadLine());

            totalArea = length * width;
            totalCost = totalArea * price;

            Console.WriteLine($"The total area is {totalArea} and the cost will be {totalCost:C}.");
        }
    }
}
