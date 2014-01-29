// -----------------------------------------------------------------------
// <copyright file="RawKeyEventArgs.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

using System;
using Avalonia.Input;

namespace Avalonia.Platform
{
    [AvaloniaSpecific]
    public class RawKeyEventArgs : InputEventArgs
    {
        public RawKeyEventArgs(KeyboardDevice device, RawKeyEventType type, Key key)
            : base(device, Environment.TickCount)
        {
            this.Key = key;
            this.Type = type;
        }

        public Key Key { get; private set; }

        public RawKeyEventType Type { get; private set; }
    }
}
