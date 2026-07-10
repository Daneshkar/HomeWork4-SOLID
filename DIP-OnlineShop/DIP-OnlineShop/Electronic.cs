using System;
using System.Collections.Generic;
using System.Text;

namespace DIP_OnlineShop
{

    class Electronic : Product
    {
        public int WarrantyPeriod;
        public override void GetProductDetails()
        {
            Console.WriteLine(" Information Product ");
            Console.WriteLine($" Name : {Name} ");
            Console.WriteLine($" Warranty Period : {WarrantyPeriod}");
            Console.WriteLine($"Orginal Price : {Price}");
            Console.WriteLine($"DiscountedPrice :{FinalPrice} ");
            Console.WriteLine("---------------------------------------");



        }

        public void ApplyDiscount()

        {

            FinalPrice = Discount.ApplyDiscount(Price);

        }

    }
}


