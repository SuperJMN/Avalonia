// -----------------------------------------------------------------------
// <copyright file="PropertyPath.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

using System.Collections.ObjectModel;

namespace Avalonia
{
    public sealed class PropertyPath
    {
        public PropertyPath(string path)
        {
            this.Path = path;
            this.PathParameters = new Collection<object>();
        }

        public PropertyPath(string path, params object[] pathParameters)
        {
            this.Path = path;
            this.PathParameters = new Collection<object>(pathParameters);
        }

        public string Path { get; private set; }

        public Collection<object> PathParameters { get; private set; }
    }
}
