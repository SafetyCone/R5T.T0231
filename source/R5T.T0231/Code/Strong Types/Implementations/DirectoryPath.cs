using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0231
{
    /// <inheritdoc cref="IDirectoryPath"/>
    [StrongTypeImplementationMarker]
    public class DirectoryPath : TypedBase<string>, IStrongTypeMarker,
        IDirectoryPath
    {
        public DirectoryPath(string value)
            : base(value)
        {
        }
    }
}