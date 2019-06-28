using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*3.	Write a program that prompts the user for the number of courses and 
 * residency status (domestic or international) and calculates tuition cost. 
 * Cost is calculated based on the table below.
 * 
 * Domestic $325/course
 * Intl     $1375/course
 */
namespace Q3_Tuition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DOM - Domestic");
            Console.WriteLine("INTL - International");
            Console.Write("Enter residency status: ");
            string residenceStatus = Console.ReadLine();

            Console.Write("\nEnter # of courses: ");
            int amountCourses = Convert.ToInt32(Console.ReadLine());

            const double Domestic = 325, International = 1375;

            switch (residenceStatus.ToUpper())
            {
                case "DOM":
                    double tuitionCost = amountCourses * Domestic;
                    Console.WriteLine($"\nCurrent cost of Tuition: {tuitionCost:C}");
                    break;
                case "INTL":
                    tuitionCost = amountCourses * International;
                    Console.WriteLine($"\nCurrent cost of Tuition: {tuitionCost:C}");
                    break;
                default:
                    Console.WriteLine("\nerror");
                    break;

            }
        }
    }
}
