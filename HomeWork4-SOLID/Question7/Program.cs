using System;

// Abstractions (Interfaces)
public interface IDiscountStrategy
{
    double CalculateDiscount(double price);
}

public interface IEmailService
{
    void SendConfirmation(string customerEmail, string message);
}

// Concrete Implementations of Discount
public class PercentageDiscount : IDiscountStrategy
{
    private readonly double _percentage;
    public PercentageDiscount(double percentage) => _percentage = percentage;

    public double CalculateDiscount(double price) => price * (_percentage / 100);
}

public class FixedAmountDiscount : IDiscountStrategy
{
    private readonly double _amount;
    public FixedAmountDiscount(double amount) => _amount = amount;

    public double CalculateDiscount(double price) => _amount;
}

// Concrete Implementation of Email Service
public class EmailService : IEmailService
{
    public void SendConfirmation(string customerEmail, string message)
    {
        Console.WriteLine($"Email sent to {customerEmail}: {message}");
    }
}

// Product Model
public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }
}

// High-Level Module complying with DIP
public class OrderProcessor
{
    private readonly IDiscountStrategy _discountStrategy;
    private readonly IEmailService _emailService;

    // Dependencies are injected here (Constructor Injection)
    public OrderProcessor(IDiscountStrategy discountStrategy, IEmailService emailService)
    {
        _discountStrategy = discountStrategy;
        _emailService = emailService;
    }

    public void ProcessOrder(Product product, string customerEmail)
    {
        double discount = _discountStrategy.CalculateDiscount(product.Price);
        double finalPrice = product.Price - discount;

        Console.WriteLine($"--- Simple Invoice ---");
        Console.WriteLine($"Product: {product.Name}");
        Console.WriteLine($"Original Price: ${product.Price:F2}");
        Console.WriteLine($"Discount Applied: ${discount:F2}");
        Console.WriteLine($"Final Paid: ${finalPrice:F2}");
        Console.WriteLine($"----------------------");

        string message = $"Thank you for buying {product.Name}! Total paid: ${finalPrice:F2}";
        _emailService.SendConfirmation(customerEmail, message);
    }
}

// Execution Example
class Program
{
    static void Main()
    {
        Product laptop = new Product("Gaming Laptop", 1000.0);
        
        // We can easily switch strategies or email services here without changing OrderProcessor code
        IDiscountStrategy discount = new PercentageDiscount(15); // 15% discount
        IEmailService emailService = new EmailService();

        OrderProcessor processor = new OrderProcessor(discount, emailService);
        processor.ProcessOrder(laptop, "user@example.com");
    }
}