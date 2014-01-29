// -----------------------------------------------------------------------
// <copyright file="IPlatformBitmapEncoder.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

using System.Collections.Generic;
using System.IO;
using Avalonia.Media.Imaging;

namespace Avalonia.Platform
{
    public interface IPlatformBitmapEncoder
    {
        void Save(IEnumerable<BitmapFrame> frames, Stream stream);
    }
}
