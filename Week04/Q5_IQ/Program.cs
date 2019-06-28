using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 5.	Write an application that asks a user to enter an IQ score. If the score is a number less than 0 or greater than 200, issue an error message; otherwise, issue an “above average”, 
 * “average”, or “below average” message for scores over, at, or under 100, respectively
 */
namespace Q5_IQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your IQ: ");
            int iq = Convert.ToInt32(Console.ReadLine());

            if (iq < 0 || iq > 200) /*first check if input is valid*/
            {
                Console.WriteLine("\nLOL that's an invalid IQ.");
            } else /*if input is valid then evaluate iq*/
            {
                if (iq > 100) /*above avg*/
                {
                    Console.WriteLine("\nThat IQ is above average!");
                }
                else if (iq == 100) /*avg*/
                {
                    Console.WriteLine("\nThat IQ is average.");
                }
                else if (iq < 100) /*below avg*/
                {
                    Console.WriteLine("\nThat IQ is below average. :(");
                }
            }
        }
    }
}
