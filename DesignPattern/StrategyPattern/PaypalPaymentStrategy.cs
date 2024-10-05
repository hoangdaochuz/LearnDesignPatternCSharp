namespace SingletonPattern.StrategyPattern;

public class PaypalPaymentStrategy:IStrategy
{
    public void implementStrategy()
    {
        System.Console.WriteLine("Paypal Payment Strategy Implemented");
    }
}