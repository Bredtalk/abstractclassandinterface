namespace abstractclassandinterface;

public class BankTransfer : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Ban da thanh cong thanh toan {amount} bang ngan hang");
    }
}