namespace SingletonPattern.DecoratorPattern;

public class SimpleCoffee:ICoffee
{
    public string getDescription()
    {
        return "Simple Coffee";
    }

    public decimal GetPrice()
    {
        return 15000;
    }
}