using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SceneGate.Games.ChronoTriggerDs.Tables.LegacyTblFiles.Exceptions
{
    internal class TableLineException(string line): Exception($"Invalid table line: {line}")
    {
    }
}
