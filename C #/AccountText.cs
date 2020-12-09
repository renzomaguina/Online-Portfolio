using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    public class AccountText
    {
        public static void Main(string[] args )
        {
            Account account1 = new Account(50.00M);//create account object
            Account account2 = new Account(-7.53M);//create account object

            //display initial balance of each object using a property
            Console.WriteLine("account1 balance is: {0:C}", account1.Balance);//display balance property
            Console.WriteLine("account2 balance is: {0:C}", account2.Balance);//display balance property

            decimal depositAmount;//deposit amount read from user

            //pronpt and obtain user input
            Console.Write("Enter deposit amount for account1: ");
            depositAmount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("adding {0:C} to account balance\n", depositAmount);
            account1.Credit(depositAmount);//aad to account1 balance

                //display  balances
            Console.WriteLine("account1 balance is: {0:C}", account1.Balance);//display balance property
            Console.WriteLine("account2 balance is: {0:C}", account2.Balance);//display balance property

            //prompt and obtain user input
            Console.Write("Enter deposit amount for account2: ");
            depositAmount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("adding {0:C} to account balance\n", depositAmount);
            account2.Credit(depositAmount);//add to account1 balance

            //display balances
            Console.WriteLine("account1 balance: {0:C}", account1.Balance);
            Console.WriteLine("account2 balance: {0:C}", account2.Balance);

        }
    }
}
