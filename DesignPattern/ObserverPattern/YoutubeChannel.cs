namespace SingletonPattern.ObserverPattern;

public class YoutubeChannel:ISubject
{
    
    private List<IObserver> subscribers;
    private string _newNews;

    public string NewNotification
    {
        get => _newNews;
        set
        {   
            _newNews = value;
            Notify();
        }
    }

    public YoutubeChannel()
    {
        subscribers = new List<IObserver>();
    }
    
    
    
    public void Subscribe(IObserver observer)
    {
        this.subscribers.Add(observer);    
    }

    public void Unsubscribe(IObserver observer)
    {
        this.subscribers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var subcriber in subscribers)
        {
            subcriber.UpdateNotifications();
        }   
    }
}