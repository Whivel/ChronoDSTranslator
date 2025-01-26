namespace SceneGate.Games.ChronoTriggerDs.Tables.LegacyTblFiles
{
    internal sealed record class TableNode(IDictionary<byte,TableNode> Branches, string CurrentValue);
}
