namespace SceneGate.Games.ChronoTriggerDs.Tables.LegacyTblFiles.Exceptions
{
    internal class IncludeCommandFilenameException(string filename) : Exception($"Invalid include command: invalid filename {filename}")
    {
    }
}
