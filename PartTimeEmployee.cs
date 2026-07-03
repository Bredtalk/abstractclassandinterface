namespace abstractclassandinterface;

public class PartTimeEmployee : Employee
{
    public override void CalculateSalary()
    {
        Console.WriteLine("How many hours worked? (50/h)");
        int hours = int.Parse(Console.ReadLine());
        Salary = hours * 50;
        Console.WriteLine($"Your salary is {Salary}");
    }
}