using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compare2strings
{
    class CompareString
    {
        static void Main(string[] args)
        {
            //declare the variable to store strings
            string string1;
            string string2;
            //variable that hold the result of the comparaison
            int r;
            //display message to the user
            Console.WriteLine("Please can you enter the first string?");
            string1 = Console.ReadLine();
            Console.WriteLine("Please can you enter the second string?");
            string2 = Console.ReadLine();
            //call method to compare to compare the strings and store
            r = string1.CompareTo(string2);
            //Display the strings to the the user
            Console.WriteLine("The first string is: {0}  The second string is: {1}", string1, string2);

            if (r == 0)
                //display that both string are equals
                Console.WriteLine("Both String are Equals");

            else if (r == -1)
                Console.WriteLine("The first string is greater than The second string");

            else if (r == 1)
                Console.WriteLine("The first string is greater than The second string");

        }
    }
}
