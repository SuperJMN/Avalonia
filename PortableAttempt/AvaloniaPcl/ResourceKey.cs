// -----------------------------------------------------------------------
// <copyright file="ResourceKey.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Reflection;

namespace Avalonia
{
    [MarkupExtensionReturnType(typeof(ResourceKey))]
    public abstract class ResourceKey : MarkupExtension
    {
        protected ResourceKey()
        {
        }

        public abstract Assembly Assembly { get; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}
