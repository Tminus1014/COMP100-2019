using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Question1
            Console.WriteLine($"The difference between 3 and 5 is {CalculateDifference(3,5)}");
            Console.WriteLine($"The difference between 13 and 5 is {CalculateDifference(13,5)}");
            Console.WriteLine($"The difference between 23 and 5 is {CalculateDifference(23, 5)}");
            Console.WriteLine($"The difference between 23 and 23 is {CalculateDifference(23,23)}");
            Console.WriteLine();
            #endregion

            #region Question2
            Console.WriteLine("Current: 1.00A");
            Console.WriteLine("Resistance: 1.50ohms");
            Console.WriteLine($"Power: {CalculatePower(1, 1.5):F2}W");
            Console.WriteLine();
            Console.WriteLine("Current: 0.10A");
            Console.WriteLine("ResustabceL 100.00ohms");
            Console.WriteLine($"Power: {CalculatePower(0.1, 100):F2}W");
            Console.WriteLine();
            #endregion

            #region Question3
            Console.WriteLine("# of Courses: 1");
            Console.WriteLine("Cost per Course: $500.00");
            Console.WriteLine($"Tuition Fee: {CalculateTuitionFee(1,500):C}");
            Console.WriteLine();
            Console.WriteLine("# of Courses: 2");
            Console.WriteLine("Cost per Course: $450.00");
            Console.WriteLine($"Tuition Fee: {CalculateTuitionFee(2, 450):C}");
            Console.WriteLine();
            Console.WriteLine("# of Courses: 4");
            Console.WriteLine("Cost per Course: $100.00");
            Console.WriteLine($"Tuition Fee: {CalculateTuitionFee(4, 100):C}");
            Console.WriteLine();
            Console.WriteLine("# of Courses: 5");
            Console.WriteLine("Cost per Course: none provided");
            Console.WriteLine($"Tuition Fee: {CalculateTuitionFee(5):C}");
            #endregion

            #region Question4
            Console.WriteLine("Sale Amount: $900.00");
            Console.WriteLine($"Commission: {CalculateCommission(900):C}");
            Console.WriteLine();
            Console.WriteLine("Sale Amount: $1000.00");
            Console.WriteLine($"Commission: {CalculateCommission(1000):C}");
            Console.WriteLine();
            Console.WriteLine("Sale Amount: $2000.00");
            Console.WriteLine($"Commission: {CalculateCommission(2000):C}");
            Console.WriteLine();
            #endregion

            #region Question5
            //double burgerCostOne = BurgerCost();
            //Console.WriteLine($"Total Cost: {burgerCostOne:C}");
            //Console.WriteLine();
            //double burgerCostTwo = BurgerCost();
            //Console.WriteLine($"Total Cost: {burgerCostTwo:C}");
            //Console.WriteLine();
            #endregion

            #region Question6
            Console.WriteLine("Mass of Earth: 5.972e+024");
            Console.WriteLine("Mass of Moon: 7.348e+022");
            Console.WriteLine("Distance: 3.844e+008");
            double forceEarthMoon = CalculateGravitationalAttraction(5.972e+024, 7.348e+022, 3.844e+008);
            Console.WriteLine($"Force: {forceEarthMoon}");
            Console.WriteLine();
            #endregion

            #region Question7
            double areaTriangle = CalculateAreaTriangle(5.83, 4.24, 8.00);
            Console.WriteLine($"Area of Triangle: {areaTriangle:F2}");
            Console.WriteLine();
            #endregion

            #region Question8
            Console.WriteLine($"C: 0     F: {ConvertCelsiusToFahrenheit(0):F2}");
            Console.WriteLine($"C: 50    F: {ConvertCelsiusToFahrenheit(50):F2}");
            Console.WriteLine($"C: 100   F: {ConvertCelsiusToFahrenheit(100):F2}");
            Console.WriteLine();
            #endregion

            #region Question9
            Console.WriteLine($"F: 0     C: {ConvertFahrenheitToCelsius(0):F2}");
            Console.WriteLine($"F: 32    C: {ConvertFahrenheitToCelsius(32):F2}");
            Console.WriteLine($"F: 212   C: {ConvertFahrenheitToCelsius(212):F2}");
            Console.WriteLine();
            #endregion

            #region Question10
            Console.WriteLine($"C: -196 K: {ConvertCelsiusToKelvin(-196):F2}");
            Console.WriteLine($"C: 0    K: {ConvertCelsiusToKelvin(0):F2}");
            Console.WriteLine($"C: 100  K: {ConvertCelsiusToKelvin(100):F2}");
            Console.WriteLine();
            #endregion

            #region Question11
            Console.WriteLine($"F: -196 K: {ConvertFahrenheitToKelvin(-196):F2}");
            Console.WriteLine($"F: 0    K: {ConvertFahrenheitToKelvin(0):F2}");
            Console.WriteLine($"F: 100  K: {ConvertFahrenheitToKelvin(100):F2}");
            Console.WriteLine();
            #endregion
        }

        #region Question1
        static int CalculateDifference (int firstNumber, int secondNumber)
        {
            int largerNumber, smallerNumber;

            if (firstNumber >= secondNumber)
            {
                largerNumber = firstNumber;
                smallerNumber = secondNumber;
            } else
            {
                largerNumber = secondNumber;
                smallerNumber = firstNumber;
            }

            int difference = largerNumber - smallerNumber;

            return difference;
        }
        #endregion

        #region Question2
        static double CalculatePower(double current, double resistance)
        {
            double power = Math.Pow(current, 2) * resistance;
            return power;
        }
        #endregion

        #region Question3
        static double CalculateTuitionFee (int numberOfCourses, double costPerCourse = 449.99)
        {
            double fees = numberOfCourses * costPerCourse + 15.25;
            return fees;
        }
        #endregion

        #region Question4
        static double CalculateCommission (double saleAmount)
        {
            double commission = 0;

            if (saleAmount > 1000)
            {
                commission = saleAmount * 0.01;
            }

            return commission;
        }
        #endregion

        #region Question5
        static double BurgerCost()
        {
            Console.Write("# of Burgers: ");
            int amountBurgers = Convert.ToInt32(Console.ReadLine());

            double cost = amountBurgers * 1.39;

            return cost;
        }
        #endregion

        #region Question6
        static double CalculateGravitationalAttraction(double firstMass, double secondMass, double distance)
        {
            const double gravity = 6.673e-11;

            double force = gravity * (firstMass * secondMass) / Math.Pow(distance, 2);

            return force;
        }
        #endregion

        #region Question7
        static double CalculateAreaTriangle (double sideA, double sideB, double sideC)
        {
            double totalSide = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(totalSide * (totalSide - sideA) * (totalSide - sideB) * (totalSide - sideC));
            return area;
        }
        #endregion

        #region Question8
        static double ConvertCelsiusToFahrenheit (double celsius)
        {
            double fahrenheit = (celsius * 9 / 5) + 32;
            return fahrenheit;
        }
        #endregion

        #region Question9
        static double ConvertFahrenheitToCelsius (double fahrenheit)
        {
            double celsius = (fahrenheit - 32) * 5 / 9;
            return celsius;
        }
        #endregion

        #region Question10
        static double ConvertCelsiusToKelvin (double celsius)
        {
            double kelvin = celsius + 273.15;
            return kelvin;
        }
        #endregion

        #region Question11
        //fahrenheit -> celsius -> kelvin

        static double ConvertFahrenheitToKelvin (double fahrenheit)
        {
            double celsius = ConvertFahrenheitToCelsius(fahrenheit);
            double kelvin = ConvertCelsiusToKelvin(celsius);
            return kelvin;
        }
        #endregion
    }
}
