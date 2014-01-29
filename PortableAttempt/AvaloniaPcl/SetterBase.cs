// -----------------------------------------------------------------------
// <copyright file="SetterBase.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

using System;

namespace Avalonia
{
    public abstract class SetterBase
    {
        public bool IsSealed
        {
            get;
            internal set;
        }

        internal abstract void Attach(FrameworkElement frameworkElement);

        internal abstract void Detach(FrameworkElement frameworkElement);

        protected void CheckSealed()
        {
            if (this.IsSealed)
            {
                throw new InvalidOperationException("Object is sealed.");
            }
        }
    }
}
