using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDemo
{
    class Program
    {
        static char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        static int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37 };
        static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        static string[] poem = { "Mary", "had", "a", "little", "lamb" };
        static string[] obama = { "Barack", "Hussein", "Obama" };

        static void Main(string[] args)
        {
            //PrintStringArray();

            //PrintPoem();

            //PrimesTotalSum();
            //PrimesDoubler();
            //PrimesTotalSum();

            //CharVowelsDisplay();
            //CharVowelsSubtract();
            //CharVowelsDisplay();

            //int primesSum = PrimesTotalSum();
            //Console.WriteLine($"Total: {primesSum}");

            //PrimesDisplayTen();

            numbersCounter();
        }
        #region Question1
        /* 
         * 1.	Write a method that prints the string array obama. Each element must be on a separate line.
         * From your main, call this method. [Your method will not take any parameters and it does not return a value.]
         * 
         */

        static void PrintStringArray()
        {
            for (int position = 0; position < obama.Length; position++)
            {
                Console.WriteLine(obama[position]);
            }
        }
        #endregion

        #region Question2
        /*
         * Write a method that prints the string array poem in reverse order. All the items must be in the same line. Your method will not take any parameters and it does not 
         * return a value. From your main, call this method. 
         */
         static void PrintPoem()
         {
            for (int position = poem.Length-1; position >= 0; position--)
            {
                Console.Write(poem[position]);
            }
            Console.WriteLine();
        }
        #endregion

        #region Question3, Question6
        /*
         * Write a method that sums all the items of the array primes, and then display this sum. From your main, call this method
         * 
         * Modify your solution for Question 3 so that the method calculates the sum, but return this value instead of displaying it/
         * From your main, call this new method and display the return value
         * 
         */

        static int PrimesTotalSum()
        {
            int arrayTotal = 0;

            for (int position = 0; position < primes.Length; position++)
            {
                arrayTotal += primes[position];
            }

            return arrayTotal;
        }
        #endregion

        #region Question4
        /*
         * Write a method that doubles all the items of the int array primes. This method does not display anything.
         * From your main, call the previous method, this method and then the previous method again. Because the previous 
         * method was called twice, you will have two printouts, one with the original value and the second one with the doubled values.
         * 
         */
         
        static void PrimesDoubler()
        {
            for (int position = 0; position < primes.Length; position++)
            {
                primes[position] *= 2;
            }
        }
        #endregion

        #region Question5
        /*
         * A) Write a method that will subtract 32 from each item of the char array vowels. The result of any arithmetic operation is a number, so you will have to cast your result 
         *    to a char in order to assign the resulting value to the char array 
         * B) Write a second method that will display all the items of the char array vowels on a single line 
         * C) From your main, call the second method, then the first and then the second again
         *      
         */
        static void CharVowelsSubtract()
        {
            for (int position = 0; position < vowels.Length; position++)
            {
                int charSubtract = (int)(vowels[position]) - 32;
                vowels[position] = (char)(charSubtract);
            }
        }

        static void CharVowelsDisplay()
        {
            for (int position = 0; position < vowels.Length; position++)
            {
                Console.Write(vowels[position]);
            }
            Console.WriteLine();
        }
        #endregion

        #region Question7
        /*
         *  Write a method that displays on the items that are greater than 10 in the primes array. 
         *  
         */
        static void PrimesDisplayTen()
        {
            for (int position = 0; position < primes.Length; position++)
            {
                if (primes[position] > 10)
                {
                    Console.WriteLine(primes[position]);
                }
            }
        }
        #endregion

        #region Question8
        /* 
         * Write a method that display the number of even and odd items in the numbers array
         */
        static void numbersCounter()
        {
            int evenCounter = 0;
            int oddCounter = 0;

            for (int position = 0; position < numbers.Length; position++)
            {
                if (numbers[position] % 2 == 0)
                {
                    evenCounter++;
                } else
                {
                    oddCounter++;
                }
            }
            Console.WriteLine($"# of Even Numbers: {evenCounter}");
            Console.WriteLine($"# of Odd Numbers: {oddCounter}");
        }
        #endregion
    }
}
