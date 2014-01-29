using System;
using System.IO;
using Avalonia.Threading;

namespace TestApp.PlatformSpecific
{
    public class FileServiceNetCore : IFileService
    {
        public Stream GetFileStreamForReading(string path)
        {
            var stream = new FileStream(
                Uri.UnescapeDataString(path),
                FileMode.Open,
                FileAccess.Read);

            return stream;
        }
    }
}