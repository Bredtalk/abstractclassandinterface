namespace abstractclassandinterface;

public class Enemy : Character, IDamageable 
{
    public override void Attack()
    {
        Console.WriteLine("The enemy is attacking");
    }

    public override void Move()
    {
        Console.WriteLine("the enemy is moving");
    }

    public void TakeDamage(int damage)
    {
        HP -= damage;
        Console.WriteLine($"The enemy took {damage} damage and currently has {HP} HP");
        if (HP <= 0)
        {
            Console.WriteLine("The enemy is dead");
        }
    }
}