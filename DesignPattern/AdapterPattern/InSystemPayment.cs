namespace SingletonPattern.AdapterPattern;

public class InSystemPayment : InternalPaymentMethod
{
    public void PayProcess(decimal amount)
    {
        System.Console.WriteLine("In system payment processing: "+ amount);
    }
}