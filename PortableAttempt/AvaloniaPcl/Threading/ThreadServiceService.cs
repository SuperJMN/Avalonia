namespace Avalonia.Threading
{
    public class ThreadServiceService : IThreadService
    {
        public IThread CurrentThread { get; private set; }
        public IThread CurrentUIThread { get; set; }
    }
}