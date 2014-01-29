using System;
using System.Globalization;
using Avalonia.Media;

namespace Avalonia
{
    public interface ITypeConverter
    {
        bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);

        object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);        

        bool CanConvertFrom(Type getType);
        object ConvertFrom(object value);
    }
}