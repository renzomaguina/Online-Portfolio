using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradebook
{
    public class GradebookTest
    {
        public static void Main(string[] args)
        {
            Gradebook gradebook1 = new Gradebook("CS101 introduction to C# programming");
            Gradebook gradebook2 = new Gradebook("CS102 Data Structure in C#");

            Console.WriteLine("GradeBook1 course name is: {0}", gradebook1.CourseName);
            Console.WriteLine("GradeBook2 course name is: {0}", gradebook2.CourseName);
        }
    }
}
