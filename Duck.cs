namespace abstractclassandinterface;

public class Duck : Animal, IFly, ISwimming
{
    public override void Sound()
    {
        Console.WriteLine("Quack Quack");
    }

    public void Fly()
    {
        Console.WriteLine("The duck is flying");
    }

    public void Swim()
    {
        Console.WriteLine("The duck is swimming");
    }
}