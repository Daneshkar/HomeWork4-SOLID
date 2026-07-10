using System;
using System.Collections.Generic;
using System.Text;

namespace DIP_OnlineShop
{
  class EmailService:IEmailService
    {
        public void SendEmail()
        {
            Console.WriteLine("Confirmation email sent.");
        }
    }
}
