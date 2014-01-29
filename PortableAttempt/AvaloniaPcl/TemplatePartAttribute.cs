// -----------------------------------------------------------------------
// <copyright file="TemplatePartAttribute.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

using System;

namespace Avalonia
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public sealed class TemplatePartAttribute : Attribute
    {
        public string Name { get; set; }

        public Type Type { get; set; }
    }
}
