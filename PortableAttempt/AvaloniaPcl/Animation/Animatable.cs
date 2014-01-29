// -----------------------------------------------------------------------
// <copyright file="Animatable.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

using System;
using Avalonia;

namespace Avalonia.Animation
{
    public class Animatable : Freezable
    {
        protected override Freezable CreateInstanceCore()
        {
            throw new NotImplementedException();
        }
    }
}
