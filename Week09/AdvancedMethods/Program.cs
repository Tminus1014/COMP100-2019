using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //BrokenTest();
            //FixedTwice();
            TestOutput();
        }
        #region Example: OutDemo
        // Write a method to square and cube arg
        static void SquareAndCube(int a, out int s, out int c)
        {
            s = a * a;
            c = s * a;
        }
        //Write a meth to test above
        static void TestOutput()
        {
            int number = 2, square, cube;
            // Console.WriteLine($"Before {number} {square} {cube}");
            SquareAndCube(number, out square, out cube);
            Console.WriteLine($"After {number} {square} {cube}");
        }
        #endregion

        #region Example: FixedTwice
        // Write a meth that doubles its args
        static void Twice(ref int micheal)
        {
            micheal *= 2;
            Console.WriteLine($"In method {micheal}");
        }
        // Write a meth to call the above meth
        static void FixedTwice()
        {
            int mushfika = 500;
            Console.WriteLine($"Mefore method {mushfika}");
            Twice(ref mushfika);
            Console.WriteLine($"After method {mushfika}");
        }
        #endregion

        #region Example: BrokenTwice
        // Write a method that doubles its args
        static void BrokenTwice(int a)
        {
            a *= 2;
            Console.WriteLine($"In method {a}");
        }
        // Write a method to test the above method
        static void BrokenTest()
        {
            int rose = 100;
            Console.WriteLine($"Bethore method {rose}");
            BrokenTwice(rose);
            Console.WriteLine($"After method {rose}");
        }
        #endregion
    }

}
