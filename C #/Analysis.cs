using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace analysis
{
   public class Analysis
    {
        public static void Main(string[] args)
        {
            int passes = 0;
            int faillure = 0;
            int studentCounter = 1;
            int result;
            while (studentCounter <= 10)
            {
                Console.Write("Enter result (1 = pass, 2 = fail): ");
                result = Convert.ToInt32(Console.ReadLine());

                if (result == 1)
                    passes = passes + 1;
                else
                    faillure = faillure + 1;


                studentCounter = studentCounter + 1;
            }
            Console.WriteLine("Passed: {0}\nFailled:{1}", passes, faillure);
            if (passes > 8)
                Console.WriteLine("Bonus To Instructor!");
        }
    }
}
