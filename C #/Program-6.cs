using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U1grade2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int sum;
            int prod;
            int quot;
            int diff;

            Console.Write("Enter the first Integer: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second Integer: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            sum = number1 + number2;
            Console.WriteLine("Sum is {0}", sum);

            prod = number1 * number2;
            Console.WriteLine("Product is {0}", prod);


            diff = number1 - number2;
            Console.WriteLine("Difference is {0}", diff);


            quot = number1 / number2;
            Console.WriteLine("Quotient is {0}", quot);
        }
    }
}
