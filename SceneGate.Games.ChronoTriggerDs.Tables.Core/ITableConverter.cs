namespace SceneGate.Games.ChronoTriggerDs.Tables.Core
{
    public interface ITableConverter
    {
        IConversionResult Next(IConversionResult token, byte value);

    }
}
