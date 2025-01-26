using Microsoft.Extensions.FileProviders;
using System.Collections;

namespace SceneGate.Games.ChronoTriggerDs.Tables.LegacyTblFiles.Providers
{
    public class TblDirectoryContents : IDirectoryContents
    {
        private const string TBL_EXTENSIONS = ".tbl";
        private readonly IDirectoryContents _contents;
        private IEnumerable<IFileInfo> Files => _contents.Where(f => f.Exists == true && f.IsDirectory == false && f.Name.EndsWith(TBL_EXTENSIONS));
        public bool Exists => _contents.Exists;

        public TblDirectoryContents(IDirectoryContents contents)
        {
            ArgumentNullException.ThrowIfNull(contents);
            _contents = contents;
        }


        public IEnumerator<IFileInfo> GetEnumerator()
        {
            return Files.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Files.GetEnumerator();
        }
    }
}
