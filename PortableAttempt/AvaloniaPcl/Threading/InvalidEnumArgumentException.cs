using System;

namespace Avalonia.Threading
{
    public class InvalidEnumArgumentException : ArgumentException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.ComponentModel.InvalidEnumArgumentException"/> class without a message.
        /// </summary>
        
        public InvalidEnumArgumentException()
            : this((string)null)
        {
        }

        
        public InvalidEnumArgumentException(string message)
            : base(message)
        {
        }

        
        public InvalidEnumArgumentException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public InvalidEnumArgumentException(string argumentName, int invalidValue, Type enumClass)
            : base("Invalid enum Argument")
        {
        }             
    }
}
