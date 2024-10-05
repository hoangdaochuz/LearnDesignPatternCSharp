namespace SingletonPattern.StrategyPattern;

public class PaymentContext
{
    private IStrategy _strategy;

    public PaymentContext(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void ExecutePayment()
    {
        _strategy.implementStrategy();
    }
    
}