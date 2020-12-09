// Unit 5 Guided Practice 3
// Sum the Elements of an Array

using System;

namespace SumArray
{
    public class SumArray
    {
        public static void Main ( string[] args )
        {
            int[] array = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87 };
            int total = 0;

            // add each element's value to total
            for (int counter = 0; counter < array.Length; ++counter)
                total += array[counter];

            Console.WriteLine("Total array of elements: {0}", total);
        } // end Main
    } // end class SumArray
}
