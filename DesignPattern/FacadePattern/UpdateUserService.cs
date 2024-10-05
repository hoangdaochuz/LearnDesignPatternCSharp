namespace SingletonPattern.FacadePattern;

public class UpdateUserService
{
    public UpdateUserService(){}

    public void doBusineesLogic()
    {
        System.Console.WriteLine("Implement Business Logic");
    }

    public void callUpdateUserRepository()
    {
        System.Console.WriteLine("call Update User Repository");
    }
}