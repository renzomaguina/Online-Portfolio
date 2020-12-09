using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales
{
   public class Sales
    {
        static void Main(string[] args)
        {
            double product1 = 0; // amount sold of first product
            double product2 = 0; // amount sold of second product
            double product3 = 0; // amount sold of third product
          
            int productId = 1; // current product id number
       
            // ask user for product number until flag value entered
            while (productId != 0)
            {
                // determine the product chosen
                Console.Write(
                "Enter product number (1-3) (0 to stop): ");
                productId = Convert.ToInt32(Console.ReadLine());

                if (productId >= 1 && productId <= 3)
                {
                    // determine the number sold of the item
                    Console.Write("Enter quantity sold: ");
                    int quantity = Convert.ToInt32(Console.ReadLine());

                    // increment the total for the item by the
                    // price times the quantity sold using a switch multiple selection statement.
                    switch (productId)
                    {
                        case 1:
                            product1 += 2.98 * quantity;
                            break;
                        case 2:
                            product2 += 4.50 * quantity;
                            break;
                        case 3:
                            product3 += 9.98 * quantity;
                            break;
                        default:
                            Console.WriteLine("Wrong ID number");
                            break;
                    }

            } // end if
                else if (productId != 0)
                    Console.WriteLine(
                    "Product number must be between 1 and 3 or 0 to stop");
            } // end while

            // display summary
            Console.WriteLine("\nProduct 1: {0:C}", product1);
            Console.WriteLine("Product 2: {0:C}", product2);
            Console.WriteLine("Product 3: {0:C}", product3);
            
        }
    }
}
