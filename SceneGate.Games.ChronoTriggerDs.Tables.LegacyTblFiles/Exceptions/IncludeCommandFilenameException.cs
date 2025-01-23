using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SceneGate.Games.ChronoTriggerDs.Tables.LegacyTblFiles.Exceptions
{
    internal class IncludeCommandFilenameException(string filename) : Exception($"Invalid include command: invalid filename {filename}")
    {
    }
}
