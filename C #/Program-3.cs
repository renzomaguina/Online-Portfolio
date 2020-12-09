using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U1guidepratice4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int sum;
            Console.Write("Enter the first integer:");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second integer:");
            number2 = Convert.ToInt32(Console.ReadLine());
            sum = number1 + number2;
            Console.WriteLine("Sum is {0}", sum);
        }
    }
}
