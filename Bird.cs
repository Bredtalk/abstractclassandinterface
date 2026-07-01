namespace abstractclassandinterface;

public class Bird : IFly
{
    public void Fly()
    {
        Console.WriteLine("The bird is flying...");
    }
}