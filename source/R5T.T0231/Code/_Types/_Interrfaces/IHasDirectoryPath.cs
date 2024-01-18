using System;

using R5T.T0142;


namespace R5T.T0231
{
    /// <summary>
    /// Has a strongly-typed (<see cref="IDirectoryPath"/>) directory path.
    /// </summary>
    [DataTypeMarker]
    public interface IHasDirectoryPath
    {
        IDirectoryPath DirectoryPath { get; }
    }
}
