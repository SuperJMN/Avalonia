namespace Avalonia.Data.Data
{
    public enum PropertyPathTokenType
    {
        /// <summary>
        /// The token leads to another token.
        /// </summary>
        Valid,

        /// <summary>
        /// The token is the last in the chain because the requested 
        /// <see cref="PropertyPathToken.PropertyName"/> was not found on 
        /// <see cref="PropertyPathToken.Object"/>.
        /// </summary>
        Broken,

        /// <summary>
        /// The token is the last in the chain because the bound value was found and is stored
        /// in <see cref="PropertyPathToken.Object"/>.
        /// </summary>
        FinalValue
    }
}