using System;

namespace Avalonia.Controls
{
    public sealed class ContentPropertyAttribute : Attribute
    {
        private string _name;

        /// <summary>
        /// Gets the name of the property that is the content property.
        /// </summary>
        /// 
        /// <returns>
        /// The name of the property that is the content property.
        /// </returns>
        public string Name
        {
            
            get
            {
                return this._name;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Windows.Markup.ContentPropertyAttribute"/> class.
        /// </summary>
        
        public ContentPropertyAttribute()
        {
        }
        
        public ContentPropertyAttribute(string name)
        {
            this._name = name;
        }
    }
}