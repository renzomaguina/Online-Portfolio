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
            Gradebook myGradebook = new Gradebook();
            Console.WriteLine("Initial course name is : '{0}'\n", myGradebook.courseName);
            Console.WriteLine("Please enter the course name: ");
            myGradebook.courseName = Console.ReadLine();
            Console.WriteLine();
            myGradebook.DisplayMessage();
        }
    }
}
