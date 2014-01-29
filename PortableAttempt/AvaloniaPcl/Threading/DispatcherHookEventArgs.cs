// -----------------------------------------------------------------------
// <copyright file="DispatcherHookEventArgs.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

using System;

namespace Avalonia.Threading
{
    public sealed class DispatcherHookEventArgs : EventArgs
    {
        private DispatcherOperation operation;

        public DispatcherHookEventArgs(DispatcherOperation operation)
        {
            this.operation = operation;
        }

        public Dispatcher Dispatcher
        {
            get
            {
                return this.operation.Dispatcher;
            }
        }

        public DispatcherOperation Operation
        {
            get
            {
                return this.operation;
            }
        }
    }
}