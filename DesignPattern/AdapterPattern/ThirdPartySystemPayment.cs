namespace SingletonPattern.AdapterPattern;

public class ThirdPartySystemPayment
{
    public void RequestPayment(decimal amount)
    {
        // code implement third party payment system
        System.Console.WriteLine("Third party system payment processing: "+ amount);
    }
}