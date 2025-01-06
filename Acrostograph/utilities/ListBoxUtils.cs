using System.Linq;
using System.Windows.Forms;

namespace Acrostograph.utilities
{
    class ListBoxUtils
    {
        /// <summary>
        /// Moves the selected line up one line in a ListBox. 
        /// </summary>
        /// <param name="myListBox"></param>
        /// <param name="SelectedIndex"></param>
        public static void MoveLineUp(ListBox myListBox, int SelectedIndex)
        {
            int selectedIndex = myListBox.SelectedIndex;

            if (selectedIndex > 0)
            {
                // Get the selected item
                var selectedItem = myListBox.Items[selectedIndex];

                // Remove the selected item
                myListBox.Items.RemoveAt(selectedIndex);

                // Insert the selected item at the new position
                myListBox.Items.Insert(selectedIndex - 1, selectedItem);

                // Reselect the moved item
                myListBox.SelectedIndex = selectedIndex - 1;
            }
        }

        /// <summary>
        /// Moves the selected line down one line in a ListBox.
        /// </summary>
        /// <param name="myListBox"></param>
        /// <param name="SelectedIndex"></param>
        public static void MoveLineDown(ListBox myListBox, int SelectedIndex)
        {
            if (SelectedIndex >= 0 && SelectedIndex < myListBox.Items.Count - 1)
            {
                object selectedItem = myListBox.SelectedItem;

                // Remove the selected item
                myListBox.Items.RemoveAt(SelectedIndex);

                // Insert it back at the next position
                myListBox.Items.Insert(SelectedIndex + 1, selectedItem);

                // Reselect the moved item
                myListBox.SelectedIndex = SelectedIndex + 1;
            }
        }

        /// <summary>
        /// Deletes the hidghlighted line in a ListBox
        /// </summary>
        /// <param name="myListBox"></param>
        /// <param name="SelectedIndex"></param>
        public static void DeleteLine(ListBox myListBox, int SelectedIndex)
        {
            // Check if an item is selected
            if (SelectedIndex != -1)
            {
                // Remove the selected item
                myListBox.Items.RemoveAt(SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
            }
        }
    }
}
