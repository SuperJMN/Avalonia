// -----------------------------------------------------------------------
// <copyright file="StreamGeometry.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

using Avalonia.Core;
using Avalonia.Platform;

namespace Avalonia.Media
{
    public sealed class StreamGeometry : Geometry
    {
        public StreamGeometry()
        {
            this.PlatformImpl = PlatformInterface.Instance.CreateStreamGeometry();
        }

        public override Rect Bounds
        {
            get { return this.PlatformImpl.Bounds; }
        }

        public override Rect GetRenderBounds(Pen pen, double tolerance, ToleranceType type)
        {
            return this.PlatformImpl.GetRenderBounds(pen, tolerance, type);
        }

        public StreamGeometryContext Open()
        {
            return this.PlatformImpl.Open();
        }
    }
}
