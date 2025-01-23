using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SceneGate.Games.ChronoTriggerDs.Tables.LegacyTblFiles.Exceptions
{
    internal class IncludeCommandFileNotFoundException(string filename) : FileNotFoundException($"Invalid include command: filename not found {filename}")
    {
    }
}
