// -----------------------------------------------------------------------
// <copyright file="TranslateTransform.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

using Avalonia.Core;

namespace Avalonia.Media
{
    public class TranslateTransform : Transform
    {
        public TranslateTransform(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public TranslateTransform(Vector offset)
        {
            this.X = offset.X;
            this.Y = offset.Y;
        }

        public double X { get; set; }

        public double Y { get; set; }

        public override Matrix Value
        {
            get { return new Matrix(1, 0, 0, 1, this.X, this.Y); }
        }
    }
}
