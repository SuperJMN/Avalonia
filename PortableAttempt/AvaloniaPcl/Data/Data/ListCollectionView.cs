// -----------------------------------------------------------------------
// <copyright file="ListCollectionView.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

using System.Collections;

namespace Avalonia.Data.Data
{
    public class ListCollectionView : CollectionView
    {
        public ListCollectionView(IList list)
            : base(list)
        {
        }
    }
}
