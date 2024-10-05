namespace SingletonPattern.CommandPattern;

public class TelevisionReceiver
{
    private int volume;

    public int Volume
    {
        get => volume;
        set => volume = value;
    }

    public TelevisionReceiver()
    {
        volume = 0;
    }
    public void increaseVolume()
    {
        volume += 1;
    }

    public void decreaseVolume()
    {
        volume -= 1;
    }
}