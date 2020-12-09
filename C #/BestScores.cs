// Unit 5 Graded Excercise
// Array Manipulations

using System;

namespace BestScores
{

    public class BestScores
    {
        public static void Main(string[] args)
        {
            // initializer list specifies the value for each element
            int[] array = { 80, 85, 90, 95, 60 };

            Console.WriteLine("{0}{1,8}", "Index", "Value"); // headings

            // output each array element's value
            for (int bestScores = 0; bestScores < array.Length; ++bestScores)
                Console.WriteLine("{0,5}{1,8}", bestScores, array[bestScores]);
        } // end Main
    } // end class InitArray
}