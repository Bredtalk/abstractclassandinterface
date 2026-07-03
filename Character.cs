namespace abstractclassandinterface;

public abstract class Character : IDamageable
{
    public string Name;
    public int HP;

    public abstract void Attack();
    public abstract void Move();
    public abstract void TakeDamage(int damage);
}