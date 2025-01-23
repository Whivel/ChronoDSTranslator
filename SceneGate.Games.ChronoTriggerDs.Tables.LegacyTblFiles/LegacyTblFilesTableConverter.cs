using Microsoft.Extensions.Options;
using SceneGate.Games.ChronoTriggerDs.Tables.Core;
using System.Collections.Immutable;

namespace SceneGate.Games.ChronoTriggerDs.Tables.LegacyTblFiles
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
                lock(_tableLock)
                {
                    return !ReferenceEquals(_tables, EMPTY);
                }
            }
        }

        // ILegacyTblReader is used for testing purposes.
        internal LegacyTblFilesTableConverter(IOptionsMonitor<LegacyTblFileTableConverterOptions> options, ILegacyTblReader tblReader)
        {
            _tblReader = tblReader;
            UpdateOptions(options.CurrentValue, null);
            options.OnChange(UpdateOptions);
        }

        public LegacyTblFilesTableConverter(IOptionsMonitor<LegacyTblFileTableConverterOptions> options) : this(options, new LegacyTblReader())
        {
        }

        private void UpdateOptions(LegacyTblFileTableConverterOptions options, string? _)
        {
            lock (_tableLock)
            {
                // Reset the tables to empty while loading the new tables. That way, we can check if the tables are ready.
                _tables = EMPTY;
                _tblReader.FromDirectoryAsync(options.RootDirectory).ContinueWith(t => UpdateTable(t.Result));
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

        public ConversionResult Next(byte value)
        {
            throw new NotImplementedException();
        }
    }
}
