namespace abstractclassandinterface;

public class Paypay : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Ban da thanh cong chuyen {amount} bang paypal");
    }
}