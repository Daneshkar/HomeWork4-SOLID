using System;
using System.Collections.Generic;
using System.Text;

namespace DIP_OnlineShop
{
    class PercentageDiscount :IDiscount
    {
        public double ApplyDiscount(double price)
        {
            double discountPercent = 20;
            return price - (price * discountPercent / 100);


        }
    }
}