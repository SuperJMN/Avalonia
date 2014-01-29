// -----------------------------------------------------------------------
// <copyright file="IPlatformStreamGeometry.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

using System;
using Avalonia.Core;
using Avalonia.Media;

namespace Avalonia.Platform
{
    [AvaloniaSpecific]
    public interface IPlatformStreamGeometry : IDisposable
    {
        Rect Bounds { get; }

        Rect GetRenderBounds(Pen pen, double tolerance, ToleranceType type);

        StreamGeometryContext Open();
    }
}
