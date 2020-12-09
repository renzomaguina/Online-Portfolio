using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingString
{
    class ComparingString
    {
        static void Main(string[] args)
        {
            string string1 = "hello";
            string string2 = "good bye";
            string string3 = "Happy Birthday";
            string string4 = "happy birthday";

            //output values of four strings
            Console.WriteLine("string1 = \"" + string1 + "\"" +
                "\nstring2 = \"" + string2 + "\"" +
                "\nstring3 = \"" + string3 + "\"" +
                "\nstring4 = \"" + string4 + "\"\n");

            //test for equality using Equals method
            if (string1.Equals("hello"))
                Console.WriteLine("string1 equalls \"hello\"");
            else
                Console.WriteLine("string1 does not equalls \"hello\"");

            //test for equality with ==
            if (string1 == "hello")
                Console.WriteLine("string1 equalls \"hello\"");
            else
                Console.WriteLine("string1 does not equalls \"hello\"");

            //test for equality comparing case
            if (string.Equals(string3, string4))
                Console.WriteLine("string3 equalls string4");
            else
                Console.WriteLine("string3 does not equalls string4");

            //test CompareTo
            Console.WriteLine("\nstring1.CompareTo( string2 ) is" +
                string1.CompareTo(string2) + "\n" +
                "string2.CompareTo(string1) is " +
                string2.CompareTo(string1) + "\n" +
                "string1.CompareTo(string1) is " +
                string1.CompareTo(string1) + "\n" +
                "string3.CompareTo(string4) is " +
                string3.CompareTo(string4) + "\n" +

                "string4.CompareTo(string3) is " +
                string4.CompareTo(string3) + "\n\n" );
        }//end main
    }//end class StringCompare
}
