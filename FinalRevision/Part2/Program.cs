using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Question1
            DisplayHorizontalStars(0);
            DisplayHorizontalStars(5);
            DisplayHorizontalStars(10);
            #endregion

            #region Question2
            DisplayVerticalStars(0);
            DisplayVerticalStars(5);
            DisplayVerticalStars(10);
            #endregion

            #region Question3
            VolumeSphere(1);
            VolumeSphere(2);
            VolumeSphere(10);
            #endregion

            #region Question4
            TaxPrice(10.00, "On");
            TaxPrice(1.00, "oN");
            TaxPrice(20.00, "qc");
            TaxPrice(100.00, "QC");
            TaxPrice(25.00, "BC");
            #endregion

            #region Question5
            TemperatureTable(0);
            TemperatureTable(50);
            TemperatureTable(95);
            #endregion

            #region Question6
            DistanceTable(10, 1, 5);
            DistanceTable(1, 0.50, 5);
            DistanceTable(10, 10, 5);
            #endregion

            #region Question7
            DisplaySineTable(0, 0.10, 5);
            DisplaySineTable(0.5, 0.05, 5);
            DisplaySineTable(1, 0.10, 5);

            #endregion

            #region Question8
            HeightTable(90);
            HeightTable(120);
            HeightTable(275);
            #endregion
        }
        #region Question1
        static void DisplayHorizontalStars(int numberOfStars)
        {
            for (int total = 0; total < numberOfStars; total++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        #endregion

        #region Question2
        static void DisplayVerticalStars(int numberOfStars)
        {
            for (int total = 0; total < numberOfStars; total++)
            {
                Console.WriteLine("*");
            }
            Console.WriteLine();
        }
        #endregion

        #region Question3
        static void VolumeSphere (double radius)
        {
            double volume = (Math.Pow(radius, 3) * Math.PI) * 4 / 3;
            Console.WriteLine($"Volume: {volume:F4}");
            Console.WriteLine();
        }
        #endregion

        #region Question4
        static void TaxPrice (double costPrice, string provinceCode)
        {
            const double ontarioTax = 0.13;
            const double quebecTax = 0.17;
            double taxCost = 0;
            
            Console.WriteLine($"Selling Price: {costPrice:C}");
            Console.Write($"Province: {provinceCode} /");
            
            provinceCode = provinceCode.ToUpper();

            Console.Write($" {provinceCode}\n");

            if (provinceCode == "ON")
            {
                taxCost = costPrice * ontarioTax;
            }
            else if (provinceCode == "QC")
            {
                taxCost = costPrice * quebecTax;
            }

            Console.WriteLine($"Tax Amount: {taxCost:C}");
            Console.WriteLine();
        }
        #endregion

        #region Question5
        static void TemperatureTable (double celsius)
        {
            double fahrenheit = 0;

            Console.WriteLine("Celsius      Fahrenheit");
            Console.WriteLine("=======      ==========");

            for (int start = 1; start <= 10; start++)
            {
                fahrenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine($"{celsius,7}{fahrenheit,16:F2}");
                celsius++;
            }
            Console.WriteLine();
        }
        #endregion

        #region Question6
        static void DistanceTable(double kilometres, double incrementSize, int numberLines)
        {
            double miles = 0;

            Console.WriteLine(" km      m  ");
            Console.WriteLine("====    ====");

            for (int start = 1; start <= numberLines; start++)
            {
                miles = kilometres * 0.621371;
                Console.WriteLine($"{kilometres,4:F2}{miles,8:F2}");

                kilometres += incrementSize;
            }

            Console.WriteLine();
        }
        #endregion

        #region Question7
        static void DisplaySineTable(double startValue, double incrementSize, int numberLines)
        {
            for (double start = 1; start <= numberLines; start++)
            {
                double sineValue = Math.Sin(startValue);
                Console.WriteLine($"{startValue,5:F2}{sineValue,8:F2}");
                startValue += incrementSize;
            }
            Console.WriteLine();
        }
        #endregion

        #region Question8
        static void HeightTable (int centimetre)
        {
            int convertedMetre = 0;
            int convertedCentimetre = 0;

            convertedMetre = centimetre / 100;
            convertedCentimetre = centimetre % 100;

            Console.WriteLine($"{centimetre,3}cm{convertedMetre,3}m{convertedCentimetre,3}cm");
            Console.WriteLine();
        }
        #endregion
    }
}