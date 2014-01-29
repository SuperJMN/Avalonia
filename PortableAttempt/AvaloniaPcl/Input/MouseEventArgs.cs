// -----------------------------------------------------------------------
// <copyright file="MouseEventArgs.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

using Avalonia.Core;

namespace Avalonia.Input
{
    public class MouseEventArgs : InputEventArgs
    {
        public MouseEventArgs(MouseDevice mouse, int timestamp)
            : base(mouse, timestamp)
        {
        }

        public MouseDevice MouseDevice 
        {
            get { return (MouseDevice)this.Device; }
        }

        public Point GetPosition(IInputElement relativeTo)
        {
            return this.MouseDevice.GetPosition(relativeTo);
        }
    }
}
