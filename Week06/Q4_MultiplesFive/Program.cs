using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*4.	To display the numbers 1 … 20 on separate lines with an asterisk after each multiples of 5. (multiples besides asterisk) 
 */
namespace Q4_MultiplesFive
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            do
            {
                counter++;
                
                if (counter % 5 == 0)
                {
                    Console.WriteLine($"{counter} *");
                } else
                {
                    Console.WriteLine(counter);
                }

            } while (counter < 20);
        }
    }
}
