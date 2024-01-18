using System;

using R5T.T0142;


namespace R5T.T0231
{
    [DataTypeMarker]
    public interface IWithFilePath :
        IHasFilePath
    {
        new IFilePath FilePath { get; set; }
    }
}
