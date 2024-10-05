namespace SingletonPattern.StrategyPattern;

public class MomoPaymentStrategy:IStrategy
{
    public void implementStrategy()
    {
        System.Console.WriteLine("Momo Payment Strategy Implemented");
    }
}