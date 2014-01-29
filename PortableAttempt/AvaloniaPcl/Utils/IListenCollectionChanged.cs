// -----------------------------------------------------------------------
// <copyright file="IListenCollectionChanged.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

using System.Collections.Specialized;

namespace Avalonia.Utils
{
    internal interface IListenCollectionChanged
    {
        void CollectionChanged(object sender, NotifyCollectionChangedEventArgs e);
    }
}
