namespace FactoryPattern;

public static class VehichleFactory
{
    public static IVehichle GetVehichle(int wheelCount)
    {
        switch (wheelCount)
        {
            case 2:
                return new Motorcycle();
            case 4:
                return new Car();
            default:
                return new Car();
        }
    }
}