using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 10.	Write a C program that continuously requests a grade. 
 * If the grade is 999, the program should exit the loop and display the sum, number of valid grades and the average of the valid grades entered. (You must NOT display an invalid message)
 * If the grade is less than 0 or greater than 100, your program should print an appropriate message informing the user that an invalid grade has been entered, 
 * else the grade should be added to a total. 
 */
namespace Q10_Grade
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputGrade = 0;
            int counterGrade = 0;
            int totalGrade = 0;
            int averageGrade = 0;
            //bool enterGrade = true;

            Console.WriteLine("The super duper awesome grade average calculator!");
            Console.WriteLine("type in grade and press enter. type in 999 and press enter to finish calculating and view the super duper awesome results");
            Console.WriteLine();

            //while (enterGrade == true)
            //{
            //    Console.Write("Grade: ");
            //    inputGrade = Convert.ToInt32(Console.ReadLine());
                
            //    if (inputGrade == 999)
            //    {
            //        enterGrade = false;
            //    } else if (inputGrade > 100 || inputGrade < 0)
            //    {
            //        Console.WriteLine("you stoopid. this aint valid grade. try again D:<");
            //    } else
            //    {
            //        totalGrade += inputGrade;
            //        counterGrade++;
            //    }
            //}

            for (int counter = 0; ;counter++)
            {
                Console.Write("Grade: ");
                inputGrade = Convert.ToInt32(Console.ReadLine());

                if (inputGrade == 999)
                {
                    break;
                }
                else if (inputGrade > 100 || inputGrade < 0)
                {
                    Console.WriteLine("you stoopid. this aint valid grade. try again D:<");
                }
                else
                {
                    totalGrade += inputGrade;
                    counterGrade++;
                }
            }

            if (counterGrade == 0) //no divide by 0 error. :)
            {
                counterGrade++; 
                averageGrade = totalGrade / counterGrade;
                counterGrade--;
            } else
            {
                averageGrade = totalGrade / counterGrade;
            }

            Console.WriteLine();
            Console.WriteLine("super duper awesome results:");
            Console.WriteLine($"# of valid grades entered:     {counterGrade}");
            Console.WriteLine($"avg grade:                     {averageGrade}");
        }
    }
}
