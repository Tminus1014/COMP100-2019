using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 10.	A conversion table of Celsius to Fahrenheit temperature. The table must start with 100 Celsius and end at 0 Celsius with decrements of 10. (Fahrenheit = Celsius * 9/5 + 32).
 * Your table must have a suitable header and the values in the table must be right-align.
 */
namespace Q10_Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            int celsiusStart = 100, fahrenheit;

            Console.WriteLine("Celsius      Fahrenheit");
            Console.WriteLine("-------      ----------");

            do
            {
                fahrenheit = celsiusStart * 9 / 5 + 32;

                Console.WriteLine("{0,7}{1,16}", celsiusStart, fahrenheit);

                celsiusStart -= 10;
            } while (celsiusStart >= 0);

            Console.WriteLine();
        }
        
    }
}
