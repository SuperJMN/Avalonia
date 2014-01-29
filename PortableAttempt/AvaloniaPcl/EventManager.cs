// -----------------------------------------------------------------------
// <copyright file="EventManager.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

using System;

namespace Avalonia
{
    public static class EventManager
    {
        public static RoutedEvent RegisterRoutedEvent(
            string name,
            RoutingStrategy routingStrategy,
            Type handlerType,
            Type ownerType)
        {
            return new RoutedEvent(name, routingStrategy, handlerType, ownerType);
        }
    }
}
