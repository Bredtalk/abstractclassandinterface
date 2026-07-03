namespace abstractclassandinterface;

public class Creditcard : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Ban da thanh toan thanh cong {amount}");
    }
}