namespace abstractclassandinterface;

public abstract class Vehicle
{
    public string Brand;
    public int Speed;
    
    public void Start()
    {
        Console.WriteLine("Vehicle Start");
    }

    public void Stop()
    {
        Console.WriteLine("Vehicle Stop");
    }
    
}