using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradebook
{
    public class Gradebook
    {

        public string CourseName { get; set; }
            public Gradebook(string name)
        {
                CourseName = name;
        }




        public void DisplayMessage()
        {
            Console.WriteLine("welcome to the grade book for\n{0}!", CourseName);
        }
        public void DetermineClassAverage()
        {
            int total;
            int gradeCounter;
            int grade;
            double average;
            total = 0;
            gradeCounter = 0;
            
            
                Console.Write("Enter grade or -1 to quit: ");
                grade = Convert.ToInt32(Console.ReadLine());

            while (grade != -1)
            {
                total = total + grade;
                gradeCounter = gradeCounter + 1;

                Console.Write("Enter grade or -1 to quit: ");
                grade = Convert.ToInt32(Console.ReadLine());
            }

            if (gradeCounter != 0)
            {
                average = (double) total / gradeCounter;



                Console.WriteLine("\nTotal of all {0} grades entered is {1}", gradeCounter, total);
                Console.WriteLine("Class Average is {0:F}", average);
            }
            else Console.WriteLine("No Grade were Entered");
        }
    }

}