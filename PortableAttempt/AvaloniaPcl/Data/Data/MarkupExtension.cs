using System;

namespace Avalonia.Data.Data
{
    public abstract class MarkupExtension
    {
        /// <summary>
        /// Initializes a new instance of a class derived from <see cref="T:System.Windows.Markup.MarkupExtension"/>.
        /// </summary>        
        protected MarkupExtension()
        {
        }

        public abstract object ProvideValue(IServiceProvider serviceProvider);
    }
}