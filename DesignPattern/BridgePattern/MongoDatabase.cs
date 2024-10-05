namespace SingletonPattern.BridgePattern;

public class MongoDatabase:IDatabase
{
    public void connect()
    {
        System.Console.WriteLine("Connected to MongoDB");
    }

    public void disconnect()
    {
        System.Console.WriteLine("Disconnected from MongoDB");
    }

    public void execute(string sql)
    {
       System.Console.WriteLine("MongoDB executing "+sql);
    }
}