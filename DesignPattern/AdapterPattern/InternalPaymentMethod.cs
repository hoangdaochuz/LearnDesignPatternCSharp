namespace SingletonPattern.AdapterPattern;

public interface InternalPaymentMethod
{
    public void PayProcess(decimal amount);
}