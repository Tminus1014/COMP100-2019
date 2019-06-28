using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            int side1;
            int side2;
            int side3;
            int side4;
            // Processing
            // Output
            int perimeter;
            // Algorithm
            Console.Write("Enter first side: ");
            side1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second side: ");
            side2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third side: ");
            side3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter fourth side: ");
            side4 = Convert.ToInt32(Console.ReadLine());
            perimeter = side1 + side2 + side3 + side4;
            Console.WriteLine($"The perimeter is: {perimeter}");
        }
    }
}
