// -----------------------------------------------------------------------
// <copyright file="ItemsChangedEventArgs.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Collections.Specialized;

namespace Avalonia.Controls.Primitives
{
    public class ItemsChangedEventArgs : EventArgs
    {
        internal ItemsChangedEventArgs()
        {
        }

        public NotifyCollectionChangedAction Action
        {
            get;
            internal set;
        }

        public int ItemCount
        {
            get;
            internal set;
        }

        public int ItemUICount
        {
            get;
            internal set;
        }

        public GeneratorPosition OldPosition
        {
            get;
            internal set;
        }

        public GeneratorPosition Position
        {
            get;
            internal set;
        }
    }
}
