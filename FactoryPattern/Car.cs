namespace FactoryPattern;

public class Car : IVehichle
{
    public void Drive()
    {
        Console.WriteLine("Building a new Car!");
    }
}