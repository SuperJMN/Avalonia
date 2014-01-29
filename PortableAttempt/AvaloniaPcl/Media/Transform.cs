// -----------------------------------------------------------------------
// <copyright file="Transform.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

using Avalonia.Core;

namespace Avalonia.Media
{
    public abstract class Transform
    {
        public abstract Matrix Value { get; }
    }
}
