// -----------------------------------------------------------------------
// <copyright file="SetterBaseCollection.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

using System.Collections.ObjectModel;

namespace Avalonia
{
    public sealed class SetterBaseCollection : Collection<SetterBase>
    {
        internal void Attach(FrameworkElement element)
        {
            foreach (SetterBase setter in this)
            {
                setter.Attach(element);
            }
        }

        internal void Detach(FrameworkElement element)
        {
            foreach (SetterBase setter in this)
            {
                setter.Detach(element);
            }
        }
    }
}
