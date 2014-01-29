using System.IO;
using System.Reflection;
using Avalonia.Data.Data;

namespace Avalonia.Threading
{
    public static class ServiceLocator
    {

        static ServiceLocator()
        {
            ThreadService = new ThreadServiceService();
        }
        public static IThreadService ThreadService { get; private set; }

        public static IXamlReader XamlReader { get; set; }

        public static ResourceManagerFactory ResourceManagerFactory { get; set; }

        public static IAssemblyLocator AssemblyLocator { get; set; }

        public static IFileService FileService { get; set; }
    }

    public interface IFileService
    {
        Stream GetFileStreamForReading(string path);
    }

    public interface IAssemblyLocator
    {
        Assembly GetEntryAssembly();
    }

  
}