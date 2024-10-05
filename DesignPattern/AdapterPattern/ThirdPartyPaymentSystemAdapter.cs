namespace SingletonPattern.AdapterPattern;

public class ThirdPartyPaymentSystemAdapter:InternalPaymentMethod
{
    private readonly ThirdPartySystemPayment _thirdPartySystemPayment;

    public ThirdPartyPaymentSystemAdapter(ThirdPartySystemPayment thirdPartySystemPayment)
    {
        _thirdPartySystemPayment = thirdPartySystemPayment;
    }
    
    public void PayProcess(decimal amount)
    {
        _thirdPartySystemPayment.RequestPayment(amount);
    }
}