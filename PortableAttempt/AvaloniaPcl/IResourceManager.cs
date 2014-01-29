using System.Globalization;
using Avalonia.Resources;

namespace Avalonia
{
    public interface IResourceManager
    {
        IResourceSet GetResourceSet(CultureInfo currentCulture, bool b, bool b1);
    }
}