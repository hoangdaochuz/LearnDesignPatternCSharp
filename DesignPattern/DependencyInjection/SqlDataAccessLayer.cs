namespace SingletonPattern.DependencyInjection;

public class SqlDataAccessLayer:IDataAccessLayer
{
    public void SaveData(string data)
    {
        System.Console.WriteLine("SQL: Save data "+ data);
    }
}