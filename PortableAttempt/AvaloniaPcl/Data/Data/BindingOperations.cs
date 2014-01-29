// -----------------------------------------------------------------------
// <copyright file="BindingOperations.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

using System;

namespace Avalonia.Data.Data
{
    public static class BindingOperations
    {
        public static BindingExpressionBase SetBinding(
            DependencyObject target,
            DependencyProperty dp,
            BindingBase binding)
        {
            Binding b = binding as Binding;

            if (b == null)
            {
                throw new NotSupportedException("Unsupported binding type.");
            }

            return target.SetBinding(dp, b);
        }
    }
}
