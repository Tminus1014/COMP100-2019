using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            switch (year)
            {
                case 1:
                    Console.WriteLine($"Year {year} is a Freshman");
                    break;
                case 2:
                    Console.WriteLine($"Year {year} is a Sophomore");
                    break;
                case 3:
                    Console.WriteLine($"Year {year} is a Junior");
                    break;
                case 4:
                    Console.WriteLine($"Year {year} is a Senior");
                    break;
                default:
                    Console.WriteLine($"??? {year} is unknown");
                    break;
            }
        }
    }
}
