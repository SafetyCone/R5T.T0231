using System;


namespace R5T.T0231.Extensions
{
    /// <summary>
    /// Extensions to create instances of the location-anonymous strong-types are also in the location-anonymous namespace.
    /// This is done since changing the location of the strong type would require client code to change their using declarations for these extension methods.
    /// </summary>
    public static class StringExtensions
    {
        /// <inheritdoc cref="IStringOperator.ToDirectoryPath(string)"/>
        public static IDirectoryPath ToDirectoryPath(this string value)
        {
            return Instances.StringOperator_Extensions.ToDirectoryPath(value);
        }

        /// <inheritdoc cref="IStringOperator.ToFilePath(string)"/>
        public static IFilePath ToFilePath(this string value)
        {
            return Instances.StringOperator_Extensions.ToFilePath(value);
        }
    }
}
