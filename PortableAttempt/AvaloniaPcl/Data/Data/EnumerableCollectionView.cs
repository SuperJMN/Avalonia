// -----------------------------------------------------------------------
// <copyright file="EnumerableCollectionView.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

using System.Collections;

namespace Avalonia.Data.Data
{
    public class EnumerableCollectionView : CollectionView
    {
        public EnumerableCollectionView(IEnumerable collection)
            : base(collection)
        {
        }
    }
}
