using System;

using R5T.T0132;


namespace R5T.T0231.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="IDirectoryPath"/>
        public IDirectoryPath ToDirectoryPath(string value)
        {
            var output = new DirectoryPath(value);
            return output;
        }

        /// <inheritdoc cref="IFilePath"/>
        public IFilePath ToFilePath(string value)
        {
            var output = new FilePath(value);
            return output;
        }
    }
}
