Console.WriteLine("Hello, World!");
/* wrong code

public class Product
{
    public string Type { get; set; }
    public double Price { get; set; }
}

public class TaxCalculator
{
    public double CalculateTax(Product product)
    {
        if (product.Type == "Electronic") return product.Price * 0.15;
        if (product.Type == "Food") return product.Price * 0.05;
        return 0;
    }
}
*/

//corrected code
public abstract class Product
{
    public double Price { get; set; }
    public abstract double CalculateTax();
}

public class Electronic : Product
{
    public override double CalculateTax() => Price * 0.15;
}

public class Food : Product
{
    public override double CalculateTax() => Price * 0.05;
}