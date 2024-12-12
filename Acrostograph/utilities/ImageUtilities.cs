using System.Drawing;

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
    }
}
