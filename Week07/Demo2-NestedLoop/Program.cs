﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * A B C D E F G I J x 10
 */
namespace Demo2_NestedLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i ++)
            {
                for (char start = 'A', end = 'J'; start <= end; start++)
                {
                    Console.Write($"{start} ");
                }
                Console.WriteLine();
            }
        }
    }
}
