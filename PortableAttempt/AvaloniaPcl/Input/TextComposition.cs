// -----------------------------------------------------------------------
// <copyright file="TextComposition.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

using Avalonia.Threading;

namespace Avalonia.Input
{
    public class TextComposition : DispatcherObject
    {
        public TextComposition(InputManager inputManager, IInputElement source, string resultText)
        {
            this.Text = resultText;
        }

        public string Text { get; set; }
    }
}
