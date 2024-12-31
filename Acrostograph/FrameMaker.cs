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
        public static void SplitVideoIntoImages(string videoPath, RichTextBox myRichTextBox, PictureBox myPictureBox,
        string myImageOutput)
        {
            // Create a VideoCapture object
            using (VideoCapture capture = new VideoCapture(videoPath))
            {
                int frameCount = (int) capture.GetCaptureProperty(CapProp.FrameCount);        
                int frameRate = (int)capture.GetCaptureProperty(CapProp.Fps);       

                myRichTextBox.AppendText("FrameCount = " + frameCount + "\r");
                myRichTextBox.AppendText("FrameRate = " + frameRate + "\r");
                
                for (int i = 0; i < frameCount; i++)
                {
                    // Read the frame
                    using (Mat frame = capture.QueryFrame())
                    {
                        if (frame == null) break;

                        // Convert frame to Bitmap
                        Bitmap bitmap = frame.ToBitmap();

                        // Save the frame as an image
                        string imagePath = Path.Combine(myImageOutput, $"{i:D4}.png");
                        bitmap.Save(imagePath);

                        // show what we have just saved
                        myRichTextBox.AppendText($"Saved Image: {i:D4}.png\r");
                        myRichTextBox.ScrollToCaret();
                        myPictureBox.Image = new Bitmap(imagePath);
                    }

                    GC.Collect();
                }

                if (frameCount > 1)
                {
                    myRichTextBox.AppendText("\rExtracted " + frameCount + " frames to:\r");
                    myRichTextBox.AppendText(myImageOutput + "\r");
                }
                else if (frameCount == 0)
                {
                    myRichTextBox.AppendText("\rNo frames extracted.\r");
                }
                else
                {
                    myRichTextBox.AppendText("\rExtracted " + frameCount + " frame to:\r");
                    myRichTextBox.AppendText(myImageOutput + "\r");
                }
                
                
                myRichTextBox.ScrollToCaret();
            }
        }








    }
}
