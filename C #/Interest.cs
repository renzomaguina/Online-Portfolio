using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interest
{
    public class Interest
    {
        public static void Main(string[] args)
        {
            decimal amount;
            decimal principal = 1000;
            double rate = 0.05;

            Console.WriteLine("year{0,20}", "Amount on deposit");

            for (int year = 1; year <= 10; ++year)
            {
                amount = principal * ((decimal)Math.Pow(1.0 + rate, year));

                Console.WriteLine("{0,4} {1,20:C}", year, amount );
            }
        }
    }
}
