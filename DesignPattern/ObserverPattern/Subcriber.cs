namespace SingletonPattern.ObserverPattern;

public class Subcriber:IObserver
{
    private string name;
    private List<string> notifications;
    private YoutubeChannel subject;

    public string Name
    {
        get;
        set;
    }
    public Subcriber(YoutubeChannel subject,string name, List<string> notifications)
    {
        this.subject = subject;
        this.name = name;
        this.notifications = notifications;
    }
    
    public void UpdateNotifications()
    {
        string newNews = subject.NewNotification;
        this.notifications.Add(newNews);
    }

    public List<string> GetNotifications()
    {
        return notifications;
    }
}