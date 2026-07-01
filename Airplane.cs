namespace abstractclassandinterface;

public class Airplane : IFly
{
    public void Fly()
    {
        Console.WriteLine("The Airplane is flying...");
    }
}