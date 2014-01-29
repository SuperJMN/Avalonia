// -----------------------------------------------------------------------
// <copyright file="CheckBox.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

using Avalonia.Controls.Primitives;

namespace Avalonia.Controls
{
    public class CheckBox : ToggleButton
    {
        static CheckBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CheckBox), new FrameworkPropertyMetadata(typeof(CheckBox)));
        }
    }
}
