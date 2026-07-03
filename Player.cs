namespace abstractclassandinterface;

public class Player : Character, IDamageable, IInteract
{
    public override void Attack()
    {
        Console.WriteLine($"{Name} is attacking");
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} is moving");
    }

    public override void TakeDamage(int damage)
    {
        HP -= damage;
        Console.WriteLine($"{Name} took {damage} damage and currently has {HP} HP");
        if (HP <= 0)
        {
            Console.WriteLine($"The {Name} is dead");
        }
    }


    public virtual void Interact()
    {
        Console.WriteLine($"{Name} is interacting");
    }
}