namespace Avalonia.Threading
{
    public enum DispatcherOperationStatus
    {
        Pending = 0,
        Aborted = 1,
        Completed = 2,
        Executing = 3
    }
}