namespace abstractclassandinterface;

public class Boss : Character, IDamageable
{
    public void TakeDamage(int damage)
    {
        HP -= damage;
        Console.WriteLine($"The boss took {damage} damage and currently has {HP} HP");
        if (HP <= 0)
        {
            Console.WriteLine("The boss is dead");
        }
    }

    public override void Attack()
    {
        Console.WriteLine("The boss is attacking");
    }

    public override void Move()
    {
        Console.WriteLine("The boss is moving");
    }
}