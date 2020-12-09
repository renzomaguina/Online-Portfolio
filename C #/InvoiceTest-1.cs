using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
    class InvoiceTest
    {
        static void Main(string[] args)
        {
            string partNumber, partDescr;
            int qty;
            decimal price;

            Console.WriteLine("Please Enter Part Number");
            partNumber = Console.ReadLine();

            Console.WriteLine("Please Enter Part Description");
            partDescr = Console.ReadLine();

            Console.WriteLine("Please Enter Part Quantity");
            qty = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Please Enter Part Price");
             price = Convert.ToDecimal(Console.ReadLine());

             Invoice invoice = new Invoice( partNumber, partDescr, qty, price);

             Console.WriteLine("Your Order: ");
             Console.WriteLine("PartNumber: {0}", invoice.PartNumber);
             Console.WriteLine("PartDescription: {0}", invoice.PartDescr);
             Console.WriteLine("Quantity order: {0}", invoice.Qty);
             Console.WriteLine("Price per items: {0}", invoice.Price);
             Console.WriteLine("Total Price is: {0:C}", invoice.GetInvoice());

             Console.ReadLine();
        }
    }
}
