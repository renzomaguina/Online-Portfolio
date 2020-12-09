using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u5_guided
{
    class Array
    {
        static void Main(string[] args)
        {
            int[] bestScore = { 80, 85, 90, 95, 60 };

            Console.WriteLine("{0} {1,3}", "index", "value");

            // output each array element's value
            for (int counter = 0; counter < bestScore.Length; ++counter)
                Console.WriteLine("{0,5}  {1,5}", counter, bestScore[counter]);
        }//end main
    }//end class initArray
}
