// -----------------------------------------------------------------------
// <copyright file="MouseButtonEventArgs.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

namespace Avalonia.Input
{
    public class MouseButtonEventArgs : MouseEventArgs
    {
        public MouseButtonEventArgs(MouseDevice device, int timestamp)
            : base(device, timestamp)
        {
        }
    }
}
