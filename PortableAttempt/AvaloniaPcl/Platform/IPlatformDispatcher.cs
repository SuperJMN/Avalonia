// -----------------------------------------------------------------------
// <copyright file="IPlatformDispatcher.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

namespace Avalonia.Platform
{
    [AvaloniaSpecific]
    public interface IPlatformDispatcher
    {
        void ProcessMessage();

        void SendMessage();
    }
}
