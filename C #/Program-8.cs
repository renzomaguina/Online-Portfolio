using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U1grade_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialize the variable
            int number1;
            int number2;


            Console.Write("Enter the first integer: "); //display a text
            number1 = Convert.ToInt32(Console.ReadLine());//ask for user input
             Console.Write("Enter the Second integer: ");//disply a line of text
            number2 = Convert.ToInt32(Console.ReadLine()); //input from the user

            if (number1 == number2)//if condition
                Console.WriteLine("{0} is equal {1}", number1, number2);//display the comparison

            if (number1 > number2)//if condition
                Console.WriteLine("{0} is Larger ", number1, number2);//display the comparison

            if (number1 < number2)//if condition
                Console.WriteLine("{0} is Lower ", number1, number2);//display the comparison
        }
    }
}
