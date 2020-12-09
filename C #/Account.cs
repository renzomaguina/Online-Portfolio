using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    public class Account
    {
        private decimal balance; //instance variable that stores the balance
                                 //constructor
        public Account(decimal initialBalance)
        {
            Balance = initialBalance;
        }//end Account constructor
        public void Credit(decimal amount)
        {
            Balance = Balance + amount; //add amount to balance
        }//end method credit

        //a property to get and set the account balance
        public decimal Balance
        {
            get
            {
                return balance;
            }//end get
            set
            {
                //validate that value is greater than or equal to 0;
                //if it is not, balance is left unchaged
                if (value >= 0)
                    balance = value;
            }//end set
        }//end property value

    }//end class Account
}
