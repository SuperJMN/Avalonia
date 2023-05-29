using System;
using System.Reactive;
using System.Reactive.Linq;
using MobileSandbox;
using ReactiveUI;

public class MainViewModel : ViewModelBase
{
    private int executions = 0;
    public string Greeting => "Welcome to Avalonia!";

    public MainViewModel()
    {
        Command = ReactiveCommand.Create(() => ++executions);
        Message = Command.Select(unit => $"Executed {unit} times" );
    }

    public IObservable<string> Message { get; }

    public ReactiveCommand<Unit, int> Command { get; set; }
}
