namespace abstractclassandinterface;

public class FullTimeEmployee : Employee
{
    public override void CalculateSalary()
    {
        Console.WriteLine($"What's your salary");
        Salary = int.Parse(Console.ReadLine());
        Console.WriteLine($"Your salary is {Salary}");
    }
}