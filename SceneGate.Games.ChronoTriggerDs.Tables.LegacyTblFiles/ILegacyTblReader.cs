
namespace SceneGate.Games.ChronoTriggerDs.Tables.LegacyTblFiles
{
    internal interface ILegacyTblReader
    {
        Task<IDictionary<byte, TableNode>> ReadTablesAsync();
    }
}