using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SceneGate.Games.ChronoTriggerDs.Tables.LegacyTblFiles.Exceptions
{
    internal class DuplicateTableKeyException(byte[] keys): Exception($"Duplicate table key: {string.Join("", keys ?? [])}")
    {
    }
}
