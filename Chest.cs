namespace abstractclassandinterface;

public class Chest : IInteract
{
    public void Interact()
    {
        Console.WriteLine("You opened a chest");
    }
}