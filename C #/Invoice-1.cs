using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
    class Invoice
    {
        //private variable
        private int _qty;
        private decimal _price;
        public string PartNumber { get; set; }
        public string PartDescr { get; set; }

        //constructor
        public Invoice(string partNumber, string partDescr, int qty, decimal price)
        {
            PartNumber = partNumber;
            PartDescr = partDescr;
            Qty = qty;
            Price = price;

        }
        public int Qty
        {
            get { return _qty; }
            set
            {
                if (value > 0)
                    _qty = value;
                else
                    _qty = 1;
            }
        }
        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value > 0)

                    _price = value;
                else
                    _price = 1;
            }

        }

        public decimal GetInvoice()
        {
            return Qty * Price;
        }
            

        }
    
}
