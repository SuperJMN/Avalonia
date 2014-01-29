// -----------------------------------------------------------------------
// <copyright file="Brush.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

using Avalonia.Animation;

namespace Avalonia.Media
{
    [TypeConverter(typeof(BrushConverter))]
    public class Brush : Animatable
    {
    }
}
