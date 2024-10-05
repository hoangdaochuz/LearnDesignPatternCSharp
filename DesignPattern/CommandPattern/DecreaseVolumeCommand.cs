namespace SingletonPattern.CommandPattern;

public class DecreaseVolumeCommand:ICommand
{
    private readonly TelevisionReceiver _televisionReceiver;

    public DecreaseVolumeCommand(TelevisionReceiver televisionReceiver)
    {
        _televisionReceiver = televisionReceiver;
    }
    public void Execute()
    {
        _televisionReceiver.decreaseVolume();
    }
}