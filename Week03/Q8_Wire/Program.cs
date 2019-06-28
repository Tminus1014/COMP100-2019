using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 8.	Write a program to calculate and display the potential difference between the ends of a wire. The program will prompt the 
 * user for the current flowing and the resistance of the wire. (Potential difference is the product of the current and the resistance 
 * of the wire and may include a fractional part).
 */
namespace Q8_Wire
{
    class Program
    {
        static void Main(string[] args)
        {
            double current;
            double resist;
            double diff;

            Console.Write("Current: ");
            current = Convert.ToDouble(Console.ReadLine());

            Console.Write("Resistance: ");
            resist = Convert.ToDouble(Console.ReadLine());

            diff = current * resist;

            Console.WriteLine($"\nPotential Difference = {diff}");
        }
    }
}
