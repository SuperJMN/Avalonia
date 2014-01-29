// -----------------------------------------------------------------------
// <copyright file="ThicknessConverter.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Globalization;
using Avalonia.Media;

namespace Avalonia
{
    public class ThicknessConverter : TypeConverter
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
                return new Thickness(double.Parse(components[0]));
            }
            else
            {
                if (components.Length == 2)
                {
                    return new Thickness(
                        double.Parse(components[0]),
                        double.Parse(components[1]),
                        double.Parse(components[0]),
                        double.Parse(components[1]));
                }
                else
                {
                    if (components.Length == 4)
                    {
                        return new Thickness(
                            double.Parse(components[0]),
                            double.Parse(components[1]),
                            double.Parse(components[2]),
                            double.Parse(components[3]));
                    }
                    else
                    {
                        throw new NotSupportedException("Value is not valid: must contain one, two or four delineated lengths.");
                    }
                }
            }
        }
    }
}
