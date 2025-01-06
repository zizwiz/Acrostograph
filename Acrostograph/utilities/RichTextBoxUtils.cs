using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acrostograph.utilities
{
    class RichTextBoxUtils
    {
        public static void MoveLineUp(RichTextBox myRichTextBox, int lineIndex)
        {
            if (lineIndex <= 0) return;

            var lines = myRichTextBox.Lines;
            if ((lineIndex >= lines.Length)||(lineIndex <= 0)) return;

            var temp = lines[lineIndex - 1];
            lines[lineIndex - 1] = lines[lineIndex];
            lines[lineIndex] = temp;

            myRichTextBox.Lines = lines;

            //move cursor to be at same position as the line
            myRichTextBox.SelectionStart = myRichTextBox.GetFirstCharIndexFromLine(lineIndex - 1);
            myRichTextBox.ScrollToCaret();
        }

        public static void MoveLineDown(RichTextBox myRichTextBox, int lineIndex)
        {
            var lines = myRichTextBox.Lines;
            if (lineIndex < 0 || lineIndex >= lines.Length - 1) return;

            var temp = lines[lineIndex + 1];
            lines[lineIndex + 1] = lines[lineIndex];
            lines[lineIndex] = temp;

            myRichTextBox.Lines = lines;
        }

        public static void DeleteLine(RichTextBox myRichTextBox, int lineIndex)
        {
            var lines = myRichTextBox.Lines;
            if (lineIndex < 0 || lineIndex >= lines.Length) return;

            var newLines = lines.Where((line, index) => index != lineIndex).ToArray();
            myRichTextBox.Lines = newLines;
        }
    }
}
