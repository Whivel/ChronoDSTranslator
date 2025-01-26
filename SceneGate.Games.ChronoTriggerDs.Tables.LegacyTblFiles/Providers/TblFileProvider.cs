using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Primitives;

namespace SceneGate.Games.ChronoTriggerDs.Tables.LegacyTblFiles.Providers
{
    public class TblFileProvider : ITblFileProvider
    {
        private const string TBL_EXTENSION = ".tbl";
        private readonly IFileProvider _fileProvider;

        public TblFileProvider(IFileProvider fileProvider)
        {
            ArgumentNullException.ThrowIfNull(fileProvider);
            _fileProvider = fileProvider;
        }

        public IDirectoryContents GetDirectoryContents(string subpath)
        {
            ArgumentNullException.ThrowIfNull(subpath);

            var dirContent = _fileProvider.GetDirectoryContents("");
            if (!dirContent.Exists)
            {
                return dirContent;
            }
            return new TblDirectoryContents(dirContent);
        }

        public IFileInfo GetFileInfo(string subpath)
        {
            var fileInfo = _fileProvider.GetFileInfo(subpath);
            if (!fileInfo.Exists || fileInfo.IsDirectory || !fileInfo.Name.EndsWith(TBL_EXTENSION))
            {
                return new NotFoundFileInfo(subpath);
            }
            return fileInfo;
        }

        public IChangeToken Watch(string filter)
        {
            throw new NotImplementedException();
        }
    }
}
