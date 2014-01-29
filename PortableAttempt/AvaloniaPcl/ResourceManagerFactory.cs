using System;
using System.Reflection;

namespace Avalonia
{
    public abstract class ResourceManagerFactory
    {
        public abstract IResourceManager CreateResourceMananger(string resourceName, Assembly assembly);
    }
}