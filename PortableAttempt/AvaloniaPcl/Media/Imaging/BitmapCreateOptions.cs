using System;

namespace Avalonia.Media.Imaging
{
    [Flags]
    public enum BitmapCreateOptions
    {
        None = 0,
        PreservePixelFormat = 1,
        DelayCreation = 2,
        IgnoreColorProfile = 4,
        IgnoreImageCache = 8,
    }
}