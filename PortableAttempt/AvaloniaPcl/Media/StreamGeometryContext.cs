// -----------------------------------------------------------------------
// <copyright file="StreamGeometryContext.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

using System;
using Avalonia.Core;
using Avalonia.Threading;

namespace Avalonia.Media
{
    public abstract class StreamGeometryContext : DispatcherObject, IDisposable
    {
        public abstract void Dispose();

        public abstract void BeginFigure(Point startPoint, bool isFilled, bool isClosed);

        public abstract void BezierTo(Point point1, Point point2, Point point3, bool isStroked, bool isSmoothJoin);

        public abstract void LineTo(Point point, bool isStroked, bool isSmoothJoin);
    }
}
