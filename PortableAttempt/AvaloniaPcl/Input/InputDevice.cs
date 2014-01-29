// -----------------------------------------------------------------------
// <copyright file="InputDevice.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

namespace Avalonia.Input
{
    public abstract class InputDevice : DependencyObject
    {
        public PresentationSource ActiveSource { get; protected set; }

        public abstract IInputElement Target { get; }
    }
}
