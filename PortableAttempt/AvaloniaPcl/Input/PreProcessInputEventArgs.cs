// -----------------------------------------------------------------------
// <copyright file="PreProcessInputEventArgs.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

using System;

namespace Avalonia.Input
{
    public class PreProcessInputEventArgs : EventArgs
    {
        private bool canceled;

        public PreProcessInputEventArgs(InputEventArgs input)
        {
            this.Input = input;
        }

        public bool Canceled
        {
            get { return this.canceled; }
        }

        public InputEventArgs Input 
        { 
            get; 
            private set; 
        }

        public void Cancel()
        {
            this.canceled = true;
        }
    }
}
