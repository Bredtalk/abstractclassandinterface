namespace abstractclassandinterface;

public class Archer : Character
{
    public override void Attack()
    {
        Console.WriteLine("Archer is attacking");
    }

    public override void Move()
    {
        Console.WriteLine("Archer is moving");
    }
}