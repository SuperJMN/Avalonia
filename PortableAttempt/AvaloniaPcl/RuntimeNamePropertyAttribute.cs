using System;

namespace Avalonia
{
    public sealed class RuntimeNamePropertyAttribute : Attribute
    {
        private string _name;

        /// <summary>
        /// Gets the name of the runtime name property that is specified by this <see cref="T:System.Windows.Markup.RuntimeNamePropertyAttribute"/>.
        /// </summary>
        /// 
        /// <returns>
        /// The name of the property.
        /// </returns>
        public string Name
        {
         
            get
            {
                return this._name;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Windows.Markup.RuntimeNamePropertyAttribute"/> class.
        /// </summary>
        /// <param name="name">The name of the property to use as the x:Name equivalent of the class.</param>
        
        public RuntimeNamePropertyAttribute(string name)
        {
            this._name = name;
        }
    }
}