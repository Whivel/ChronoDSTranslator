using SceneGate.Games.ChronoTriggerDs.Tables.Core;
using SceneGate.Games.ChronoTriggerDs.Tables.LegacyTblFiles.Providers;
using System.Collections.Immutable;

namespace SceneGate.Games.ChronoTriggerDs.Tables.LegacyTblFiles.Converters
{
    public sealed class LegacyTblFilesTableConverter : ITableConverter
    {
        private static readonly ImmutableDictionary<byte, TableNode> EMPTY = ImmutableDictionary<byte, TableNode>.Empty;

        private readonly object _tableLock = new();
        private IDictionary<byte, TableNode> _tables = EMPTY;
        private readonly ILegacyTblReader _tblReader;

        public bool IsReady
        {
            get
            {
                lock (_tableLock)
                {
                    return !ReferenceEquals(_tables, EMPTY);
                }
            }
        }

        // ILegacyTblReader is used for testing purposes.
        internal LegacyTblFilesTableConverter(ILegacyTblReader tblReader)
        {
            _tblReader = tblReader;
            StartUpdateTable();
        }

        public LegacyTblFilesTableConverter(ITblFileProvider tblFileProvider) : this(new LegacyTblReader(tblFileProvider))
        {


        }

        private void StartUpdateTable()
        {
            lock (_tableLock)
            {
                // Reset the tables to empty while loading the new tables. That way, we can check if the tables are ready.
                _tables = EMPTY;
                _tblReader.ReadTablesAsync().ContinueWith(t => UpdateTable(t.Result));
            }
        }

        private void UpdateTable(IDictionary<byte, TableNode> data)
        {
            lock (_tableLock)
            {
                //here even if data is empty it don't reference equal to EMPTY
                _tables = data;
            }
        }

    


        public IConversionResult Next(IConversionResult token, byte value)
        {
            ArgumentNullException.ThrowIfNull(token);
            //ricerca dall'inizio
            if(token.Type == ConversionResultType.None)
            {
                return StartSearch(value);
            }


            //continuo una ricerca precedente (tramite token)
            if (token.Type != ConversionResultType.Token)
            {
                throw new ArgumentException("IConversionResult be a Token.", nameof(token));
            }
            if (token is not ConversionResult<TableNode> tblToken)
            {
                throw new ArgumentException("IConversionResult must be LegacyTblFiles Token", nameof(token));
            }

            return NextSearch(tblToken, value);

        }

        private IConversionResult StartSearch(byte value)
        {
            lock (_tableLock)
            {
                return InternalNavigateTable(_tables, value);
            }
        }

        private IConversionResult NextSearch(ConversionResult<TableNode> tblToken,  byte value)
        {
            var table = tblToken.TokenValue?.Branches ?? ImmutableDictionary<byte, TableNode>.Empty;
            lock (_tableLock)
            {
                return InternalNavigateTable(table, value);
            }
        }

        private IConversionResult InternalNavigateTable(IDictionary<byte, TableNode> table, byte value)
        {
            if (!table.TryGetValue(value, out var node))
            {
                return ConversionResult<TableNode>.None;
            }

            if (node.Branches.Count == 0)
            {
                return ConversionResult<TableNode>.Text(node.CurrentValue);
            }
            return ConversionResult<TableNode>.Token(node);
        }
    }
}
