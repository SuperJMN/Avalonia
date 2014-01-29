// -----------------------------------------------------------------------
// <copyright file="WindowInteropHelper.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

using System;

namespace Avalonia.Interop
{
    public class WindowInteropHelper
    {
        private Window window;

        public WindowInteropHelper(Window window)
        {
            this.window = window;
        }

        public IntPtr Handle
        {
            get { return this.window.PresentationSource.Handle; }
        }
    }
}
