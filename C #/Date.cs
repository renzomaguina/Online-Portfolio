using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace date
{
    public class Date
    {
         public int Month {get; set;}
         public int Day {get; set;}
        public int Year {get; set;}

        public Date(int m, int d, int y)
        {
            Month = m;
            Day = d;
            Year = y;

        }
        public void DisplayDate()
        {
            Console.WriteLine("{0}/ {1}/ {2}", Month, Day, Year);

        }
    }
}
