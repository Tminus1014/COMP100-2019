using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * A B C D E F G I J 
 */
namespace Demo1_NestedLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (char start = 'A', end = 'J'; start <= end; start ++)
            {
                Console.Write($"{start} ");
            }
        }
    }
}
