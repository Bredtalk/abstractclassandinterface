namespace abstractclassandinterface;

public class Mage : Character
{
    public override void Attack()
    {
        Console.WriteLine("Mage is attacking");
    }

    public override void Move()
    {
        Console.WriteLine("Mage is moving");
    }

    public override void TakeDamage(int damage)
    {
        
    }
}