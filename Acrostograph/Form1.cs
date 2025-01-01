using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Acrostograph.utilities;

namespace Acrostograph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text += " : v" + Assembly.GetExecutingAssembly().GetName().Version; // put version number into top bar

        }

        private void btn_open_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog openImageFileDialog = new OpenFileDialog();
            openImageFileDialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|Exif Image|*.exif|" +
                                         "Png Image|*.png|Tiff Image| *.tiff";
            openImageFileDialog.FilterIndex = 2;
            openImageFileDialog.Title = "Open Image File";


            if (openImageFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (picbx_Original.Image != null) //if already an image present then clear it and collect garbage
                {
                    picbx_Original.Image = null;
                    picbx_result.Image = null;
                    GC.Collect();
                }

                //open the new image
                picbx_Original.Image = ImageUtilities.LoadBitmapUnlocked(openImageFileDialog.FileName);
            }
        }

        private void btn_change_colour_Click(object sender, EventArgs e)
        {
            int x = 3; // X-coordinate of the pixel
            int y = 3; // Y-coordinate of the pixel
            Color newColor = Color.Black; // New color for the pixel

            Bitmap myBitmap = (Bitmap)(picbx_Original.Image);
            myBitmap.SetPixel(x, y, newColor);

            picbx_result.Image = myBitmap;
        }

        string ffmpegPath = "ffmpeg.exe";
        string inputVideoPath = "";
        //string outputFolder = "";
        string duration = "";
        string videoName = "";
        //string outputFormat = "jpg";
        //string outputPath = "";
        double totalDurationInSeconds;
        //int extractionSeconds;
        //double fps;
        //double numberOfFramesForExtraction;
       // private Process extractionProc = null;

        private void btn_open_video_Click(object sender, EventArgs e)
        {
            //WinMediaPlayer.URL = @"robot2.mp4";
            //WinMediaPlayer.Ctlcontrols.pause();

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Video Files|*.mp4;*.m4v;*.mov;*.avi;*.mkv;*.wmv|All Files|*.*";
                openFileDialog.Title = "Select a Video File";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Save path
                    inputVideoPath = openFileDialog.FileName;
                    lbl_video_path.Text = inputVideoPath;
                    // For output filename formating
                    videoName = Path.GetFileNameWithoutExtension(inputVideoPath);

                    // Get video duration using ffmpeg
                    Process getVideoDuration = new Process();
                    getVideoDuration.StartInfo.FileName = ffmpegPath;
                    getVideoDuration.StartInfo.Arguments = $"-i \"{inputVideoPath}\"";
                    getVideoDuration.StartInfo.UseShellExecute = false;
                    getVideoDuration.StartInfo.RedirectStandardError = true;
                    getVideoDuration.StartInfo.CreateNoWindow = true;
                    getVideoDuration.Start();
                    string getVideoDurationOutput = getVideoDuration.StandardError.ReadToEnd();
                    getVideoDuration.WaitForExit();

                    // Parse the FFmpeg output to extract the video duration
                    if (!string.IsNullOrEmpty(getVideoDurationOutput))
                    {
                        int index = getVideoDurationOutput.IndexOf("Duration: ");
                        if (index >= 0)
                        {
                            string durationString = getVideoDurationOutput.Substring(index + 10, 12);
                            duration = durationString.Replace(",", "");
                        }
                    }
                    // Convert the duration string to a TimeSpan
                    if (TimeSpan.TryParse(duration, out TimeSpan videoDuration))
                    {
                        // FFmpeg rounds down video length if there's 0 in the first decimal place when extracting frames
                        string totalDurationInSecondsTest = videoDuration.TotalSeconds.ToString(); // Convert the number to a string
                        int decimalPointIndexDur = totalDurationInSecondsTest.IndexOf('.');
                        if (decimalPointIndexDur != -1 && decimalPointIndexDur + 1 < totalDurationInSecondsTest.Length && totalDurationInSecondsTest[decimalPointIndexDur + 1] == '0')
                        {
                            totalDurationInSeconds = Math.Floor(videoDuration.TotalSeconds);
                        }
                        else
                        {
                            totalDurationInSeconds = videoDuration.TotalSeconds;
                        }


                        lbl_tot_video_time.Text = "Total Video Time: " + totalDurationInSeconds;


                        //// Set trackBar size
                        //trackBar.Maximum = (int)totalDurationInSeconds;
                        //// Duration of a video is set as last frames initial location, set Last frame maximum, restart First frame value
                        //lastFrameTimestampUpDown.Maximum = (decimal)totalDurationInSeconds;
                        //lastFrameTimestampUpDown.Value = lastFrameTimestampUpDown.Maximum;
                        //lastFrameTimestampUpDown.Value = lastFrameTimestampUpDown.Maximum;
                        //firstFrameTimestampUpDown.Value = 0;
                    }
                    // Get video fps
                    //var media = new MediaInfoWrapper(inputVideoPath);
                    //fps = media.Framerate;
                    //// FFmpeg rounds down FPS if there's 0 on the first decimal place and rounds up for every other case when extracting frames
                    //string fpsTest = fps.ToString(); // Convert the number to a string
                    //int decimalPointIndexFps = fpsTest.IndexOf('.');
                    //if (decimalPointIndexFps != -1 && decimalPointIndexFps + 1 < fpsTest.Length && fpsTest[decimalPointIndexFps + 1] == '0')
                    //{
                    //    fps = Math.Floor(fps);
                    //}
                    //else
                    //{
                    //    fps = Math.Ceiling(fps);
                    //}



                    //// Enable Buttons for frame searching
                    //EnableButtonForFrameSeaching();
                    //// Enable Extract button if you already have outputPath selected
                    //if (outputFolder != "")
                    //{
                    //    extractBtn.Enabled = true;
                    //    // Create outputPath with videoName
                    //    outputPath = Path.Combine(outputFolder, videoName + "-%d." + outputFormat);
                    //    // Enable format picker
                    //    formatPicker.Enabled = true;
                    //}

                    WinMediaPlayer.URL = inputVideoPath;
                    WinMediaPlayer.Ctlcontrols.pause();
                }
            }
        }

        private void btn_close_video_Click(object sender, EventArgs e)
        {
            WinMediaPlayer.Ctlcontrols.stop();
        }

        private void WinMediaPlayer_MediaError(object sender, AxWMPLib._WMPOCXEvents_MediaErrorEvent e)
        {
            //try
            //    // If the Player encounters a corrupt or missing file, 
            //    // show the hexadecimal error code and URL.
            //{
            //    //IWMPMedia2 errSource = e.pMediaObject as IWMPMedia2;
            //    //IWMPErrorItem errorItem = errSource.Error;
            ////    MessageBox.Show("Error " + errorItem.errorCode.ToString("X")
            ////                             + " in " + errSource.sourceURL);
            ////}
            //catch (InvalidCastException)
            //    // In case pMediaObject is not an IWMPMedia item.
            //{
            //    MessageBox.Show("Error.");
            //}
        }

        private void btn_video_to_split_Click(object sender, EventArgs e)
        { 
            string pathName = "";

            // Open the video file
           
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
               
                openFileDialog.Filter = "Video Files|*.mp4;*.m4v;*.mov;*.avi;*.mkv;*.wmv|All Files|*.*";
                openFileDialog.Title = "Select a Video File";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pathName = Path.GetDirectoryName(openFileDialog.FileName);
                    lbl_video_to_split.Text = openFileDialog.FileName;
                }
            }

            // Choose the directory to place the images in (999 = error)
            lbl_saving_imges_folder.Text = OpenFolderDialog.ChooseDirectory(pathName, "Select a Directory for the output");
            
        }

        private void btn_split_video_Click(object sender, EventArgs e)
        {
            FrameMaker.SplitVideoIntoImages(lbl_video_to_split.Text, rchtxbx_splitting_video_output, pcbx_split_images, lbl_saving_imges_folder.Text);
        }

        private void btn_video_maker_Click(object sender, EventArgs e)
        {
            VideoMaker.JoinImagesintoVideo(rchtxtbx_make_video_output);
        }

        private void btn_image_maker_rtxbx_clear_Click(object sender, EventArgs e)
        {
            rchtxbx_splitting_video_output.Clear();
            pcbx_split_images.Image = null;
        }

        private void btn_list_files_Click(object sender, EventArgs e)
        {
            rchtxbx_modify_frames_output.Clear();

            foreach (string fileName in OpenFolderDialog.GetFileNames(@"C:\Users\itobo\source\repos\Acrostograph\Acrostograph\bin\x64\Debug\output",
                         "Select a Directory for the output"))
            {
                rchtxbx_modify_frames_output.AppendText(fileName + "\r");
                rchtxbx_modify_frames_output.ScrollToCaret();
            }
        }
    }
}
