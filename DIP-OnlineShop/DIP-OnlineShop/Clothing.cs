using DIP_OnlineShop;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace DIP_OnlineShop
{

    class Clothing : Product
    {
        public string Size;
        public string Material;
        public void ApplyDiscount()
        {
            FinalPrice = Discount.ApplyDiscount(Price);
        }
        public override void GetProductDetails()
        {
            Console.WriteLine("Information Product");
            Console.WriteLine($" Name :{Name}");

            Console.WriteLine($"Original Price : {Price}");
            Console.WriteLine($"Discounted Price : {FinalPrice}");


            Console.WriteLine($"Size : {Size}");
            Console.WriteLine($"Material : {Material}");
            Console.WriteLine("---------------------------------------");





        }

    }
}