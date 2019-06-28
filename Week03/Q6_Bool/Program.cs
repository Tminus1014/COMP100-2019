using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Write a program to ask the user about the validity of a simple statement. 
 * The program should accept the response then display the statement as well as the response. 
 * The response should be true or false. For this question, you must use a variable of type bool.
 */
namespace Q6_Bool
{
    class Program
    {
        static void Main(string[] args)
        {
            string statement = "u are an awesome person";
            bool awesome;

            Console.Write($"True or False? {statement}: ");
            awesome = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine($"\n{statement}: {awesome}");
        }
    }
}
