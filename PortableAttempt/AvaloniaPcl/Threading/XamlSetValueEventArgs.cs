using System;

namespace Avalonia.Threading
{
    public class XamlSetValueEventArgs : EventArgs
    {
        /// <summary>
        /// Gets XAML type system and XAML schema information for the member being set.
        /// </summary>
        /// 
        /// <returns>
        /// XAML type system and XAML schema information for the member being set.
        /// </returns>
        public XamlMember Member { get; private set; }

        /// <summary>
        /// Gets the value to provide for the member being set.
        /// </summary>
        /// 
        /// <returns>
        /// The value to provide for the member being set.
        /// </returns>
        public object Value { get; private set; }

        /// <summary>
        /// Gets or sets a value that determines whether a caller that is using the <see cref="T:System.Windows.Markup.XamlSetValueEventArgs"/> can use the values without having to call <see cref="M:System.Windows.Markup.XamlSetValueEventArgs.CallBase"/>.
        /// </summary>
        /// 
        /// <returns>
        /// true if the values were useful and calling <see cref="M:System.Windows.Markup.XamlSetValueEventArgs.CallBase"/> is not necessary; otherwise, false.
        /// </returns>
        public bool Handled {  get;  set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Windows.Markup.XamlSetValueEventArgs"/> class.
        /// </summary>
        /// <param name="member">XAML type system / schema information for the member being set.</param><param name="value">The value to provide for the member.</param>
        public XamlSetValueEventArgs(XamlMember member, object value)
        {
            this.Value = value;
            this.Member = member;
        }

        /// <summary>
        /// When overridden in a derived class, provides a way to invoke a SetValue callback as defined on a base class of the current acting type.
        /// </summary>
        public virtual void CallBase()
        {
        }
    }
}