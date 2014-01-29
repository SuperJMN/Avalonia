// -----------------------------------------------------------------------
// <copyright file="GenerationState.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

using System;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;

namespace Avalonia
{
    internal class GenerationState : IDisposable
    {
        public bool AllowStartAtRealizedItem { get; set; }

        public GeneratorDirection Direction { get; set; }

        public ItemContainerGenerator Generator { get; set; }

        public GeneratorPosition Position { get; set; }

        public int Step
        {
            get { return this.Direction == GeneratorDirection.Forward ? 1 : -1; }
        }

        public void Dispose()
        {
            this.Generator.GenerationState = null;
        }
    }
}
