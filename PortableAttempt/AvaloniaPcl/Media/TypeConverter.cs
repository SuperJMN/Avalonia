using System;
using System.Globalization;

namespace Avalonia.Media
{
    public abstract class TypeConverter : ITypeConverter
    {
        public TypeConverter()
        {
            
        }

        public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return false;
        }

        public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            return value;
        }

        public virtual bool CanConvertFrom(Type getType)
        {
            return false;
        }

        public virtual object ConvertFrom(object value)
        {
            return false;
        }
    }
}