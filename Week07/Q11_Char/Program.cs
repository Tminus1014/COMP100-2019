using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 11.	Print the decimal, octal, and hexadecimal values of all characters between the start and stop characters entered by a user. For example, if the user enters an a and a z, the 
 * program should print all the characters between a and z and their respective numerical values. Make sure that the second character entered by the user occurs later in the alphabet 
 * than the first character. If it does not, write a loop that repeatedly asks the user for a valid second character until one is entered.
 */
namespace Q11_Char
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter starting character from a-z: ");
            char startCharacter = Convert.ToChar(Console.ReadLine());

            char endCharacter = 'a';
            bool validSecondCharacter = false;

            while (validSecondCharacter == false)
            {
                Console.Write("enter ending character from a-z: ");
                endCharacter = Convert.ToChar(Console.ReadLine());

                if (endCharacter < startCharacter)
                {
                    Console.WriteLine("you stoopid thats invalid. try again");
                } else
                {
                    validSecondCharacter = true;
                }
            }

            Console.WriteLine();
            Console.WriteLine("letter     dec     oct     hex");
            //while (startCharacter <= endCharacter)
            //{
            //    int letterDecimal = (int)startCharacter;
            //    string letterOctal = Convert.ToString(letterDecimal, 8);
            //    string letterHexadecimal = Convert.ToString(letterDecimal, 16);

            //    Console.WriteLine($"{startCharacter,6}{letterDecimal,8}{letterOctal,8}{letterHexadecimal,8}");
            //    startCharacter++;
            //}
            for (char counter = startCharacter; counter <= endCharacter; counter++)
            {
                int letterDecimal = (int)counter;
                string letterOctal = Convert.ToString(letterDecimal, 8);
                string letterHexadecimal = Convert.ToString(letterDecimal, 16);

                Console.WriteLine($"{counter,6}{letterDecimal,8}{letterOctal,8}{letterHexadecimal,8}");
            }
        }
    }
}
