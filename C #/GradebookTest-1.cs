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
            Console.WriteLine("please enter the course name: ");
            string nameOfCourse = Console.ReadLine();
            Console.WriteLine();
            myGradebook.DisplayMessage(nameOfCourse);
        }
    }
}
