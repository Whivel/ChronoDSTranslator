using Yarhl.FileFormat;

namespace SceneGate.Games.ChronoTriggerDs
{
    public record class MsgString(byte[] value) : IFormat;
}
