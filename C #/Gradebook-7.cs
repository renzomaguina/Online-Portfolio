using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradebook
{
    public class Gradebook
    {
        private int total;
        private int gradeCounter;
        private int acount;
        private int bcount;
        private int ccount;
        private int dcount;
        private int fcount;


        public string CourseName { get; set; }
            public Gradebook(string name)
        {
                CourseName = name;
        }




        public void DisplayMessage()
        {
            Console.WriteLine("welcome to the grade book for\n{0}!", CourseName);
        }
        public void inputGrade()
        { 
            int grade;
            string input;
       
            
            
                Console.WriteLine("{0}\n{1}", "Enter the integer grade in the range of 0-100.",
                    "Type <Ctrl> z and press Enter to terminate input: ");
                input = Console.ReadLine();

            while (input != null)
            {
                grade = Convert.ToInt32(input);
                total += grade;
                ++gradeCounter;

                //call method to increment appropriate counter
                IncrementLetterGradeCounter(grade);

                input = Console.ReadLine();
            }

        }
        private void IncrementLetterGradeCounter(int grade)
        {
            switch (grade / 10)
            {
                case 9:
                case 10:
                    ++acount;
                    break;
                case 8:
                    ++bcount;
                    break;
                case 7:
                    ++ccount;
                    break;
                case 6:
                    ++dcount;
                    break;
                default:
                    ++fcount;
                    break;
            }
        }
        
        public void DisplayGradeReport()
        {
            Console.WriteLine("\nGrade Report: ");

            if (gradeCounter != 0)
            {
                double average = (double)total / gradeCounter;

                Console.WriteLine("Total of the {0} grade entered is {1}", gradeCounter, total);
                Console.WriteLine("Class Average is {0:F}", average);
                Console.WriteLine("{0}A: {1}\nB: {2}\nC: {3}\nD: {4}\nF: {5}",
                    "Number of students who received each grade: \n", acount, bcount, ccount, dcount, fcount);
            }
            else
                Console.WriteLine("No grade were Entered");
        }
        
        
    }
   

}