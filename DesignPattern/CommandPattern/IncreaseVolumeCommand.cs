namespace SingletonPattern.CommandPattern;

public class IncreaseVolumeCommand:ICommand
{
    private readonly TelevisionReceiver _televisionReceiver;

    public IncreaseVolumeCommand(TelevisionReceiver televisionReceiver)
    {
        _televisionReceiver = televisionReceiver;
    }
    public void Execute()
    {
       _televisionReceiver.increaseVolume();
    }
}