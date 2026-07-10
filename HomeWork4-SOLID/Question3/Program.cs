// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

//wrong code
/*

public class Bird
{
    public virtual void Fly() => Console.WriteLine("Flying...");
}

public class Ostrich : Bird
{
    public override void Fly() => throw new NotImplementedException("Ostriches can't fly!");
}

*/

public class Bird 
{
    public void Eat() => Console.WriteLine("Eating...");
}

public interface IFlyable
{
    void Fly();
}

public class Sparrow : Bird, IFlyable
{
    public void Fly() => Console.WriteLine("Sparrow flying...");
}

public class Ostrich : Bird 
{
    // No Fly method here, behavior remains intact
}