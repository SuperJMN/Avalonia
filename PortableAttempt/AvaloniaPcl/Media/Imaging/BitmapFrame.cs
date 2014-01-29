// -----------------------------------------------------------------------
// <copyright file="BitmapFrame.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

using Avalonia.Platform;

namespace Avalonia.Media.Imaging
{
    public class BitmapFrame : BitmapSource
    {
        internal BitmapFrame(IPlatformBitmapSource platformImpl)
            : base(platformImpl)
        {
        }

        public static BitmapFrame Create(BitmapSource source)
        {
            return new BitmapFrame(source.PlatformImpl);
        }
    }
}
