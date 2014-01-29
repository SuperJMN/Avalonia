// -----------------------------------------------------------------------
// <copyright file="PointHitTestParameters.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

using Avalonia.Core;

namespace Avalonia.Media
{
    public class PointHitTestParameters : HitTestParameters
    {
        public PointHitTestParameters(Point point)
        {
            this.HitPoint = point;
        }

        public Point HitPoint { get; private set; }
    }
}
