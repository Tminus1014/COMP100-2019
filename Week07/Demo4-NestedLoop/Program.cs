using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 00 01 02 03 04 05 06 07 08 09
 * 10 11 12 13 14 15 16 17 18 19
 * 20 21 22 23 24 25 26 27 28 29
 * 30 31 32 33 34 35 36 37 38 39
 * 
 * 70 71 72 73 74 75 76 77 78 79
 * 80 81 82 83 84 85 86 87 88 89
 * 90 91 92 93 94 95 96 97 98 99
 * 
 */
namespace Demo4_NestedLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int row = 0; row < 10; row++)
            {
                for (int column = 0; column < 10; column++)
                {
                    if (row == column || row + column == 9)
                    {
                        Console.Write("   ");
                    }
                    else
                    {
                        Console.Write($"{row}{column} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
