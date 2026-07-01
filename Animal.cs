namespace abstractclassandinterface;

public abstract class Animal
{
    public abstract void Sound();

    public string Name;
    public int Age;

    public void Eat()
    {
        Console.WriteLine($"{Name} is Eating...");
    }
}