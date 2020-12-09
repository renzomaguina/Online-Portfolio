using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradebook
{
    public class Gradebook
    {
        private string courseName;

        public string CourseName
        {
            get
            {
                return courseName;
            }

            set
            {
                courseName = value;
            }
        }




        public void DisplayMessage()
        {
            Console.WriteLine("welcome to the grade book for\n{0}!", CourseName);
        }
    }

}