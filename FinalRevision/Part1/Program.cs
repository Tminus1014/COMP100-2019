using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowMenu();
        }
        #region Question1
        static void DisplayPersonalInfo()
        {
            Console.WriteLine("Name: Trent B Minia");
            Console.WriteLine("School: Centennial College");
            Console.WriteLine("Favourite Course: COMP 100 ^_^");
        }
        #endregion

        #region Question2
        static void CalculateTuition()
        {
            Console.Write("Enter number of courses: ");
            int numberCourses = Convert.ToInt32(Console.ReadLine());

            const double courseCost = 569.99;
            double totalCost = numberCourses * courseCost;

            Console.WriteLine($"Total Cost: {totalCost:C}");
        }
        #endregion

        #region Question3
        static void CalculateAreaOfCircle()
        {
            Console.Write("Enter radius of circle: ");
            double radiusCircle = Convert.ToDouble(Console.ReadLine());
            double areaCircle = Math.PI * Math.Pow(radiusCircle, 2);
            Console.WriteLine($"Area of circle: {areaCircle:F2}");
        }
        #endregion

        #region Question4
        static void CalculateAreaOfTriangle()
        {
            Console.Write($"Enter base: ");
            double baseTriangle = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Enter height: ");
            double heightTriangle = Convert.ToDouble(Console.ReadLine());

            double areaTriangle = (baseTriangle * heightTriangle) / 2;

            Console.WriteLine($"Area of Triangle: {areaTriangle:F2}");
        }
        #endregion

        #region Question5
        static void CalculateSaleCommission()
        {
            Console.Write("Enter Sales Amount: $");
            double amountSales = Convert.ToDouble(Console.ReadLine());

            if (amountSales <= 1000.00)
            {
                Console.WriteLine("No commission available.");
            } else
            {
                double amountCommission = (amountSales - 1000) * 0.25;
                Console.WriteLine($"Commission Available: {amountCommission:C}");
            }
        }
        #endregion

        #region Question6
        static void DisplaySineTable()
        {
            Console.Write("Starting Value: ");
            double initialValue = Convert.ToDouble(Console.ReadLine());
            Console.Write("Incremental Value: ");
            double incrementValue = Convert.ToDouble(Console.ReadLine());

            for (double start = 1; start <= 10; start++)
            {
                double sineValue = Math.Sin(initialValue);
                Console.WriteLine($"{initialValue,5:F2}{sineValue,8:F4}");
                initialValue += incrementValue;
            }
        }
        #endregion

        #region Question7
        static void DisplayMenu()
        {
            Console.WriteLine("==========TM10's COOL COMP SYS==========");
            Console.WriteLine("=                                      =");
            Console.WriteLine("=   1. Display Personal Information    =");
            Console.WriteLine("=   2. Calculate Tuition               =");
            Console.WriteLine("=   3. Calculate Area of a Circle      =");
            Console.WriteLine("=   4. Calculate Area of a Triangle    =");
            Console.WriteLine("=   5. Calculate Sales Commission      =");
            Console.WriteLine("=   6. Display Sine Table              =");
            Console.WriteLine("=   0. End Program :(                  =");
            Console.WriteLine("=                                      =");
            Console.WriteLine("========================================");
            Console.Write("Make a Selection -> ");
        }
        #endregion

        #region Question8
        static void ShowMenu()
        {
            bool selection = true;
            string userSelection = "0";

            while (selection == true)
            {
                DisplayMenu();
                userSelection = Console.ReadLine();

                switch (userSelection) {
                    case "1":
                        DisplayPersonalInfo();
                        break;
                    case "2":
                        CalculateTuition();
                        break;
                    case "3":
                        CalculateAreaOfCircle();
                        break;
                    case "4":
                        CalculateAreaOfTriangle();
                        break;
                    case "5":
                        CalculateSaleCommission();
                        break;
                    case "6":
                        DisplaySineTable();
                        break;
                    case "0":
                        selection = false;
                        break;
                    default:
                        Console.WriteLine("ERROR: Invalid selection. Try again!");
                        break;
                }
            }
        }
        #endregion
    }
}
