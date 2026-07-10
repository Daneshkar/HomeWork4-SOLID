using System;
using System.Collections.Generic;
using System.Text;

namespace DIP_OnlineShop
{
    class FixedDiscount : IDiscount
    {
        public double ApplyDiscount(double price)
        {
            return price - 100;
        }
    }
}
