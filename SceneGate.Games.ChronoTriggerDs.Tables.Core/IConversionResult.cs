
namespace SceneGate.Games.ChronoTriggerDs.Tables.Core
{
    public interface IConversionResult : IDisposable
    {
        ConversionResultType Type { get; }
        string TextValue { get; }
    }
}
