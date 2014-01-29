// -----------------------------------------------------------------------
// <copyright file="UIPropertyMetadata.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

namespace Avalonia
{
    public class UIPropertyMetadata : PropertyMetadata
    {
        private bool isAnimationProhibited;

        public UIPropertyMetadata()
        {
        }

        public UIPropertyMetadata(object defaultValue)
                    : base(defaultValue)
        {
        }

        public UIPropertyMetadata(PropertyChangedCallback propertyChangedCallback)
                    : base(propertyChangedCallback)
        {
        }

        public UIPropertyMetadata(
                    object defaultValue,
                    PropertyChangedCallback propertyChangedCallback)
                    : base(defaultValue, propertyChangedCallback)
        {
        }

        public UIPropertyMetadata(
                    object defaultValue,
                    PropertyChangedCallback propertyChangedCallback,
                    CoerceValueCallback coerceValueCallback)
                    : base(defaultValue, propertyChangedCallback, coerceValueCallback)
        {
        }

        public UIPropertyMetadata(
                    object defaultValue,
                    PropertyChangedCallback propertyChangedCallback,
                    CoerceValueCallback coerceValueCallback,
                    bool isAnimationProhibited)
                    : base(defaultValue, propertyChangedCallback, coerceValueCallback)
        {
            this.isAnimationProhibited = isAnimationProhibited;
        }

        public bool IsAnimationProhibited
        {
            get { return this.isAnimationProhibited; }
            set { this.isAnimationProhibited = value; }
        }
    }
}