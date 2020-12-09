using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U5Graded1
{
   public class BasePlusCommisionEmployee : CommissionEmployee
    {
        private decimal baseSalary;//base salary per week
        //six-parameter derived class constructor
        //with call to base class commissionEmployee constructor
        public BasePlusCommisionEmployee(string first, string last, string ssn,
            decimal sales, decimal rate, decimal salary)
            : base (first, last, ssn, sales, rate)
        {
             BaseSalary = salary; // validate base salary via property
        }
    //end six-parameter BasePlusCommissionEmployee constructor
        //property that gets and sets
        //BasePlusCommissionEmployee's base salary
        public decimal BaseSalary
        {
        get
        {
            return baseSalary;
        }// end get
            set
            {
                if ( value >= 0)
                    baseSalary = value;
                else
                    throw new ArgumentOutOfRangeException( "BaseSalary",
                value, "baseSalary must be >= 0");
            }// end set
        }// end property BaseSalary

        //calculate earnings
        public override decimal Earnings()
        {
return baseSalary + base.Earnings();
        }// end method Ernings
        public override string ToString()
        {
return string.Format( "base-salaried {0}\nbase salary: {1:C}",
    base.ToString(), baseSalary);
        }//end method ToString

    }//end class BasePlusCommissionEmployee
}
