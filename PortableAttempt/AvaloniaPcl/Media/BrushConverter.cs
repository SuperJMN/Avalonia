// -----------------------------------------------------------------------
// <copyright file="BrushConverter.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Globalization;
using System.Reflection;

namespace Avalonia.Media
{
    public class BrushConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return sourceType == typeof(string);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            string s = (string)value;

            if (s.StartsWith("#"))
            {
                s = s.Substring(1);

                if (s.Length == 6)
                {
                    s = "ff" + s;
                }

                if (s.Length != 8)
                {
                    throw new NotSupportedException("Invalid color string.");
                }

                return new SolidColorBrush(Color.FromUInt32(uint.Parse(s, NumberStyles.HexNumber)));
            }
            else
            {
                // TODO PORT: GetProperty(s, BindingFlags.Public | BindingFlags.Static);
                PropertyInfo p = typeof (Colors).GetTypeInfo().GetDeclaredProperty(s);

                if (p != null)
                {
                    return new SolidColorBrush((Color)p.GetValue(null));
                }
                else
                {
                    throw new NotSupportedException();
                }
            }
        }
    }
}
