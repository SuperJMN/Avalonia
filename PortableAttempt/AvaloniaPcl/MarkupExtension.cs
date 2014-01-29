using System;

namespace Avalonia
{
    public class MarkupExtension
    {
        public virtual object ProvideValue(IServiceProvider serviceProvider)
        {
            throw new NotImplementedException();
        }
    }
}