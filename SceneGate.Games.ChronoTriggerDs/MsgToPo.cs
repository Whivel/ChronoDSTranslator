using Microsoft.Extensions.FileProviders;
using SceneGate.Games.ChronoTriggerDs.Tables.Core;
using SceneGate.Games.ChronoTriggerDs.Tables.LegacyTblFiles.Converters;
using SceneGate.Games.ChronoTriggerDs.Tables.LegacyTblFiles.Providers;
using System;
using System.Text;
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

        private readonly IFileProvider fileProvider;
        private readonly ITblFileProvider tblProvider;
        private readonly LegacyTblFilesTableConverter tblConverter;

        public MsgToPo()
        {
            fileProvider = new PhysicalFileProvider(@"C:\source\ChronoDSTranslator\tables\");
            tblProvider = new TblFileProvider(fileProvider);
            tblConverter = new LegacyTblFilesTableConverter(tblProvider);
        }

        public NodeContainerFormat Convert(Msg source)
        {
            while (!tblConverter.IsReady)
            {
                Thread.Sleep(100);
            }
            var pos = ConvertToPo(source);

            var container = new NodeContainerFormat();
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

        private Dictionary<LanguageEnum, Po> ConvertToPo(Msg source)
        {

            var result = new Dictionary<LanguageEnum, Po>
            {
                { LanguageEnum.L1,new Po() },
                { LanguageEnum.English,new Po() },
                { LanguageEnum.L2,new Po() },
                { LanguageEnum.French,new Po() },
            };

            int messageLength = source.messages.Length;
            for (int i = 0; i < messageLength; i++)
            {
                var index = i /4;
                var language = languages[i % 4];
                var message = source.messages[i];

                var po = result[language];
                var entry = GetPoEntry(po, index, message);
                po.Add(entry);
            }

            return result;
        }

        private PoEntry GetPoEntry(Po po, int index, MsgString message)
        {
            IConversionResult token = ConversionResult<object>.None;
            int start = 0;
            int current = 0;
            var value = message.value;
            var length = value.Length;
            StringBuilder sb = new StringBuilder();
            while (current < length)
            {
                token = tblConverter.Next(token, value[current]);
                current++;

                //se ha trovato il testo, lo aggiunge al buffer
                //e resetto il token
                if (token.Type == ConversionResultType.Text)
                {
                    start = current;
                    sb.Append(token.TextValue);
                    token = ConversionResult<object>.None;
                    continue;
                }

                //se non ha trovato nulla, codifica i byte
                //non resetta il token perchè è già None
                if (token.Type == ConversionResultType.None)
                {
                    var encodedBytes = string.Join("", value[start..current].Select(v => "\\" + v.ToString("X")).ToArray());
                    sb.Append(encodedBytes);
                    start = current;
                    continue;
                }

                //altrimenti è "Token", quindi non fa nulla
                //per proseguire con la ricerca
            }

            //se arrivo qui con "Token" significa che il testo è terminato 
            //prima di trovare un token, quindi lo aggiunge al buffer codificato
            if (token.Type == ConversionResultType.Token)
            {
                var encodedBytes = string.Join("", value[start..current].Select(v => "\\" + v.ToString("X")).ToArray());
                sb.Append(encodedBytes);
            }

            return new PoEntry
            {
                Context = index.ToString(),
                Original = sb.ToString(),
                Translated = sb.ToString(),
            };
        }
    }
}
