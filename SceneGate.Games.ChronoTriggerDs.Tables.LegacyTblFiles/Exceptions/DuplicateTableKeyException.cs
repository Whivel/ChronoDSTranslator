namespace SceneGate.Games.ChronoTriggerDs.Tables.LegacyTblFiles.Exceptions
{
    internal class DuplicateTableKeyException(byte[] keys): Exception($"Duplicate table key: {string.Join("", keys ?? [])}")
    {
    }
}
