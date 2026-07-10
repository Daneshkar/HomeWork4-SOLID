
using DIP_OnlineShop;

using System.Net.Sockets;

class Program
{
    
    public static void Main()
    {

        Electronic TV1 = new Electronic();
        Electronic TV2 = new Electronic();

        Electronic iphone = new Electronic();
        Electronic samsung = new Electronic();
        Electronic nokiaPhone = new Electronic();

        Electronic AcerLaptop = new Electronic();

        Electronic hpLaptop = new Electronic();

        Clothing shirt = new Clothing();
        Clothing jacket = new Clothing();
        Clothing pants = new Clothing();
        Clothing shoes = new Clothing();

        shirt.Name = "Jean West";
        shirt.Price = 1200;
        shirt.Material = "cotton";
        shirt.Size = "XL";
        shirt.Discount = new FixedDiscount();
        jacket.Name = "Wool jacket";
        jacket.Price = 9780;
        jacket.Material = "Cotton";
        jacket.Size = "S";
        jacket.Discount = new FixedDiscount();
        pants.Name = "holiday";
        pants.Price = 1600;
        pants.Material = "Polyester";
        pants.Size = "S";
        pants.Discount = new FixedDiscount();
        shoes.Name = "Leather Mashhad";
        shoes.Price = 3200;
        shoes.Material = "Leather";
        shoes.Size = "38";
        shoes.Discount = new FixedDiscount();
        iphone.Name = "S5 samsung";
        iphone.WarrantyPeriod = 25;
        iphone.Price = 12000;
        iphone.Discount = new PercentageDiscount();

        samsung.Name = "samsung";
        samsung.WarrantyPeriod = 5;
        samsung.Price = 12040;
        samsung.Discount = new PercentageDiscount();
        nokiaPhone.Name = "iphone 6";
        nokiaPhone.WarrantyPeriod = 5;
        nokiaPhone.Price = 1200;
        nokiaPhone.Discount = new PercentageDiscount();
        AcerLaptop.Name = "hp";
        AcerLaptop.WarrantyPeriod = 48;
        AcerLaptop.Price = 582800;
        AcerLaptop.Discount = new PercentageDiscount();

        hpLaptop.Name = "acer";
        hpLaptop.WarrantyPeriod = 48;
        hpLaptop.Price = 10000;
        hpLaptop.Discount = new PercentageDiscount();

        TV1.Name = "LG";
        TV1.WarrantyPeriod = 24;
        TV1.Price = 12000;
        TV1.Discount = new PercentageDiscount();

        TV2.Name = "Xvision";
        TV2.WarrantyPeriod = 24;
        TV2.Price = 58700;
        TV2.Discount = new PercentageDiscount();

        List<Product> products = new List<Product>();

        products.Add(samsung);
        products.Add(nokiaPhone);
        products.Add(iphone);

        products.Add(AcerLaptop);
        products.Add(hpLaptop);
        products.Add(TV1);
        products.Add(TV2);

        products.Add(jacket);
        products.Add(shoes);
        products.Add(shirt);
        products.Add(pants);

        foreach (Product product in products)
        {

            Console.WriteLine($"Current Product: {product.Name}");
            if (product is Electronic electronic)
            {
                electronic.ApplyDiscount();
            }

            if (product is Clothing clothing)
            {
                clothing.ApplyDiscount();
            }

            product.GetProductDetails();

            Invoice invoice = new Invoice();
            invoice.ProductName = product.Name;
            invoice.FinalPrice = product.FinalPrice;

            invoice.PurchaseDate = DateTime.Now;
            invoice.PrintInvoice();


            EmailService email = new EmailService();
            email.SendEmail();

            

        }

        Console.ReadKey();

    }
}

