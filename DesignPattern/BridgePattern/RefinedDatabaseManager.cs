namespace SingletonPattern.BridgePattern;

public class RefinedDatabaseManager:DatabaseManager
{
    public RefinedDatabaseManager(IDatabase database) : base(database)
    {
    }
    public override void RunQuery(string query)
    {
        Console.WriteLine($"\nSome config before run query: {query}");
        base.RunQuery(query);
    }

    public void RunQueries(List<string> queries)
    {
        foreach (var query in queries)
        {
            base.RunQuery(query);
        }
    }
}