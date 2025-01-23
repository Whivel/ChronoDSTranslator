using Yarhl.FileFormat;

namespace SceneGate.Games.ChronoTriggerDs
{
    public record class Msg(uint headerLength, MsgString[] messages) : IFormat;
}
