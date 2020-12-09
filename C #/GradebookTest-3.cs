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
            Console.WriteLine("Initial course Name is: '{0}'!", myGradebook.CourseName);

            Console.WriteLine("please enter the course name: ");
            myGradebook.CourseName = Console.ReadLine();
            Console.WriteLine();

            myGradebook.DisplayMessage();
        }
    }
}
