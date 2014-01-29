namespace Avalonia.Threading
{
    public interface IThreadService
    {
        IThread CurrentThread { get; }
        IThread CurrentUIThread { get; set; }
    }
}