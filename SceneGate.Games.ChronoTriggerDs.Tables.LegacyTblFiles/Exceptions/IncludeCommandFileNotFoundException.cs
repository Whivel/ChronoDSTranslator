namespace SceneGate.Games.ChronoTriggerDs.Tables.LegacyTblFiles.Exceptions
{
    internal class IncludeCommandFileNotFoundException(string filename) : FileNotFoundException($"Invalid include command: filename not found {filename}")
    {
    }
}
