using System.IO;
using System.Xml;

namespace Avalonia.Threading
{
    public interface IXamlReader
    {
        object Load(Stream stream);
        object Load(XmlReader reader);
        object Load(IXamlReader reader);
        void Load(Stream stream, object component);
        void SetValue(object sender, XamlSetValueEventArgs e);
    }
}