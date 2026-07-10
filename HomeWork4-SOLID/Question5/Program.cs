// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

/* wrong code
public class Engine
{
    public void Start() => Console.WriteLine("Engine started.");
}

public class Car
{
    private Engine _engine = new Engine(); // High coupling to concrete class

    public void Drive() => _engine.Start();
}

*/

//corrected code
public interface IEngine
{
    void Start();
}

public class PetrolEngine : IEngine
{
    public void Start() => Console.WriteLine("Petrol engine started.");
}

public class Car
{
    private readonly IEngine _engine;

    public Car(IEngine engine) // Depend on abstraction
    {
        _engine = engine;
    }

    public void Drive() => _engine.Start();
}