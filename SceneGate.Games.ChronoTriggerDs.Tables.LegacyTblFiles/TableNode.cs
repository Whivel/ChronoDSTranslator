using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SceneGate.Games.ChronoTriggerDs.Tables.LegacyTblFiles
{
    internal sealed record class TableNode(IDictionary<byte,TableNode> Branches, string CurrentValue);
}
