using System.Reflection;
using System.Resources;
using Avalonia;
using ImpromptuInterface;

namespace TestApp.PlatformSpecific
{
    public class ResourceManagerFactoryNetCore : ResourceManagerFactory
    {
        public override IResourceManager CreateResourceMananger(string resourceName, Assembly assembly)
        {
            var resourceManager = new ResourceManager(resourceName, assembly);
            return resourceManager.ActLike<IResourceManager>();
        }
    }
}