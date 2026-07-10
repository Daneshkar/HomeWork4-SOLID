// wrong code
/*

public class Invoice
{
    public double Amount { get; set; }

    public double CalculateTotal() => Amount * 1.09; // Sub-responsibility 1: Calculation

    public void PrintInvoice() => Console.WriteLine("Printing invoice..."); // Sub-responsibility 2: Printing

    public void SaveToDatabase() => Console.WriteLine("Saving to DB..."); // Sub-responsibility 3: Persistence
}

*/

//corrected code

Console.WriteLine("Hello, World!");
public class Invoice
{
    public double Amount { get; set; }
    public double CalculateTotal() => Amount * 1.09;
}

public class InvoicePrinter
{
    public void Print(Invoice invoice) => Console.WriteLine("Printing invoice...");
}

public class InvoiceRepository
{
    public void Save(Invoice invoice) => Console.WriteLine("Saving to DB...");
}