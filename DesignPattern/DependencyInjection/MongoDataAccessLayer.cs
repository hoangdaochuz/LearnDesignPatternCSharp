namespace SingletonPattern.DependencyInjection;

public class MongoDataAccessLayer:IDataAccessLayer
{
    public void SaveData(string data)
    {
        System.Console.WriteLine("Mongo saved "+data);
    }
}