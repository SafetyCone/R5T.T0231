using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0231
{
    /// <summary>
    /// Strongly-types a string as a file path.
    /// </summary>
    /// <remarks>
    /// See also: R5T.T0180.IFilePath (non-rooted IFilePath, participating in an IPath:string inheritance hierarchy).
    /// </remarks>
    [StrongTypeMarker]
    public interface IFilePath : IStrongTypeMarker,
        ITyped<string>
    {
    }
}