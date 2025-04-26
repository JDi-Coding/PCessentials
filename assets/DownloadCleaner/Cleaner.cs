using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadCleanerV2.assets
{
    public class Cleaner : Config
    {
        //TODO: Implement the Cleaner Class
        // LOGIC to move the Files to the respective folders
        public Cleaner()
        {
            DownloadFolderPath = SetDownloadFolderPath();
            _FolderNames = new string[] {
                "Images", "Video",
                "Audio",  "Zips",
                "Office","Installations",
                "Sys-Image", "Code",
                "Ohter"
            };
            CreateFolders(DownloadFolderPath, _FolderNames);
        }
        public void StartCleaning()
        {
            Files = GetFiles(DownloadFolderPath);
            Folders = GetFolders(DownloadFolderPath);
            foreach (string File in Files)
            {
                //should be D:/Downloads/FileName.Extension
                string fExt = System.IO.Path.GetExtension(File);

                MoveFile(File, DecideFolder(fExt));
            }
        }

        /// <summary>
        /// Method <c> DecideFolder </c> returns the folder name based on the file extension.
        /// </summary>
        /// <param name="File"></param>
        /// <param name="Folder"></param>
        private void MoveFile(string File, string Folder)
        {
            try
            {
                if (System.IO.File.Exists(File))
                {
                    string DestinationPath = DownloadFolderPath + "\\"+ Folder + "\\" + System.IO.Path.GetFileName(File);
                    if(!System.IO.File.Exists(DestinationPath))
                    {
                        System.IO.File.Move(File, DestinationPath);
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error in Moving File");
            }
        }
    }

}
