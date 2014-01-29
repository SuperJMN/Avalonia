using System.Threading;
using Avalonia;
using Avalonia.Media;
using Avalonia.Platform;
using Avalonia.Threading;
using ImpromptuInterface;
using TestApp.PlatformSpecific;

namespace TestApp
{
    public class App : Application
    {
        public static void Main()
        {
            PlatformInterface.PlatformFactory = new Direct2DPlatformInterfaceNetCore();

            ServiceLocator.ThreadService.CurrentUIThread = Thread.CurrentThread.ActLike<IThread>();
            ServiceLocator.ResourceManagerFactory = new ResourceManagerFactoryNetCore();
            ServiceLocator.AssemblyLocator = new AssemblyLocatorNetCore();
            ServiceLocator.FileService = new FileServiceNetCore();

            XamlReader = new XamlReader().ActLike<IXamlReader>();

            App app = new App();
            app.MainWindow = new MainWindow();
            app.Run();
        }
    }
}
