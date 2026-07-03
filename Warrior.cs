namespace abstractclassandinterface;

public class Warrior : Character
{
    public override void Attack()
    {
        Console.WriteLine("Warrior is attacking");
    }

    public override void Move()
    {
        Console.WriteLine("Warrior is moving");
    }

    public override void TakeDamage(int damage)
    {
       
    }
}