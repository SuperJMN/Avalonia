// -----------------------------------------------------------------------
// <copyright file="IPropertyPathParser.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

using System.Collections.Generic;

namespace Avalonia.Data.Data
{
    public interface IPropertyPathParser
    {
        IEnumerable<PropertyPathToken> Parse(object source, string path);
    }
}
