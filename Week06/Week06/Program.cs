using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1.	To display five asterisks on a single line. Each asterisk must be separated by a space.
 */
namespace Week06
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 0;
            int stop = 5;

            do
            {
                Console.Write("* ");
                start++;
            } while (start < stop);
        }
    }
}
