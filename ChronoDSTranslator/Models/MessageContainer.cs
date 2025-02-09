namespace ChronoDSTranslator.Models;

public sealed record class MessageContainer(MessageContainerKind Kind, string Name, MsgData[] Messages, FntData Font)
{
    public static MessageContainer Empty { get; } = new(MessageContainerKind.Empty, string.Empty, [], FntData.Empty);
}