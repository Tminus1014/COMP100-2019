using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Adult ticket cost $3.75 and child ticket cost $2.25. Write a program to prompt the user for the amount of adult and child ticket that 
 * she needs. The program will display a user friendly message of the number of tickets brought as well as the total cost. (Use the "C" 
 * format-specifier for currency).
 */
namespace Q9_Tix
{
    class Program
    {
        static void Main(string[] args)
        {
            double adultCost = 3.75;
            double childCost = 2.25;
            double adultTotalCost;
            double childTotalCost;
            double totalCost;
            int adultAmt;
            int childAmt;
            int totalAmt;

            Console.WriteLine($"Cost of Adult Tickets: {adultCost:C}");
            Console.WriteLine($"Cost of Child Tickets: {childCost:C}");

            Console.Write("\n# of Adult Tickets: ");
            adultAmt = Convert.ToInt32(Console.ReadLine());
            Console.Write("# of Child Tickets: ");
            childAmt = Convert.ToInt32(Console.ReadLine());

            adultTotalCost = adultAmt * adultCost;
            childTotalCost = childAmt * childCost;
            totalCost = adultTotalCost + childTotalCost;
            totalAmt = adultAmt + childAmt;

            Console.WriteLine("\nTicket Type     Quantity               Cost");
            Console.WriteLine("-----------     --------               ----");
            Console.WriteLine("{0,-16}{1,-13}{2,14}", "Adult", adultAmt, $"{adultTotalCost:C}");
            Console.WriteLine("{0,-16}{1,-13}{2,14}", "Child", childAmt, $"{childTotalCost:C}");
            Console.WriteLine("\n{0,-16}{1,-13}{2,14}", "TOTAL", totalAmt, $"{totalCost:C}");
            Console.WriteLine("");

        }
    }
}
