using System.Reflection;
using Avalonia.Threading;

namespace TestApp.PlatformSpecific
{
    public class AssemblyLocatorNetCore : IAssemblyLocator
    {
        public Assembly GetEntryAssembly()
        {
            return Assembly.GetEntryAssembly();
        }
    }
}