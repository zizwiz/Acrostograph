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
        private static RichTextBox theRichTextBox;
        private static Label theLabel;

        public static void ShowAllImages(FlowLayoutPanel myFlowLayoutPanel, string myDirectory, 
            PictureBox myPictureBox, RichTextBox myRichTextBox, Label myLabel)
        {
            thePictureBox = myPictureBox;
            theRichTextBox = myRichTextBox;
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

        private static void PicBox_Click(object sender, EventArgs e)
        {
            PictureBox picBox = sender as PictureBox;

            if (picBox != null)
            {
                //Get the image name
                string imageName = picBox.Tag.ToString();

                // Display the selected image in the PictureBox
                thePictureBox.Image = new Bitmap(imageName);
                theRichTextBox.AppendText(imageName + "\r");
                theRichTextBox.ScrollToCaret();

                theLabel.Text = Path.GetFileName(imageName);
            }
        }








        /*
         *public ImageSelectorForm()
           {
               // Initialize components
               flowLayoutPanel = new FlowLayoutPanel
               {
                   Dock = DockStyle.Top,
                   AutoScroll = true,
                   Height = 400
               };

               loadImagesButton = new Button
               {
                   Text = "Load Images",
                   Dock = DockStyle.Top
               };
               loadImagesButton.Click += LoadImagesButton_Click;

               selectedImagesListBox = new ListBox
               {
                   Dock = DockStyle.Fill
               };

               // Add components to the form
               Controls.Add(selectedImagesListBox);
               Controls.Add(loadImagesButton);
               Controls.Add(flowLayoutPanel);
           }

           private void LoadImagesButton_Click(object sender, EventArgs e)
           {
               // Clear previous thumbnails
               flowLayoutPanel.Controls.Clear();

               // Specify the directory to load images from
               string directoryPath = @"C:\Your\Image\Directory";

               // Get all image files in the directory
               var imageFiles = Directory.GetFiles(directoryPath, "*.*")
                                         .Where(file => file.EndsWith(".jpg") || file.EndsWith(".png") || file.EndsWith(".bmp"))
                                         .ToArray();

               foreach (var imageFile in imageFiles)
               {
                   // Create a PictureBox for each image
                   var pictureBox = new PictureBox
                   {
                       Image = Image.FromFile(imageFile),
                       SizeMode = PictureBoxSizeMode.Zoom,
                       Width = 100,
                       Height = 100,
                       Tag = imageFile // Store the file path in the Tag property
                   };

                   // Add click event to select the image
                   pictureBox.Click += PictureBox_Click;

                   // Add the PictureBox to the FlowLayoutPanel
                   flowLayoutPanel.Controls.Add(pictureBox);
               }
           }

           private void PictureBox_Click(object sender, EventArgs e)
           {
               var pictureBox = sender as PictureBox;
               if (pictureBox != null)
               {
                   string imagePath = pictureBox.Tag.ToString();
                   if (!selectedImagesListBox.Items.Contains(imagePath))
                   {
                       selectedImagesListBox.Items.Add(imagePath);
                   }
               }
           }
         */






    }
}
