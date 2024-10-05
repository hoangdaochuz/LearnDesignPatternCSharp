namespace SingletonPattern.CommandPattern;

public class RemoteControlInvoker
{
    // private List<ICommand> _commands = new List<ICommand>();
    private ICommand _increaseCommand;
    private ICommand _decreaseCommand;
    public RemoteControlInvoker(ICommand increaseCommand, ICommand decreaseCommand)
    {
        _increaseCommand = increaseCommand;
        _decreaseCommand = decreaseCommand;
    }

    public void IncreaseExecute()
    {
        _increaseCommand.Execute();
    }

    public void DecreaseExecute()
    {
        _decreaseCommand.Execute();
    }
    
}