using System;

namespace Avalonia.Controls
{
    public class BindableAttribute : Attribute
    {
        public bool Bindable { get;  private set; }

        public BindableAttribute(bool bindable)
        {
            Bindable = bindable;
        }
    }
}