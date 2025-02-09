using Microsoft.Extensions.FileProviders;
using SceneGate.Games.ChronoTriggerDs.Tables.LegacyTblFiles.Exceptions;
using SceneGate.Games.ChronoTriggerDs.Tables.LegacyTblFiles.Providers;
using System.Collections.Immutable;

namespace SceneGate.Games.ChronoTriggerDs.Tables.LegacyTblFiles
{

    internal sealed class LegacyTblReader : ILegacyTblReader
    {
        private const int MAX_INCLUDE_DEPTH = 2;
        private const string INCLUDE_COMMAND = ".include ";
        private const int INCLUDE_COMMAND_LENGTH = 9;
        private const string INCLUDE_DIR = "include";
        private static readonly char[] TABLE_SEPARATOR = ['='];

        private readonly ITblFileProvider _fileProvider;

        public LegacyTblReader(ITblFileProvider fileProvider)
        {
            ArgumentNullException.ThrowIfNull(fileProvider);
            _fileProvider = fileProvider;
        }

        public async Task<IDictionary<byte, TableNode>> ReadTablesAsync()
        {
            var tblFiles = _fileProvider.GetDirectoryContents(string.Empty);
            if (tblFiles.Exists == false)
            {
                throw new DirectoryNotFoundException();
            }

            var root = new Dictionary<byte, TableNode>();
            foreach (var file in tblFiles)
            {
                await ReadTablesAsync(file, root);
            }
            return root;
        }


        private async Task ReadTablesAsync(IFileInfo file, IDictionary<byte, TableNode> root, int includeDepth = 0)
        {
            ArgumentNullException.ThrowIfNull(file);
            ArgumentOutOfRangeException.ThrowIfNegative(includeDepth);
            ArgumentOutOfRangeException.ThrowIfGreaterThan(includeDepth, MAX_INCLUDE_DEPTH);

            using var stream = file.CreateReadStream();
            using var reader = new StreamReader(stream);
            while (!reader.EndOfStream)
            {
                var line = (await reader.ReadLineAsync()) ?? "";
                if (TryHandleEmpty(line))
                {
                    continue;
                }
                if (TryHandleInclude(line, out var includeFile))
                {
                    await ReadTablesAsync(includeFile!, root, includeDepth + 1);
                    continue;
                }
                if (TryHandleAssignment(line, out var key, out var value))
                {
                    AddToBranches(key, value, root);
                    continue;
                }
                throw new TableLineException(line);

            }
        }

        private bool TryHandleInclude(string line, out IFileInfo? includeFile)
        {
            includeFile = null;
            line = line.Trim();
            if (!line.StartsWith(INCLUDE_COMMAND))
            {
                return false;
            }
            var fileName = line[INCLUDE_COMMAND_LENGTH..];
            if (!fileName.EndsWith(".tbl"))
            {
                throw new IncludeCommandFilenameException(fileName);
            }
            var file = _fileProvider.GetFileInfo(fileName);
            if (!file.Exists)
            {
                throw new IncludeCommandFileNotFoundException(fileName);
            }
            includeFile = file;
            return true;
        }

        private static bool TryHandleEmpty(string line)
        {
            return string.IsNullOrWhiteSpace(line);
        }

        private static bool TryHandleAssignment(string line, out byte[] key, out string value)
        {
            key = [];
            value = string.Empty;

            line = line.TrimStart();
            var parts = line.Split(TABLE_SEPARATOR, 2);
            if (parts.Length != 2)
            {
                return false;
            }

            var keyStr = parts[0];
            if (string.IsNullOrEmpty(keyStr) || keyStr.Length % 2 != 0)
            {
                return false;
            }

            try
            {
                key = Convert.FromHexString(keyStr);
                value = parts[1];

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        private static void AddToBranches(byte[] key, string value, in IDictionary<byte, TableNode> branches)
        {
            var lastNodeBranch = branches;
            //navigate the tree until the second last node
            for (int i = 0; i < key.Length - 1; i++)
            {
                var currentKey = key[i];
                //there is already a node with the current key (sequence key[0..i])
                if (branches.TryGetValue(currentKey, out var node))
                {
                    lastNodeBranch = node.Branches;
                    continue;
                }

                //create a new node with the current key but without "translation"
                var nextNode = new TableNode(new Dictionary<byte, TableNode>(), string.Empty);
                lastNodeBranch.Add(currentKey, nextNode);
                lastNodeBranch = nextNode.Branches;
            }
            //lastNodeBranch is the second last node (sequence key[0..key.Length-2])
            var lastKey = key[^1];
            if (lastNodeBranch.TryGetValue(lastKey, out _))
            {
                //there is already a node with key sequence
                throw new DuplicateTableKeyException(key);
            }

            //create a new node with the last key and the "translation" value
            lastNodeBranch.Add(lastKey, new TableNode(ImmutableDictionary<byte, TableNode>.Empty, value));


        }
    }
}