using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadCleanerV2.assets
{
    /// <summary>
    /// Class <c> Folders </c> is a class that contains the list of folders to be created.
    /// </summary>
    public class Folders
    {
        public string[] _FolderNames; //Array of Folder Names

        /// <summary>
        /// Constructor <c> Folders </c> initializes the array of folder names.
        /// </summary>

        /// <summary>
        /// Method <c> getFoldersNames </c> returns the folder name at the given index.
        /// Its Range is 0..8
        /// 0 - Images
        /// 1 - Video
        /// 2 - Audio
        /// 3 - Zips
        /// 4 - Office
        /// 5 - Installations
        /// 6 - Sys-Image
        /// 7 - Code
        /// 8 - Other
        /// </summary>
        /// <param name="Index"></param>
        /// <returns></returns>
        public string getFoldersNames(int Index)
        {
            try
            {
                //Range 0..8
                return _FolderNames[Index];
            }
            catch (Exception)
            {
                //Return null if the index is out of range
                return null;
            }
        }

        /// <summary>
        /// Method <c> CreateFolders </c> creates the folders in the given path.
        /// </summary>
        /// <param name="path"></param>
        public void createFoldersInPath(string path, string[] Folders)
        {
            foreach (string Folder in Folders)
            {
                bool exists = System.IO.Directory.Exists(path + Folder);
                if (!exists)
                { System.IO.Directory.CreateDirectory(path + Folder); }                   
            }
        }

        public string decideFolder(string FileExtension)
        {
            switch (FileExtension)
            {
                case ".jpg":
                case ".png":
                case ".gif":
                case ".jpeg":
                case ".img":
                case ".ico":
                case ".jfif":
                case ".webp":
                case ".avif":
                case ".bmp":
                case ".svg":
                case ".eps":
                case ".tiff":
                    return getFoldersNames(0);
                case ".webm":
                case ".mkv":
                case ".flv":
                case ".vob":
                case ".avi":
                case ".mov":
                case ".wmv":
                case ".mp4":
                case ".m4p":
                case ".m4v":
                    return getFoldersNames(1);
                case ".3gp":
                case ".aa":
                case ".aac":
                case ".aax":
                case ".act":
                case ".aiff":
                case ".alac":
                case ".m4a":
                case ".m4b":
                case ".mp3":
                case ".ogg":
                case ".oga":
                case ".raw":
                case ".wav":
                case ".wma":
                    return getFoldersNames(2);
                case ".zip":
                case ".7z":
                case ".rar":
                case ".tar":
                case ".gz":
                case ".tgz":
                case ".bz2":
                case ".tbz2":
                case ".txz":
                    return getFoldersNames(3);
                case ".doc":
                case ".docx":
                case ".xls":
                case ".xlsx":
                case ".ppt":
                case ".pptx":
                case ".pdf":
                    return getFoldersNames(4);
                case ".exe":
                case ".msi":
                case ".apk":
                case ".deb":
                    return getFoldersNames(5);
                case ".iso":
                case ".vhd":
                case ".vhdx":
                case ".vmdk":
                    return getFoldersNames(6);
                case ".cs":
                case ".cpp":
                case ".c":
                case ".java":
                case ".py":
                case ".js":
                case ".html":
                case ".css":
                case ".php":
                case ".sql":
                case ".json":
                case ".xml":
                    return getFoldersNames(7);
                default:
                    return getFoldersNames(8);
            }
        }
    }
}
