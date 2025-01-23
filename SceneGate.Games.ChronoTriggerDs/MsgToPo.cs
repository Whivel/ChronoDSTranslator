using Yarhl.FileFormat;
using Yarhl.FileSystem;
using Yarhl.IO;
using Yarhl.Media.Text;

namespace SceneGate.Games.ChronoTriggerDs
{
    public class MsgToPo : IConverter<Msg, NodeContainerFormat>
    {
        private enum LanguageEnum
        {
            L1,
            English,
            L2,
            French,
        }

        private readonly byte VERSION = (byte)'E';
        private readonly LanguageEnum[] languages =
            [
                LanguageEnum.L1,
                LanguageEnum.English,
                LanguageEnum.L2,
                LanguageEnum.French,
            ];

        public NodeContainerFormat Convert(Msg source)
        {
            var pos = ConvertToPo(source);

            var container =  new NodeContainerFormat();
            var l1 = new Node("l1", pos[LanguageEnum.L1]);
            var en = new Node("en", pos[LanguageEnum.English]);
            var l2 = new Node("l2", pos[LanguageEnum.L2]);
            var fr = new Node("fr", pos[LanguageEnum.French]);
            container.Root.Add(en);
            container.Root.Add(fr);
            container.Root.Add(l1);
            container.Root.Add(l2);
            return container;
        }

        private Dictionary<LanguageEnum,Po> ConvertToPo(Msg source)
        {
           
            var result =  new Dictionary<LanguageEnum, Po>
            {
                { LanguageEnum.L1,new Po() },
                { LanguageEnum.English,new Po() },
                { LanguageEnum.L2,new Po() },
                { LanguageEnum.French,new Po() },
            };

            int messageLength = source.messages.Length;
            for(int i = 0; i < messageLength; i++)
            {
                var language = languages[i % 4];
                var message = source.messages[i];
             
                var po = result[language];
                var entry = GetPoEntry(po, message);
                po.Add(entry);
            }
           
            return result;
        }

        private PoEntry GetPoEntry(Po po, MsgString message)
        {
            var text =  string.Join("",message.value.Select(v => "\\" + v.ToString("X")).ToArray());
            return new PoEntry
            {
                Original = text,
                Translated = text,
            };
        }
    }
}
