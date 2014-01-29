// -----------------------------------------------------------------------
// <copyright file="IWeakEventListener.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

using System;

namespace Avalonia
{
    public interface IWeakEventListener
    {
        bool ReceiveWeakEvent(Type managerType, object sender, EventArgs e);
    }
}
