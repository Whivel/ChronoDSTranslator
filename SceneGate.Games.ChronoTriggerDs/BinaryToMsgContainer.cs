using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yarhl.FileFormat;
using Yarhl.FileSystem;
using Yarhl.IO;

namespace SceneGate.Games.ChronoTriggerDs
{

    public class BinaryToMsgContainer : IConverter<IBinary, NodeContainerFormat>
    {
        private const int MIN_LENGTH = 0x10;
        private readonly byte[] MAGIC_NUMBER = { (byte)'T', (byte)'E', (byte)'X', (byte)'T' };

        private const int BUFFER_SIZE = 0x1000;
        private readonly byte[] buffer = new byte[BUFFER_SIZE];


        public NodeContainerFormat Convert(IBinary source)
        {
            var stream = source.Stream;

            if (stream is null)
            {
                throw new ArgumentNullException(nameof(stream));
            }
            if (stream is not { Length: > MIN_LENGTH })
            {
                throw new ArgumentException("The stream is too short", nameof(stream));
            }

            using BinaryReader reader = new BinaryReader(stream, Encoding.Default, true);

            //00 - 03: Zero padding
            int zeroPadding = reader.ReadInt32();
            if (zeroPadding != 0)
            {
                throw new ArgumentException("The zero padding is not zero", nameof(stream));
            }

            //04 - 07: Magic number
            byte[] magicNumber = reader.ReadBytes(4);
            if (!MAGIC_NUMBER.SequenceEqual(magicNumber))
            {
                throw new ArgumentException("The magic number is not the expected one", nameof(stream));
            }

            //08 - 0B: block header length
            uint headerLengthTmp = reader.ReadUInt32();
            uint headerLength = headerLengthTmp / 0x10 + (headerLengthTmp & 0xff);


            //0C - 0F: block length of msg
            uint readedSize = reader.ReadUInt32();
            if (readedSize != stream.Length)
            {
                throw new ArgumentException("The stream length is not the same as the readed size", nameof(stream));
            }

            var messages = ReadMsgStrings(reader, headerLength - 4, readedSize);
            var result = new NodeContainerFormat();
            result.Root.Add(new Node("msg", new Msg(headerLength, messages)));
            return result;
        }

        private MsgString[] ReadMsgStrings(BinaryReader reader, uint headerLength,uint blockLength)
        {
            var stream = (DataStream)reader.BaseStream;


            uint headerCount = headerLength / 4;
            var messages = new MsgString[headerCount];


            uint startLocation = reader.ReadUInt32();
            for (int i = 0; i < headerCount; i++)
            {
                //la posizione finale è la posizione iniziale del prossimo messaggio
                uint endLocation = i == headerCount - 1 ? blockLength : reader.ReadUInt32();
                messages[i] = ReadMsgString(reader, startLocation, endLocation);
                startLocation = endLocation;
            }
            return messages;
        }

        private MsgString ReadMsgString(BinaryReader reader, uint startLocation, uint endLocation)
        {
            var baseStream = (DataStream)reader.BaseStream;
            baseStream.PushToPosition(startLocation, System.IO.SeekOrigin.Begin);
            var readed = reader.ReadBytes((int)(endLocation - startLocation));
            baseStream.PopPosition();
            //non serve il + 1 perché endLocation è il byte dopo l'ultimo byte del messaggio
            return new MsgString(readed);
        }

    }
}
