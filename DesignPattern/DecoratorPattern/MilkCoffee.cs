namespace SingletonPattern.DecoratorPattern;

public class MilkCoffee:ICoffee
{
    private readonly ICoffee _coffee;

    public MilkCoffee(ICoffee coffee)
    {
        _coffee = coffee;
    }
    public string getDescription()
    {
        return _coffee.getDescription() + " " + " with milk";
    }

    public decimal GetPrice()
    {
        return _coffee.GetPrice() + 3000;
    }
}