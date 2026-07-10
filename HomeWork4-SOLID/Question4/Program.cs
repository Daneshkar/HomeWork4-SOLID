// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

/* wrong code
public interface IWorker
{
    void Work();
    void Eat();
}

public class Robot : IWorker
{
    public void Work() => Console.WriteLine("Working...");
    public void Eat() => throw new NotImplementedException(); // Violation
}

*/

//corrected code

public interface IWorkable
{
    void Work();
}

public interface IEatable
{
    void Eat();
}

public class Human : IWorkable, IEatable
{
    public void Work() => Console.WriteLine("Working...");
    public void Eat() => Console.WriteLine("Eating...");
}

public class Robot : IWorkable
{
    public void Work() => Console.WriteLine("Working...");
}