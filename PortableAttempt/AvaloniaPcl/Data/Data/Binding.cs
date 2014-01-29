// -----------------------------------------------------------------------
// <copyright file="Binding.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

namespace Avalonia.Data.Data
{
    public class Binding : BindingBase
    {
        public Binding()
        {
        }

        public Binding(string path)
        {
            this.Path = new PropertyPath(path);
        }

        public PropertyPath Path { get; set; }

        public RelativeSource RelativeSource { get; set; }

        public object Source { get; set; }

        //public override object ProvideValue(IServiceProvider serviceProvider)
        //{
        //    return this;
        //}
    }
}
