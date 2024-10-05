namespace DesignPattern;

public sealed class Singleton
{
    private static Singleton _instance = null;
    private static object _syncObject = new object();
    private Singleton(){}

    public static Singleton Instance
    {
        get
        {
            lock (_syncObject)
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }
        
    }
    
}