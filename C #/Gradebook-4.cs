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
    }

}