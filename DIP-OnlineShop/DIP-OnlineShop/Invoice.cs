using System;
using System.Collections.Generic;
using System.Text;

namespace DIP_OnlineShop
{
     class Invoice
    {

        public string ProductName;
        public double FinalPrice;
        public DateTime PurchaseDate;

        public void PrintInvoice()
        {
            Console.WriteLine("------ Invoice ------");
            Console.WriteLine($"Product : {ProductName}");
            Console.WriteLine($"Price : {FinalPrice}");
            Console.WriteLine($"Date : {PurchaseDate}");
        }
    }
}
