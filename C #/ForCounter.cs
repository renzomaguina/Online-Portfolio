﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forCounter
{
    public class ForCounter
    {
        public static void Main(string[] args)
        {
            //for statement header includes initialization,
            //loop-continuation condition and increment
            for(int counter = 1; counter <= 10; ++ counter)
                Console.WriteLine("{0}", counter);
            Console.WriteLine();
        }
    }
}
