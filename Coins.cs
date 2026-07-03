namespace abstractclassandinterface;

public class Coins : ICollectable
{
    public void Collect(int coins)
    {
        Collectedcoins = coins;
        Currentcoins += Collectedcoins;
        Console.WriteLine($"Collected {Collectedcoins} coins.");
        Console.WriteLine($"Current coins is {Currentcoins}");
    }
    public int Currentcoins;
    public int Collectedcoins;
}