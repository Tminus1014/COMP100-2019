using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*7.	The average cost of a college textbook is $125. There is a premium of 20% on hardcover text and a discount of 5% on sales of more than 4 textbooks. Write a program to prompt the 
 * user for the appropriate inputs and compute and display the before-tax cost of the textbooks.
 */
namespace Q7_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("# of softcover textbooks: ");
            int sCoverAmt = Convert.ToInt32(Console.ReadLine());

            Console.Write("# of hardcover textbooks: ");
            int hCoverAmt = Convert.ToInt32(Console.ReadLine());

            /*total # of txtbooks*/
            int txtTotal = sCoverAmt + hCoverAmt;

            /*calculate initial cost of total txtbooks*/
            double initCost = 0 + (txtTotal * 125);

            /*declare variables for premiums, discounts, & final cost*/
            double premCost = 0; /*premium on hardcovers*/
            double discCost = 0; /*discount on txtTotal > 4*/
            double finalCost = 0; /*final cost accounting for inital cost w/ premium cost and discount*/

            /*check for premium*/
            if (hCoverAmt > 0)
            {
                premCost = initCost * 0.20;
            }

            /*check for discount*/
            if (txtTotal > 4)
            {
                discCost = initCost * 0.05;
            }

            finalCost = initCost + premCost - discCost;

            Console.WriteLine($"\nTotal Cost before Taxes = {finalCost:C}");
        }
    }
}
