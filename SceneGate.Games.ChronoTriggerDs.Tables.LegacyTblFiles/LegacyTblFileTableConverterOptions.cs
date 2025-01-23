using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SceneGate.Games.ChronoTriggerDs.Tables.LegacyTblFiles
{
    public sealed record class LegacyTblFileTableConverterOptions
    {
        public required DirectoryInfo RootDirectory { get; set; }
    }
}
