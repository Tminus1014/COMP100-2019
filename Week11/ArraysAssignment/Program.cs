using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAssignment
{
    class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            char[] letters = "the quick brown fox jumps over the lazy dog".ToCharArray();
            int[] numbers = { 0, 2, 3, 5, 7, 1, 1, 2, 5, 6, 7, 2, 5, 2 };
            string[] poem = "mary had a little lamb its fleece was white as snow".Split();

            //PrintCharArray(letters);
            //PrintIntArray(numbers);
            //PrintStringArray(poem);

            #region Question4
            /* In your main method use the method in question 1 to display the letters array, then use the Array.Reverse() method 
             * to reverse the letters array and then again call the appropriate method to print it
             */
            PrintCharArray(letters);
            Array.Reverse(letters);
            PrintCharArray(letters);
            #endregion
            Console.WriteLine();
            #region Question5
            /*
             * In your main method use the method in question 3 to display the poem array, then use the Array.Sort() method to 
             * sort the poem array and then again call the appropriate method to print it
             */
            PrintStringArray(poem);
            Array.Sort(poem);
            PrintStringArray(poem);
            #endregion
            Console.WriteLine();
            #region Question6
            /*
             * In your main method use the method in question 2 to display the numbers array, then use the Array.Binarysearch() method 
             * to try to find the position of 3 in the numbers array. What is your answer? Now repeat the same steps after you have 
             * sorted the array and printed the sorted array
             */
            PrintIntArray(numbers);
            Console.WriteLine($"Number 3 is at position {Array.BinarySearch(numbers, 3)}"); //Result: -9
            Console.WriteLine("\nNow sorting...\n");
            Array.Sort(numbers);
            PrintIntArray(numbers);
            Console.WriteLine($"Number 3 is now at position {Array.BinarySearch(numbers, 3)}");
            #endregion
            Console.WriteLine();
            #region Question7
            int[] createdArray = CreateIntArray(5);
            PrintIntArray(createdArray);
            Console.WriteLine();
            #endregion
            Console.WriteLine();
            #region Question8
            Console.WriteLine("Generating numbers between 100 - 200...");
            int[] randomArray = CreateRandomIntArray(20);

            foreach (int number in randomArray)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
            #endregion
            Console.WriteLine();
        }
        #region Question1
        /*
         * Write a method that takes an argument (a char array) and print each item on a single line separated by a space. 
         * From your main, call this method with letters as argument
         */
        static void PrintCharArray (char[] toPrint)
        {
            foreach (char letter in toPrint)
            {
                Console.Write($"{letter} ");
            }
            Console.WriteLine();
        }
        #endregion

        #region Question2
        /* Write a method that takes an argument (an int array) and print each item on a single line separated by a space. 
         * From your main, call this method with numbers as argument
         */
        static void PrintIntArray (int[] toPrint)
        {
            foreach (int number in toPrint) {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
        }
        #endregion

        #region Question3
        /*
         * Write a method that takes an argument (a string array) and print each item on a single line separated by a space. 
         * From your main, call this method with poem as argument
         */
        static void PrintStringArray (string[] toPrint)
        {
            foreach (string word in toPrint)
            {
                Console.Write($"{word} ");
            }
            Console.WriteLine();
        }
        #endregion

        #region Question7
        /*
         * Write a method that creates and return an array of ints. The method takes a single int argument that represents the how many 
         * items will be in the resulting array and does the following: 
         *  - Declare an array of the required type
         *  - Allocate memory for the intended number of items
         *  - Using any looping structure, prompt the user for a number and then assign to each element. 
         * In your main method do the following: (1) call this method (you will need to supply an argument), assign the resulting value 
         * to at suitable variable and then (2) display this variable
         */
        static int[] CreateIntArray (int arrayAmount)
        {
            int[] newArray = new int[arrayAmount];
            
            for (int position = 0; position < arrayAmount; position++)
            {
                Console.Write($"Enter number for array position #{position}: ");
                newArray[position] = Convert.ToInt32(Console.ReadLine());
            }
            return newArray;
        }
        #endregion

        #region Question8
        /* 
         * Write another method that creates and return an array of ints. The method takes a single argument that represents the number 
         * of items in the resulting array and does the following:
         *  - Declare an array of the required type
         *  - Allocate memory for the intended number of items
         *  - Using any looping structure, assign to each element a random integer in the range 100 to 200. 
         *  You will need the following statement in global scope: static Random rand = new Random();
         *  The following statement will give you a random letter: rand.Next(100, 200);
         */
        static int[] CreateRandomIntArray (int arrayAmount)
        {
            int[] newRandomArray = new int[arrayAmount];

            for (int position = 0; position < arrayAmount; position++)
            {
                newRandomArray[position] = rand.Next(100, 200);
            }

            return newRandomArray;
        }
        #endregion
    }
}
