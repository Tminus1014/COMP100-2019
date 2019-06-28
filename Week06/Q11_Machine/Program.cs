using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 11.	A machine purchased for $28,000 depreciates at a rate of $4,000 a year for seven years. Write and run a C# program that computes and displays a depreciation table for seven years. 
 */
namespace Q11_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 1, endYearValue = 24000, accumulatedDepreciation = 4000;
            const int depreciation = 4000;

            Console.WriteLine("                            End-of-Year      Accumulated");
            Console.WriteLine("Year        Depreciation       Value        Depreciation");
            Console.WriteLine("----        ------------    -----------     ------------");

            do
            {
                Console.WriteLine($"{year,2}{depreciation,18}{endYearValue,15}{accumulatedDepreciation,17}");

                endYearValue -= depreciation;
                accumulatedDepreciation += depreciation;
                year++;
            } while (year <= 7);

            Console.WriteLine();

        }
    }
}
