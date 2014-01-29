// -----------------------------------------------------------------------
// <copyright file="Style.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

using System;
using Avalonia.Controls;
using Avalonia.Threading;

namespace Avalonia
{
    [Ambient]
    [ContentProperty("Setters")]
    [DictionaryKeyProperty("TargetType")]
    public class Style : DispatcherObject, INameScope
    {
        private NameScope nameScope = new NameScope();

        public Style()
        {
            this.Setters = new SetterBaseCollection();
        }

        public Style(Type targetType)
                    : this()
        {
            this.TargetType = targetType;
        }

        public Style(Type targetType, Style basedOn)
                    : this()
        {
            this.TargetType = targetType;
            this.BasedOn = basedOn;
        }

        [Ambient]
        public Style BasedOn
        {
            get;
            set;
        }

        [Ambient]
        public ResourceDictionary Resources
        {
            get;
            set;
        }

        public SetterBaseCollection Setters
        {
            get;
            set;
        }

        [Ambient]
        public Type TargetType
        {
            get;
            set;
        }

        object INameScope.FindName(string name)
        {
            return this.nameScope.FindName(name);
        }

        void INameScope.RegisterName(string name, object scopedElement)
        {
            this.nameScope.RegisterName(name, scopedElement);
        }

        void INameScope.UnregisterName(string name)
        {
            this.nameScope.UnregisterName(name);
        }

        internal void Attach(FrameworkElement frameworkElement)
        {
            foreach (Setter setter in this.Setters)
            {
                setter.Attach(frameworkElement);
            }
        }

        internal void Detach(FrameworkElement frameworkElement)
        {
            foreach (Setter setter in this.Setters)
            {
                setter.Detach(frameworkElement);
            }
        }
    }
}
