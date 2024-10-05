namespace SingletonPattern.FacadePattern;

public class UpdateUserRepository
{
    public UpdateUserRepository(){}

    public void UpdateUserDB()
    {
        Console.WriteLine("Update user in database");
    }

    public void returnValue()
    {
        Console.WriteLine("Return user in database");
    }
}