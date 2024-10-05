namespace SingletonPattern.BridgePattern;

public interface IDatabase
{
    public void connect();
    public void disconnect();
    public void execute(string sql);
}