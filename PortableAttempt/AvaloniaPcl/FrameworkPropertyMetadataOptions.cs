using System;

namespace Avalonia
{
    [Flags]
    public enum FrameworkPropertyMetadataOptions
    {
        None = 0,
        AffectsMeasure = 0x0001,
        AffectsArrange = 0x0002,
        AffectsParentMeasure = 0x0004,
        AffectsParentArrange = 0x0008,
        AffectsRender = 0x0010,
        Inherits = 0x0020,
        OverridesInheritanceBehavior = 0x0040,
        NotDataBindable = 0x0080,
        BindsTwoWayByDefault = 0x0100,
        Journal = 0x0200,
        SubPropertiesDoNotAffectRender = 0x0400,
    }
}