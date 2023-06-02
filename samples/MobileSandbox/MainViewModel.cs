using MobileSandbox;
using ReactiveUI;

public class MainViewModel : ViewModelBase
{
    private int executions = 0;
    
    public string Message => $"Executed {executions} times";

    public void Command()
    {
        ++executions;

        this.RaisePropertyChanged(nameof(Message));
    }
}
