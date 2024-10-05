namespace SingletonPattern.BridgePattern;

public class MySQLDatabase:IDatabase
{
    public void connect()
    {
        System.Console.WriteLine("MySQLDatabase.connect()");
    }

    public void disconnect()
    {
        System.Console.WriteLine("MySQLDatabase.disconnect()");
    }

    public void execute(string sql)
    {
        System.Console.WriteLine("MySQL executing: "+sql);
    }
}