// -----------------------------------------------------------------------
// <copyright file="IPlatformBitmapSource.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

using System;
using Avalonia.Media;

namespace Avalonia.Platform
{
    public interface IPlatformBitmapSource
    {
        PixelFormat Format { get; }

        int PixelWidth { get; }

        int PixelHeight { get; }

        double Width { get; }

        double Height { get; }

        void CopyPixels(Array pixels, int stride, int offset);
    }
}
