using Yarhl.FileFormat;
using Yarhl.FileSystem;
using Yarhl.IO;
using Yarhl.Media.Text;

namespace SceneGate.Games.ChronoTriggerDs
{
    public class BinaryMsgToPo : IConverter<IBinary, NodeContainerFormat>
    {
        public NodeContainerFormat Convert(IBinary source)
        {
            return source.ConvertWith(new BinaryToMsg()).ConvertWith(new MsgToPo());
        }

    }
}
