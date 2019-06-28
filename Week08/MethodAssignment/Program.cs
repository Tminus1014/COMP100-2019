using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Menu User Input
            bool menuSelectionFlag = true;

            while (menuSelectionFlag == true)
            {
                // Display Menu
                DisplayMenu();
                Console.WriteLine();

                Console.Write("Make a Selection: ");
                string menuSelectionInput = Console.ReadLine();

                switch (menuSelectionInput)
                {
                    // Exit
                    case "0":
                        menuSelectionFlag = false;
                        break;
                    // CalculateSum
                    case "3":
                        Console.WriteLine();

                        int sumValue = CalculateSum(5);
                        Console.WriteLine($"Sum of all inputs: {sumValue}");

                        System.Threading.Thread.Sleep(2500);
                        Console.WriteLine();
                        break;
                    // CalculateSumOfSquares
                    case "4":
                        Console.WriteLine();

                        Console.Write("Enter # of values that will be entered: ");
                        int inputCount = Convert.ToInt32(Console.ReadLine());

                        sumValue = CalculateSumOfSquares(inputCount);
                        Console.WriteLine($"Sum of all squared inputs: {sumValue}");

                        System.Threading.Thread.Sleep(2500);
                        Console.WriteLine();
                        break;
                    // CalculateSumOfCubes
                    case "5":
                        Console.WriteLine();

                        sumValue = CalculateSumOfCubes();
                        Console.WriteLine($"Sum of all cubed inputs: {sumValue}");

                        System.Threading.Thread.Sleep(2500);
                        Console.WriteLine();
                        break;
                    // CalculateAverage
                    case "6":
                        Console.WriteLine();

                        double averageValue = CalculateAverage();
                        Console.WriteLine($"Calculated average: {averageValue}");

                        System.Threading.Thread.Sleep(2500);
                        Console.WriteLine();
                        break;
                    // DisplayEquation
                    case "7":
                        Console.WriteLine();
                        DisplayEquation();

                        System.Threading.Thread.Sleep(2500);
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine($"ERROR: Invalid Input. Try again");
                        System.Threading.Thread.Sleep(2500);
                        Console.WriteLine();
                        break;
                }
            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine("CALCULATION MENU");
            Console.WriteLine("================");
            Console.WriteLine("[3] Calculate Sum");
            Console.WriteLine("[4] Calculate Sum of Squares");
            Console.WriteLine("[5] Calculate Sum of Cubes");
            Console.WriteLine("[6] Calculate Average");
            Console.WriteLine("[7] Display Equation");
            Console.WriteLine("[0] Exit");
        }

        static int CalculateSum (int numberInputTotal)
        {
            int sumInputUser = 0;
            int sumInputTotal = 0;
            int numberInputCurrent = 1;

            while (numberInputCurrent <= numberInputTotal) {
                Console.Write($"Enter value {numberInputCurrent}: ");
                sumInputUser = Convert.ToInt32(Console.ReadLine());
                sumInputTotal += sumInputUser;

                numberInputCurrent++;
            }

            return sumInputTotal;
        }

        static int CalculateSumOfSquares (int numberInputTotal)
        {
            int sumInputUser = 0;
            int sumInputTotal = 0;
            int numberInputCurrent = 1;

            while (numberInputCurrent <= numberInputTotal)
            {
                Console.Write($"Enter value {numberInputCurrent}: ");
                sumInputUser = Convert.ToInt32(Console.ReadLine());
                sumInputTotal += sumInputUser * sumInputUser;

                numberInputCurrent++;
            }

            return sumInputTotal;
        }

        static int CalculateSumOfCubes ()
        {
            int sumInputUser = 0;
            int sumInputTotal = 0;
            int numberInputCurrent = 1;

            Console.Write("Enter # of values that will be entered: ");
            int numberInputTotal = Convert.ToInt32(Console.ReadLine());

            while (numberInputCurrent <= numberInputTotal)
            {
                Console.Write($"Enter value {numberInputCurrent}: ");
                sumInputUser = Convert.ToInt32(Console.ReadLine());
                sumInputTotal += sumInputUser * sumInputUser * sumInputUser;

                numberInputCurrent++;
            }

            return sumInputTotal;
        }

        static double CalculateAverage ()
        {
            double sumInputUser = 0;
            double sumInputTotal = 0;
            int numberInputCurrent = 1;

            Console.Write("Enter # of values that will be entered: ");
            int numberInputTotal = Convert.ToInt32(Console.ReadLine());

            while (numberInputCurrent <= numberInputTotal)
            {
                Console.Write($"Enter value {numberInputCurrent}: ");
                sumInputUser = Convert.ToInt32(Console.ReadLine());
                sumInputTotal += sumInputUser;

                numberInputCurrent++;
            }

            double averageInputTotal = sumInputTotal / numberInputTotal;

            return averageInputTotal;
        }

        static void DisplayEquation ()
        {
            Console.WriteLine("x     5     3x    -2x^2   y");
            Console.WriteLine("---   ---   ---   -----   ---");
            for (double firstColumn = 0; firstColumn <= 2; firstColumn += 0.25)
            {
                // Calculations
                const double secondColumn = 5;
                double thirdColumn = firstColumn * 3;
                double fourthColumn = -2 * Math.Pow(firstColumn, 2);
                double fifthColumn = secondColumn + thirdColumn + fourthColumn;

                // Display Table
                Console.WriteLine($"{firstColumn,0:F1}{secondColumn,6:F1}{thirdColumn,6:F1}{fourthColumn,7:F1}{fifthColumn,7:F1}");
            }
        }
    }
}
