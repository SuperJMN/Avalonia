using System.Collections.Generic;

namespace Avalonia.Resources
{
    public interface IResourceReader
    {
        Dictionary<object, object>.Enumerator GetEnumerator();
        void Close();
    }
}