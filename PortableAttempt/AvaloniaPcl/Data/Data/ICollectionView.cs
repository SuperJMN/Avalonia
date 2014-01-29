// -----------------------------------------------------------------------
// <copyright file="ICollectionView.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

using System.Collections;
using System.Collections.Specialized;

namespace Avalonia.Data.Data
{
    public interface ICollectionView : IEnumerable, INotifyCollectionChanged
    {
        IEnumerable SourceCollection { get; }
    }
}
