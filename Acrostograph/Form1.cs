using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acrostograph.utilities;
using WMPLib;

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
            openImageFileDialog.FilterIndex = 1;
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

                //string myFileName = Path.GetFileNameWithoutExtension(openImageFileDialog.FileName);

                //ApplyFilterToImage(0);
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

        private void btn_open_video_Click(object sender, EventArgs e)
        {
            WinMediaPlayer.URL = @"robot2.mp4";
            WinMediaPlayer.Ctlcontrols.pause();
        }

        private void btn_close_video_Click(object sender, EventArgs e)
        {
            WinMediaPlayer.Ctlcontrols.stop();
        }

        private void WinMediaPlayer_MediaError(object sender, AxWMPLib._WMPOCXEvents_MediaErrorEvent e)
        {
            try
                // If the Player encounters a corrupt or missing file, 
                // show the hexadecimal error code and URL.
            {
                IWMPMedia2 errSource = e.pMediaObject as IWMPMedia2;
                IWMPErrorItem errorItem = errSource.Error;
                MessageBox.Show("Error " + errorItem.errorCode.ToString("X")
                                         + " in " + errSource.sourceURL);
            }
            catch (InvalidCastException)
                // In case pMediaObject is not an IWMPMedia item.
            {
                MessageBox.Show("Error.");
            }
        }
    }
}
