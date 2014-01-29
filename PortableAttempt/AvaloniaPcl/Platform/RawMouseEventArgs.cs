// -----------------------------------------------------------------------
// <copyright file="RawMouseEventArgs.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

using System;
using Avalonia.Input;

namespace Avalonia.Platform
{
    [AvaloniaSpecific]
    public class RawMouseEventArgs : InputEventArgs
    {
        public RawMouseEventArgs(MouseDevice device, RawMouseEventType type)
            : base(device, Environment.TickCount)
        {
            this.Type = type;
        }

        public RawMouseEventType Type { get; private set; }
    }
}
