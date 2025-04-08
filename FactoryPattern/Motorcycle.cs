namespace FactoryPattern;

public class Motorcycle : IVehichle
{
    public void Drive()
    {
        Console.WriteLine("Building a new Motorcycle!");
    }
}