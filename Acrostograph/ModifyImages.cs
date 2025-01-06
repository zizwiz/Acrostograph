using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Acrostograph.utilities;

namespace Acrostograph
{
    class ModifyImages
    {
        private static PictureBox thePictureBox;
        private static ListBox theListBox;
        private static Label theLabel;

        /// <summary>
        /// Goes to the directory indicated and gets all the image files out and dinsplys them in the FlowLayoutPanel.
        /// </summary>
        /// <param name="myFlowLayoutPanel"></param>
        /// <param name="myDirectory"></param>
        /// <param name="myPictureBox"></param>
        /// <param name="myListBox"></param>
        /// <param name="myLabel"></param>
        public static void ShowAllImages(FlowLayoutPanel myFlowLayoutPanel, string myDirectory, 
            PictureBox myPictureBox, ListBox myListBox, Label myLabel)
        {
            thePictureBox = myPictureBox;
            theListBox = myListBox;
            theLabel = myLabel;

            // Clear existing thumbnails
            myFlowLayoutPanel.Controls.Clear();

            // Get all image files in the directory
            string[] imageFiles = Directory.GetFiles(myDirectory, "*.*")
                .Where(file => file.ToLower().EndsWith("jpg") ||
                               file.ToLower().EndsWith("jpeg") ||
                               file.ToLower().EndsWith("png") ||
                               file.ToLower().EndsWith("bmp") ||
                               file.ToLower().EndsWith("gif"))
                .ToArray();


            foreach (string fileName in imageFiles)
            {
                Bitmap myBitmap = new Bitmap(fileName);
                double ratio = (double)myBitmap.Height / (double)myBitmap.Width;


                // Create a PictureBox for each image
                PictureBox picBox = new PictureBox
                {
                    //Image = new Bitmap(fileName),
                    Image = myBitmap,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Width = 100,
                    Height = (int)(ratio * 100),
                    Tag = fileName // Store the file path in the Tag property
                };

                Label picBoxLabel = new Label
                {
                    Text = Path.GetFileName(fileName),
                };

                // Add click event to select the image
                picBox.Click += PicBox_Click;

                // Add the PictureBox to the FlowLayoutPanel
                myFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
                myFlowLayoutPanel.Controls.Add(picBox);
                myFlowLayoutPanel.Controls.Add(picBoxLabel);
               // myFlowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
            }
        }

        /// <summary>
        /// Click on the image to add it to the list of images in the ListImageBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void PicBox_Click(object sender, EventArgs e)
        {
            PictureBox picBox = sender as PictureBox;

            if (picBox != null)
            {
                //Get the image name
                string imageName = picBox.Tag.ToString();

                // Display the selected image in the PictureBox
                thePictureBox.Image = new Bitmap(imageName);
                theListBox.Items.Add(imageName + "\r");
                
                theLabel.Text = Path.GetFileName(imageName);
            }
        }
    } }
