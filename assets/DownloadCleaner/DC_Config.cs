using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadCleanerV2.assets
{
    /// <summary>
    /// Class <c> Config </c> is a class that contains the configuration of the application.
    /// 
    /// Here we have the "DownloadFolderPath", Files and Folders Location.
    /// </summary>
    public class DC_Config : Folders
    {
        public static string DownloadFolderPath;

        /// <summary>
        /// Files is an array of strings that contains the list of files in the DownloadFolderPath.
        /// </summary>
        protected string[] Files;

        /// <summary>
        /// Folders is an array of strings that contains the list of folders in the DownloadFolderPath.
        /// </summary>
        protected string[] Folders;

        /// <summary>
        /// Method <c> SetDownloadFolderPath </c> returns the path of the download folder.
        /// </summary>
        /// <returns></returns>
        public static string setDownloadFolderPath()
        {
            //get the Users Download Folder Path
            return Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "{374DE290-123F-4565-9164-39C4925E467B}", String.Empty).ToString();
        }

        /// <summary>
        /// Method <c> GetFiles </c> returns the list of files in the given path.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        protected static string[] getFiles(string path)
        {
            return System.IO.Directory.GetFiles(path);
        }

        /// <summary>
        /// Method <c> GetFolders </c> returns the list of folders in the given path.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        protected static string[] getFolders(string path)
        {
            return System.IO.Directory.GetDirectories(path);
        }
    }
}
