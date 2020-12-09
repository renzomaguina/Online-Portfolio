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
            Gradebook myGradebook = new Gradebook("CS101 introduction to C# programming");

            myGradebook.DisplayMessage();

            myGradebook.DetermineClassAverage();
        }

        
    }
}
