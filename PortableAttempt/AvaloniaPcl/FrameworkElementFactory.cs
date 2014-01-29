// -----------------------------------------------------------------------
// <copyright file="FrameworkElementFactory.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Reflection;

namespace Avalonia
{
    public class FrameworkElementFactory
    {
        public FrameworkElementFactory()
        {
        }

        public FrameworkElementFactory(Type type)
        {
            this.Type = type;
        }

        public Type Type
        {
            get;
            set;
        }

        internal FrameworkElement Load()
        {
            if (this.Type != null)
            {
                if (typeof(FrameworkElement).GetTypeInfo().IsAssignableFrom(this.Type.GetTypeInfo()))
                {
                    return (FrameworkElement)Activator.CreateInstance(this.Type);
                }
                else
                {
                    throw new InvalidOperationException("FrameworkElementFactory.Type must be a FrameworkElement.");
                }
            }
            else
            {
                throw new InvalidOperationException("FrameworkElementFactory.Type not set.");
            }
        }
    }
}
