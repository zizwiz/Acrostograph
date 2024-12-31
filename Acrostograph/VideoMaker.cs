using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;


namespace Acrostograph
{
    class VideoMaker
    {


        public static void JoinImagesintoVideo(string imagesPath, RichTextBox myRichTextBox)
        {
            /*
    using (openFileDialog openFileDialog = new OpenFileDialog)
    {
    openFileDialog.Multiselect = true;
    //openFileDialog.InitialDirectory =
    openFileDialog.RestoreDirectory = true;
    if (openFileDialog.ShowDialog() == DialogResult.OK)
    {
    foreach (string file in OpenFileDialog.FileNames)
    {
    }
    }

    }

    int _4cc = Fourcc('M', 'J', 'P', 'G')
    VideoWriter outputVideo(filename, -1, fps, S);
    */
            string[] imageFiles = Directory.GetFiles(@"C:\Users\itobo\source\repos\Acrostograph\Acrostograph\bin\Debug\frames", "*.png");
        string outputVideoPath = @"C:\Users\itobo\source\repos\Acrostograph\Acrostograph\bin\Debug\frames\video.mp4";
            if (imageFiles.Length == 0)
        {
            MessageBox.Show("No images found in the specified directory.");
            return;
        }



        // Assuming all images are the same size
        Image<Bgr, Byte> firstImage = new Image<Bgr, Byte>(imageFiles[0]);
        int width = firstImage.Width;
        int height = firstImage.Height;
        //using (VideoWriter writer = new VideoWriter(outputVideoPath, VideoWriter.Fourcc('M', 'J', 'P', 'G'), 10, new Size(width, height), true)) //H264 = .mp4 MJPG = avi
// Fourcc = Four Digit Character Code 

            


        using (VideoWriter writer = new VideoWriter(outputVideoPath, -1, 30, new Size(width, height), true))  //-1 pops up what is available on Windows
        {

            
            foreach (string imageFile in imageFiles)
            {
                using (Image<Bgr, Byte> img = new Image<Bgr, Byte>(imageFile))
                {
                    writer.Write(img.Mat); //mat = matrix
                }
            }
        }
        MessageBox.Show("Video created successfully!");
    }











    }
}
