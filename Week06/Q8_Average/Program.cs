using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*8.	Same as the previous question but additionally displays the average of the numbers when the loop terminates. You will need a counter but not as a loop terminator.
 */
namespace Q8_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            double counter = 1, totalInput = 0;
            int userInput;

            do
            {
                Console.Write($"Enter  number #{counter}: ");
                userInput = Convert.ToInt32(Console.ReadLine());
                totalInput += userInput;
                counter++;

            } while (totalInput <= 100);

            Console.WriteLine("\nTotal input of 100 exceeded!");
            counter -= 1;
            
            double average = totalInput / counter;
            Console.WriteLine($"Average = {average}");
        }
    }
}
