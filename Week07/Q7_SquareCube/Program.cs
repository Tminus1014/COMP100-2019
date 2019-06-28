using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*7.	Write a program to produce a table of numbers from 10 to 1, with their 
 * squares and cubes. Again, your table must look professional!
 */
namespace Q7_SquareCube
{
    class Program
    {
        static void Main(string[] args)
        {
            /* WHILE */

            //double start = 10, squareValue = 0, cubeValue = 0;

            //Console.WriteLine("Number     Squared     Cubed");
            //Console.WriteLine("------     -------     -----");

            //while (start >= 1)
            //{
            //    squareValue = Math.Pow(start, 2); cubeValue = Math.Pow(start, 3);

            //    Console.WriteLine($"{start,-11}{squareValue,-12}{cubeValue,0}");

            //    start--;
            //}

            /* FOR */

            Console.WriteLine("Number     Squared     Cubed");
            Console.WriteLine("------     -------     -----");

            for (double start = 10; start >= 1; start--)
            {
                double squareValue = Math.Pow(start, 2); double cubeValue = Math.Pow(start, 3);
                Console.WriteLine($"{start,-11}{squareValue,-12}{cubeValue,0}");
            }
        }
    }
}
