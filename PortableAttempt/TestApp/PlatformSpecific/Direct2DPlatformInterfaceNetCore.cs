using System;
using System.IO;
using System.Reflection;
using Avalonia.Platform;

namespace TestApp.PlatformSpecific
{
    public class Direct2DPlatformInterfaceNetCore : IPlatformFactory
    {
        public IPlatformInterface CreatePlatformInterface()
        {

            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            Assembly platform = Assembly.LoadFile(Path.Combine(path, "Avalonia.Direct2D1.dll"));
            Type factoryType = platform.GetType("Avalonia.Direct2D1.Direct2D1PlatformInterface");
            var instance = Activator.CreateInstance(factoryType);
            return (IPlatformInterface)instance;
        }
    }
}