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
            int average;
            total = 0;
            gradeCounter = 1;
            while (gradeCounter <= 10)
            {
                Console.Write("Enter grade: ");
                grade = Convert.ToInt32(Console.ReadLine());
                total = total + grade;
                gradeCounter = gradeCounter + 1;
            }
            average = total / 10;

            Console.WriteLine("\nTotal of all 10 grades is {0}", total);
            Console.WriteLine("Class Average is {0}", average);
        }
    }

}