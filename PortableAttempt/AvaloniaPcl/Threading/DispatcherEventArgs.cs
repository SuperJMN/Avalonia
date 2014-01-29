// -----------------------------------------------------------------------
// <copyright file="DispatcherEventArgs.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

using System;

namespace Avalonia.Threading
{
    public class DispatcherEventArgs : EventArgs
    {
        private Dispatcher dispatcher;

        internal DispatcherEventArgs(Dispatcher dispatcher)
        {
            this.dispatcher = dispatcher;
        }

        public Dispatcher Dispatcher
        {
            get { return this.dispatcher; }
        }
    }
}