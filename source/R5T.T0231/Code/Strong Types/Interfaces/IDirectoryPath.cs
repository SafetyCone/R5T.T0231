using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0231
{
    /// <summary>
    /// Strongly-types a string as a directory path.
    /// This is the root strong type for directory paths.
    /// </summary>
    /// <remarks>
    /// This is a root strong-type.
    /// It should not inherit from any other strong types.
    /// It can be the parent for other strong types.
    /// See also: R5T.T0180.IDirectoryPath (non-rooted IDirectoryPath, participating in an IPath:string inheritance hierarchy).
    /// </remarks>
    [StrongTypeMarker]
    public interface IDirectoryPath : IStrongTypeMarker,
        ITyped<string>
    {
    }
}