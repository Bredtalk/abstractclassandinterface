namespace abstractclassandinterface;

public class Dog : Animal, ISwimming//you can use swimming even though animal don't have it
{
    public override void Sound()
    {
        Console.WriteLine("Bark Bark");
    }

    public void Swim()
    {
        Console.WriteLine("I'm swimming");
    }
}