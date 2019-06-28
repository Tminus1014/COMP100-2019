using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Question1
            int firstRawInt = 2,
                secondRawInt = 5;

            Console.WriteLine($"Int before DoubleIt: {firstRawInt}");
            DoubleIt(ref firstRawInt);
            Console.WriteLine($"Int after DoubleIt: {firstRawInt}");

            Console.WriteLine($"Int before DoubleIt: {secondRawInt}");
            DoubleIt(ref secondRawInt);
            Console.WriteLine($"Int after DoubleIt: {secondRawInt}");

            Console.WriteLine();
            #endregion

            #region Question2
            int thirdRawInt = 2,
                fourthRawInt = 5;

            Console.WriteLine($"Int before CubeIt: {thirdRawInt}");
            CubeIt(thirdRawInt, ref thirdRawInt);
            Console.WriteLine($"Int after CubeIt: {thirdRawInt}");

            Console.WriteLine($"Int before CubeIt: {fourthRawInt}");
            CubeIt(fourthRawInt, ref fourthRawInt);
            Console.WriteLine($"Int after CubeIt: {fourthRawInt}");

            Console.WriteLine();
            #endregion

            #region Question3
            double totalFees = 0;

            CalculateTuitionFee(5, 699.99, ref totalFees);
            Console.WriteLine($"# of Courses: 5 at $699.99 per course = {totalFees:C}");
            CalculateTuitionFee(5, 450.00, ref totalFees);
            Console.WriteLine($"# of Courses: 5 at $450.00 per course = {totalFees:C}");
            CalculateTuitionFee(6, 799.99, ref totalFees);
            Console.WriteLine($"# of Courses: 6 at $799.99 per course = {totalFees:C}");
            CalculateTuitionFee(4, 999.99, ref totalFees);
            Console.WriteLine($"# of Courses: 4 at $999.99 per course = {totalFees:C}");

            Console.WriteLine();
            #endregion

            #region Question4
            int resultSum = 0,
                resultDifference = 0;

            SumDifference(2, 4, ref resultSum, ref resultDifference);
            Console.WriteLine($"First Int: 2, Second Int: 4. Sum: {resultSum}, Difference: {resultDifference}");
            SumDifference(15, 10, ref resultSum, ref resultDifference);
            Console.WriteLine($"First Int: 15, Second Int: 10. Sum: {resultSum}, Difference: {resultDifference}");
            SumDifference(20, 20, ref resultSum, ref resultDifference);
            Console.WriteLine($"First Int: 20, Second Int: 20. Sum: {resultSum}, Difference: {resultDifference}");

            Console.WriteLine();
            #endregion

            #region Question5
            double sinOut, cosOut, tanOut;

            Console.WriteLine("  ANG           SIN           COS           TAN");
            Console.WriteLine("-------       -------       -------       -------");

            for (double degreesInput = 0; degreesInput <= 95; degreesInput += 5)
            {
                CalculateTrigValues(degreesInput, out sinOut, out cosOut, out tanOut);
                Console.WriteLine($"{degreesInput,7:F2}{sinOut,14:F4}{cosOut,14:F4}{tanOut,14:F4}");
            }

            Console.WriteLine();
            #endregion

            #region Question6
            double sinAngleOut, cosAngleOut;

            Console.WriteLine("  ANG           SIN           COS");
            Console.WriteLine("-------       -------       -------");

            for (double angleInput = 0.5; angleInput < 0.60; angleInput+= 0.01)
            {
                SineCosine(angleInput, out sinAngleOut, out cosAngleOut);
                Console.WriteLine($"{angleInput,7:F2}{sinAngleOut,14:F4}{cosAngleOut,14:F4}");
            }

            Console.WriteLine();
            #endregion
        }

        #region Question1
        static void DoubleIt(ref int x)
        {
            x *= 2;
        }
        #endregion

        #region Question2
        static void CubeIt(int x, ref int cube)
        {
            cube = x * x * x;
        }
        #endregion

        #region Question3
        static void CalculateTuitionFee(int numberOfCourses, double costPerCourse, ref double fees)
        {
            fees = numberOfCourses * costPerCourse + 15.25;
        }
        #endregion

        #region Question4
        static void SumDifference(int firstInt, int secondInt, ref int sum, ref int difference)
        {
            sum = firstInt + secondInt;
            if (firstInt < secondInt) {
                difference = secondInt - firstInt;
            } else
            {
                difference = firstInt - secondInt;
            }
        }
        #endregion

        #region Question5
        static void CalculateTrigValues(double degrees, out double sine, out double cosine, out double tangent)
        {
            sine = Math.Sin(degrees * Math.PI / 180);
            cosine = Math.Cos(degrees * Math.PI / 180);
            tangent = Math.Tan(degrees * Math.PI / 180);
        }
        #endregion

        #region Question6
        static void SineCosine(double angle, out double sine, out double cosine)
        {
            sine = Math.Sin(angle);
            cosine = Math.Cos(angle);
        }
        #endregion
    }
}
