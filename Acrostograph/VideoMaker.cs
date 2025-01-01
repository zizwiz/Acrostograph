using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;


namespace Acrostograph
{
    class VideoMaker
    {


        public static void JoinImagesintoVideo(RichTextBox myRichTextBox)
        {
            string[] imageFiles = new string[0]; //just initialise will resize later
            List<string> myImageFileList = new List<string>(); //Use this to make list of the images to use

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|Exif Image|*.exif|" +
                                              "Png Image|*.png|Tiff Image| *.tiff";
                openFileDialog.FilterIndex = 5;
                openFileDialog.Title = "Open Image Folder";
                openFileDialog.Multiselect = true;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Array.Resize(ref imageFiles, openFileDialog.FileNames.Length); // Resize Array to correct size  

                    foreach (string file in openFileDialog.FileNames)
                    {
                        myImageFileList.Add(file); //create list of images
                    }

                    // Convert the list to an array
                    imageFiles = myImageFileList.ToArray(); //convert image list to string array

                    if (imageFiles.Length == 0)
                    {
                        MessageBox.Show("No images found in the specified directory.");
                        return;
                    }


                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Video Files|*.mp4;*.avi;*.mov;*.wmv";
                        saveFileDialog.Title = "Save Video File";
                        saveFileDialog.DefaultExt = "mp4";
                        saveFileDialog.ShowDialog();

                        // If the file name is not an empty string open it for saving.
                        if (saveFileDialog.FileName != "")
                        {
                            // Assuming all images are the same size
                            Image<Bgr, Byte> firstImage = new Image<Bgr, Byte>(imageFiles[0]);
                            int width = firstImage.Width;
                            int height = firstImage.Height;
                            //using (VideoWriter writer = new VideoWriter(outputVideoPath, VideoWriter.Fourcc('M', 'J', 'P', 'G'), 10, new Size(width, height), true)) //H264 = .mp4 MJPG = avi
                            // Fourcc = Four Digit Character Code 

                            using (VideoWriter writer = new VideoWriter(saveFileDialog.FileName, -1, 30, new Size(width, height), true))  //-1 pops up what is available on Windows
                            {
                                int i = 0;

                                foreach (string imageFile in imageFiles)
                                {
                                    using (Image<Bgr, Byte> img = new Image<Bgr, Byte>(imageFile))
                                    {
                                        writer.Write(img.Mat); //mat = matrix
                                    }

                                    i++;
                                    myRichTextBox.AppendText(i + ". Adding File: " + Path.GetFileName(imageFile) + "\r");
                                    myRichTextBox.ScrollToCaret();
                                }

                                
                            }

                            myRichTextBox.AppendText("\rVideo created:\r" + saveFileDialog.FileName + "\r");
                            myRichTextBox.ScrollToCaret();
                        }

                    }
                }

            }
        }
    }
}
