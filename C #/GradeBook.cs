using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
   public class GradeBook
    {
       public string CourseName { get; set; }
       public string InstructorName { get; set; }

       public GradeBook(string newCourseName, string newInstructorName)
       {
           CourseName = newCourseName;
           InstructorName = newInstructorName;
       }
       public void DisplayMessage()
        {
            Console.WriteLine("Welcome to the GradeBook for\n{0}! ", CourseName);
           
        }
    }
}
