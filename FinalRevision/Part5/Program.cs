using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Question1
            int[] arrayQuestionOne = { 1, 2, 9, 8, 3, 4, 7, 6, 5 };
            DisplayIntArray(arrayQuestionOne);

            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region Question2
            int[] arrayQuestionTwoCallOne = GenerateRandomIntArray(15, 10);
            DisplayIntArray(arrayQuestionTwoCallOne);
            Console.WriteLine();

            int[] arrayQuestionTwoCallTwo = GenerateRandomIntArray(25, 10);
            DisplayIntArray(arrayQuestionTwoCallTwo);
            Console.WriteLine();

            int[] arrayQuestionTwoCallThree = GenerateRandomIntArray(30, 100);
            DisplayIntArray(arrayQuestionTwoCallThree);
            Console.WriteLine();

            Console.WriteLine();
            #endregion

            #region Question3
            int[] arrayQuestionThreeOne = GenerateRandomIntArray(10, 100);
            DisplayIntArray(arrayQuestionThreeOne);
            Console.WriteLine();
            int[] arrayQuestionThreeTwo = CountEvenOdd(arrayQuestionThreeOne);
            DisplayIntArray(arrayQuestionThreeTwo);
            Console.WriteLine();

            Console.WriteLine();
            #endregion

            #region Question4
            int[] arrayQuestionFourOne = GenerateRandomIntArray(10, 10);
            DisplayIntArray(arrayQuestionFourOne);
            Console.WriteLine();
            int[] arrayQuestionFourTwo = CalculateDigitFrequencies(arrayQuestionFourOne);
            DisplayIntArray(arrayQuestionFourTwo);
            Console.WriteLine();

            Console.WriteLine();
            #endregion

            #region Question5
            int[] arrayQuestionFiveOne = GenerateRandomIntArray(10, 100);
            DisplayIntArray(arrayQuestionFiveOne);
            Console.WriteLine();
            int[] arrayQuestionFiveTwo = CalculateLastDigitFrequencies(arrayQuestionFiveOne);
            DisplayIntArray(arrayQuestionFiveTwo);
            Console.WriteLine();

            Console.WriteLine();
            #endregion

            #region Question6
            int[] arrayQuestionSixOne = GenerateRandomIntArray(10, 100);
            DisplayIntArray(arrayQuestionSixOne);
            Console.WriteLine();
            int[] arrayQuestionSixTwo = CalculateNumberFrequencies(arrayQuestionSixOne);
            DisplayIntArray(arrayQuestionSixTwo);
            Console.WriteLine();

            Console.WriteLine();
            #endregion
        }
        #region Question1
        static void DisplayIntArray(int[] numbers)
        {
            foreach (int x in numbers)
            {
                Console.Write($"{x} ");
            }
        }
        #endregion

        #region Question2
        static int[] GenerateRandomIntArray(int numberOfItems, int largestValue)
        {
            Random generate = new Random();
            int[] newArray = new int[numberOfItems];

            for (int position = 0; position < numberOfItems; position++)
            {
                newArray[position] = generate.Next(largestValue);
            }

            return newArray;
        }
        #endregion

        #region Question3
        static int[] CountEvenOdd(int[] array)
        {
            int evens = 0, odds = 0;

            foreach (int x in array)
            {
                if (x % 2 == 0)
                {
                    evens++;
                } else
                {
                    odds++;
                }
            }

            int[] result =
            {
                odds,
                evens
            };

            return result;
        }
        #endregion

        #region Question4
        static int[] CalculateDigitFrequencies(int[] array)
        {
            int zeros = 0,
                ones = 0,
                twos = 0,
                threes = 0,
                fours = 0,
                fives = 0,
                sixs = 0,
                sevens = 0,
                eights = 0,
                nines = 0;

            foreach (int x in array)
            {
                switch (x) {
                    case 0:
                        zeros++;
                        break;
                    case 1:
                        ones++;
                        break;
                    case 2:
                        twos++;
                        break;
                    case 3:
                        threes++;
                        break;
                    case 4:
                        fours++;
                        break;
                    case 5:
                        fives++;
                        break;
                    case 6:
                        sixs++;
                        break;
                    case 7:
                        sevens++;
                        break;
                    case 8:
                        eights++;
                        break;
                    case 9:
                        nines++;
                        break;
                }
            }

            int[] result =
                {
                    zeros,
                    ones,
                    twos,
                    threes,
                    fours,
                    fives,
                    sixs,
                    sevens,
                    eights,
                    nines
                };

            return result;
        }
        #endregion

        #region Question5
        static int[] CalculateLastDigitFrequencies(int[] array)
        {
            int zeros = 0,
                ones = 0,
                twos = 0,
                threes = 0,
                fours = 0,
                fives = 0,
                sixs = 0,
                sevens = 0,
                eights = 0,
                nines = 0;

            foreach (int x in array)
            {
                switch (x % 10)
                {
                    case 0:
                        zeros++;
                        break;
                    case 1:
                        ones++;
                        break;
                    case 2:
                        twos++;
                        break;
                    case 3:
                        threes++;
                        break;
                    case 4:
                        fours++;
                        break;
                    case 5:
                        fives++;
                        break;
                    case 6:
                        sixs++;
                        break;
                    case 7:
                        sevens++;
                        break;
                    case 8:
                        eights++;
                        break;
                    case 9:
                        nines++;
                        break;
                }
            }

            int[] result =
                {
                    zeros,
                    ones,
                    twos,
                    threes,
                    fours,
                    fives,
                    sixs,
                    sevens,
                    eights,
                    nines
                };

            return result;
        }
        #endregion

        #region Question6
        static int[] CalculateNumberFrequencies(int[] array)
        {
            int firstRange = 0,   // 0-9
                secondRange = 0,  // 10-19
                thirdRange = 0,   // 20-29
                fourthRange = 0,  // 30-39
                fifthRange = 0,   // 40-49
                sixthRange = 0,   // 50-59
                seventhRange = 0, // 60-69
                eighthRange = 0,  // 70-79
                ninthRange = 0,   // 80-89
                tenthRange = 0;   // 90-99

            foreach (int x in array)
            {
                if (x >= 0 && x <= 9)
                {
                    firstRange++;
                }
                else if (x >= 10 && x <= 19)
                {
                    secondRange++;
                }
                else if (x >= 20 && x <= 29)
                {
                    thirdRange++;
                }
                else if (x >= 30 && x <= 39)
                {
                    fourthRange++;
                }
                else if (x >= 40 && x <= 49)
                {
                    fifthRange++;
                }
                else if (x >= 50 && x <= 59)
                {
                    sixthRange++;
                }
                else if (x >= 60 && x <= 69)
                {
                    seventhRange++;
                }
                else if (x >= 70 && x <= 79)
                {
                    eighthRange++;
                }
                else if (x >= 80 && x <= 89)
                {
                    ninthRange++;
                }
                else if (x >= 90 && x <= 99)
                {
                    tenthRange++;
                }
            }

            int[] result =
                {
                    firstRange,
                    secondRange,
                    thirdRange,
                    fourthRange,
                    fifthRange,
                    sixthRange,
                    seventhRange,
                    eighthRange,
                    ninthRange,
                    tenthRange
                };

            return result;
        }
        #endregion
    }
}