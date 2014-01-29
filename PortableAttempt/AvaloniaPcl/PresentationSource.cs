using Avalonia.Media;
using Avalonia.Threading;

namespace Avalonia
{
    public abstract class PresentationSource : DispatcherObject
    {
        public abstract Visual RootVisual { get; set; }
    }

    
}
