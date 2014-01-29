// -----------------------------------------------------------------------
// <copyright file="IObservableDependencyObject.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

namespace Avalonia
{
    public interface IObservableDependencyObject
    {
        void AttachPropertyChangedHandler(
            string propertyName,
            DependencyPropertyChangedEventHandler handler);

        void RemovePropertyChangedHandler(
            string propertyName,
            DependencyPropertyChangedEventHandler handler);
    }
}
