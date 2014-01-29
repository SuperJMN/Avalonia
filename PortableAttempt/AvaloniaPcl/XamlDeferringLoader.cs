using System;
using Avalonia.Media;

namespace Avalonia
{
    public abstract class XamlDeferringLoader
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Xaml.XamlDeferringLoader"/> class.
        /// </summary>
        
        protected XamlDeferringLoader()
        {
        }

        public abstract object Load(XamlReader xamlReader, IServiceProvider serviceProvider);

        public abstract XamlReader Save(object value, IServiceProvider serviceProvider);
    }
}