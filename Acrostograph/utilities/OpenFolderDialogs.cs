using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acrostograph.utilities
{
    class OpenFolderDialogs
    {
        /// <summary>
        /// Gets a List of the files in the directory by name.
        /// </summary>
        /// <param name="mySelectedPath"></param>
        /// <param name="myDescription"></param>
        /// <returns>string[] of file names</returns>
        public static string[] GetFileNames(string mySelectedPath,
                                            string myDescription)
        {
            string[] myErrorArrayString = {"999"};

            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.SelectedPath = mySelectedPath;
                folderBrowserDialog.Description = myDescription;
                folderBrowserDialog.ShowNewFolderButton = false;

                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {

                    string[] fileNameCollection =
                        new string[Directory.GetFiles(folderBrowserDialog.SelectedPath).Length];
                    List<string> myImageFileList = new List<string>(); //Use this to make list of the images to use

                    foreach (string fileName in Directory.GetFiles((folderBrowserDialog.SelectedPath)))
                    {
                        myImageFileList.Add(Path.GetFileName(fileName)); //create list of images
                    }

                    // Convert the list to an array
                    fileNameCollection = myImageFileList.ToArray(); //convert image list to string array

                    return fileNameCollection;

                }
                else
                {
                    MessageBox.Show("No directory selected.", "Directory Selection", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }

                return myErrorArrayString;

            }

        }

        /// <summary>
        /// Allows you to choose a folder or create and choose a folder
        /// </summary>
        /// <param name="mySelectedPath"></param>
        /// <param name="myDescription"></param>
        /// <returns>Folder name as a string</returns>
        public static string ChooseDirectory(string mySelectedPath,
                                             string myDescription)
        {
            string FolderName = "999";

            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.SelectedPath = mySelectedPath;
                folderBrowserDialog.Description = myDescription;
                folderBrowserDialog.ShowNewFolderButton = true;
                
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                   FolderName = folderBrowserDialog.SelectedPath;
                }
                else
                {
                    MessageBox.Show("No directory selected.", "Directory Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            return FolderName;
        }



    }
}
