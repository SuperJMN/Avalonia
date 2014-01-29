// -----------------------------------------------------------------------
// <copyright file="IPlatformBitmapDecoder.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

using System.Collections.Generic;
using Avalonia.Platform;

namespace Avalonia.Platform
{
    public interface IPlatformBitmapDecoder
    {
        BitmapContainerFormat ContainerFormat { get; }

        IEnumerable<IPlatformBitmapSource> Frames { get; }
    }
}
