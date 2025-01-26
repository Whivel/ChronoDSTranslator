using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SceneGate.Games.ChronoTriggerDs.Tables.Core
{
    //public sealed record class ConversionResultToken<T>(T TokenValue) : IConversionResult
    //{
    //    public string Text => string.Empty;
    //    public ConversionResultType Type => ConversionResultType.Token;
    //}

    //public sealed record class ConversionResultText(string Text) : IConversionResult
    //{
    //    public ConversionResultType Type => ConversionResultType.Text;
    //}

    //public sealed record class ConversionResultNone : IConversionResult
    //{
    //    public string Text => string.Empty;
    //    public ConversionResultType Type => ConversionResultType.None;

    //    public static ConversionResultNone Singleton { get; } = new ConversionResultNone();
    //}



    public sealed record class ConversionResult<T>(ConversionResultType Type, string TextValue, T? TokenValue) : IConversionResult
    {
        private bool disposedValue;

        public static IConversionResult None { get; } = new ConversionResult<T>(ConversionResultType.None, string.Empty, default);
        public static IConversionResult Text(string text) => new ConversionResult<T>(ConversionResultType.Text, text, default);
        public static IConversionResult Token(T token) => new ConversionResult<T>(ConversionResultType.Token, string.Empty, token);

        private void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
