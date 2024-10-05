namespace SingletonPattern.DependencyInjection;

public class BusinessLayer
{
    private readonly IDataAccessLayer _dataAccessLayer;

    public BusinessLayer(IDataAccessLayer dataAccessLayer)
    {
        this._dataAccessLayer = dataAccessLayer;
    }

    public void SaveData(string data)
    {
        this._dataAccessLayer.SaveData(data);
    }
}