using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using CenteredMessagebox;

namespace Acrostograph.utilities
{
    class ImageUtilities
    {

        // Load a bitmap without locking it.
        public static Bitmap LoadBitmapUnlocked(string file_name)
        {
            using (Bitmap bm = new Bitmap(file_name))
            {
                return new Bitmap(bm);
            }
        }

        // Apply filter to the image.
        public static bool ApplyFilterToImage(PictureBox myOriginalPictureBox, PictureBox myResultantPictureBox,
            int myChoice, CheckBox myCheckBox, DataGridView myDataGridView)
        {
            bool result = false;

            try
            {
                if (myOriginalPictureBox.Image == null)
                {
                    MsgBox.Show("No image found to work with, please open an image.",
                        "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false; //If no image do nothing
                }

                if (myChoice == 1) myCheckBox.Checked = false; // reset button pressed


                if (!myCheckBox.Checked)
                {
                    myResultantPictureBox.Invalidate();
                    myResultantPictureBox.Image = AdjustColor(myOriginalPictureBox.Image, myDataGridView); // Each change on original each time
                }
                else
                {
                    if (myResultantPictureBox.Image != null)
                    {
                        myResultantPictureBox.Image = AdjustColor(myResultantPictureBox.Image, myDataGridView); //Superimpose each change on last change
                    }
                    else
                    {
                        myResultantPictureBox.Invalidate();
                        myResultantPictureBox.Image = AdjustColor(myOriginalPictureBox.Image, myDataGridView); //if not result we need to make one
                    }
                }

                result = true;
            }
            catch (Exception e)
            {
                result = false;
            }

            return result;

        }

        // Adjust the image's colors.
        public static Image AdjustColor(Image image, DataGridView myDataGridView)
        {
            // Make the ColorMatrix.
            ColorMatrix cm = GetColorMatrix(myDataGridView);
            ImageAttributes attributes = new ImageAttributes();
            attributes.SetColorMatrix(cm);

            // Make the result image.
            return CopyImage(image, attributes);
        }

        // Return the matrix entered by the user.
        private static ColorMatrix GetColorMatrix(DataGridView myDataGridView)
        {
            float[][] values = GetMatrix(myDataGridView);
            if (values == null) return null;
            return new ColorMatrix(values);
        }

        public static Image CopyImage(Image image, ImageAttributes attributes)
        {
            Bitmap result = new Bitmap(image.Width, image.Height);
            using (Graphics gr = Graphics.FromImage(result))
            {
                Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);
                gr.DrawImage(image, rect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
            }
            return result;
        }


        public static float[][] GetMatrix(DataGridView myDataGridView)
        {
            float[][] values = { new float[5], new float[5], new float[5], new float[5], new float[5], };

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    float value;
                    if (!float.TryParse(myDataGridView[i, j].Value.ToString(), out value))
                    {
                        MessageBox.Show("Invalid entry");
                        //focus on invalid cell
                        myDataGridView.CurrentCell = myDataGridView.Rows[i].Cells[j];
                        return null;
                    }

                    values[i][j] = value;
                }
            }

            return values;
        }
    }
}
