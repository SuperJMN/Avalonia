// -----------------------------------------------------------------------
// <copyright file="CornerRadiusConverter.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Globalization;
using Avalonia.Media;

namespace Avalonia
{
    public class CornerRadiusConverter : ITypeConverter
    {
        public bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return sourceType == typeof(string);
        }

        public object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            char[] separators = new char[] { ' ', ',' };
            string[] components = value.ToString().Split(separators, StringSplitOptions.RemoveEmptyEntries);

            if (components.Length == 1)
            {
                return new CornerRadius(double.Parse(components[0]));
            }
            else
            {
                if (components.Length == 4)
                {
                    return new CornerRadius(
                        double.Parse(components[0]),
                        double.Parse(components[1]),
                        double.Parse(components[2]),
                        double.Parse(components[3]));
                }
                else
                {
                    throw new NotSupportedException("Value is not valid: must contain one or four delineated lengths.");
                }
            }
        }

        public bool CanConvertFrom(Type getType)
        {
            throw new NotImplementedException();
        }

        public object ConvertFrom(object value)
        {
            throw new NotImplementedException();
        }
    }
}
