using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;

namespace Acrostograph
{
    class FrameMaker
    {


        //private void btnSplitVideo_Click(object sender, EventArgs e)
        //{
        //    // Open file dialog to select video
        //    using (OpenFileDialog openFileDialog = new OpenFileDialog())
        //    {
        //        openFileDialog.Filter = "Video Files|*.mp4;*.avi;*.mov";
        //        if (openFileDialog.ShowDialog() == DialogResult.OK)
        //        {
        //            string videoPath = openFileDialog.FileName;
        //            SplitVideoIntoImages(videoPath);
        //        }
        //    }
        //}
        public static void SplitVideoIntoImages(string videoPath, RichTextBox myRichTextBox)
        {
            // Create a VideoCapture object
            using (VideoCapture capture = new VideoCapture(videoPath))
            {
                int frameCount = (int) capture.GetCaptureProperty(CapProp.FrameCount);        
                int frameRate = (int)capture.GetCaptureProperty(CapProp.Fps);       

                myRichTextBox.AppendText("FrameCount = " + frameCount + "\r");
                myRichTextBox.AppendText("FrameRate = " + frameRate + "\r");


                // Create a directory to save images
                string outputDir = Path.Combine(Path.GetDirectoryName(videoPath), "ExtractedFrames");
                Directory.CreateDirectory(outputDir);
                for (int i = 0; i < frameCount; i++)
                {
                    // Read the frame
                    using (Mat frame = capture.QueryFrame())
                    {
                        if (frame == null)
                            break;
                        // Convert frame to Bitmap
                        Bitmap bitmap = frame.ToBitmap();
                        // Save the frame as an image
                        string imagePath = Path.Combine(outputDir, $"{i:D4}.png");
                        bitmap.Save(imagePath);
                        myRichTextBox.AppendText($"Saved Image: {i:D4}.png\r");
                        myRichTextBox.ScrollToCaret();
                    }

                    GC.Collect();
                }

                myRichTextBox.AppendText($"\rFrames extracted to:\r {outputDir}\r");
                myRichTextBox.ScrollToCaret();

                // MessageBox.Show($"Frames extracted to {outputDir}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }








    }
}
