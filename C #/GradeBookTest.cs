using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public class GradeBookTest
    {
        public static void Main(string[] agrs)
        {
            // create GradeBook object
            GradeBook gradeBook1 = new GradeBook(
               "CS101 Introduction to C# Programming", "Sam Smith");

            gradeBook1.DisplayMessage(); // display welcome message

            Console.WriteLine("\nThis course is presented by: Judy Jones\n");
            gradeBook1.InstructorName = "Judy Jones";
        }
           
    }
}
