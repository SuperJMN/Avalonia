// -----------------------------------------------------------------------
// <copyright file="MatrixTransform.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

using Avalonia.Core;

namespace Avalonia.Media
{
    public class MatrixTransform : Transform
    {
        public MatrixTransform()
        {
        }

        public MatrixTransform(Matrix matrix)
        {
            this.Matrix = matrix;
        }

        public Matrix Matrix
        {
            get;
            private set;
        }

        public override Matrix Value 
        {
            get { return this.Matrix; }
        }
    }
}
