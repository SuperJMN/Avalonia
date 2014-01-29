// -----------------------------------------------------------------------
// <copyright file="PointHitTestResult.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

using Avalonia.Core;

namespace Avalonia.Media
{
    public class PointHitTestResult : HitTestResult
    {
        public PointHitTestResult(Visual visualHit, Point pointHit)
        {
            this.VisualHit = visualHit;
            this.PointHit = pointHit;
        }

        public Point PointHit { get; private set; }
    }
}
