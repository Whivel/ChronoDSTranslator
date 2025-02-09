using System.IO.Abstractions;

namespace ChronoDSTranslator.Models;

public sealed class RomData
{
    public IFileInfo? File { get; set; }

    public MessageContainer Big { get; set; } = MessageContainer.Empty;
    public MessageContainer Small { get; set; } = MessageContainer.Empty;
}