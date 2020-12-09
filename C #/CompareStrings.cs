// CIS317 Advanced Object Orieneted Programing Using C#
// Unit 1 Graded Excercise 1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class CompareStrings
    {
        static void Main(string[] args)
        {
        string s1;
        string s2;
        int m;

        Console.WriteLine("*****Compare Strings*****");
        Console.WriteLine("");

        Console.Write("Input the first string: ");
        s1 = Console.ReadLine();
        Console.WriteLine("");

        Console.Write("Input the second string: ");
        s2 = Console.ReadLine();
        Console.WriteLine("");

        m = s1.CompareTo(s2);

        Console.WriteLine("String 1: {0} string 2: {1}", s1, s2);
        Console.WriteLine("");

        if (m == 0)

            Console.WriteLine("Both strings are equal");
        else if (m == -1)

            Console.WriteLine("First string is greater than Second string");
        else if (m == 1)

            Console.WriteLine("First string is less than Second string");

        Console.ReadKey();
    }   // end Main
}   // end Class
