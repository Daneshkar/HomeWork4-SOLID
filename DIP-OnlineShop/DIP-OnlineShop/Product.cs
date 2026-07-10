using System;
using System.Collections.Generic;
using System.Text;

namespace DIP_OnlineShop
{
    
        abstract class Product
        {

        
        public string Name;
            public double Price;
            public double FinalPrice;
        public IDiscount Discount;
        public abstract void GetProductDetails();


        }

    
}










