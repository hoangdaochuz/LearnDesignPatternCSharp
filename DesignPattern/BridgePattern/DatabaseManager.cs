namespace SingletonPattern.BridgePattern;

public abstract class DatabaseManager
{
    protected readonly IDatabase _database;

    public DatabaseManager(IDatabase database)
    {
        _database = database;
    }

    public void Connect()
    {
        _database.connect();
    }

    public void Disconnect()
    {
        _database.disconnect();
    }

    public virtual void RunQuery(string sql)
    {
        _database.execute(sql);
    }
}