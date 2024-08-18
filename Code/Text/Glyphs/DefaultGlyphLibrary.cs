using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PP1
{
    public class DefaultGlyphLibrary : GlyphLibrary
    {
        public override void DrawLetter(Graphics graphics, Letter letter, int x, int y, int width, int height, bool flippedX = false)
        {
            // TODO: flip X, and more betterness...
            Font baseFont = HieroglyphicWordImage.GetBaseFont();
            int size = height;
            if(width < height)
            {
                size = width;
            }

            int finalSize = CalculateFontSize(baseFont, size);
            int sizeDifference = finalSize - size;

            Font finalFont = new Font(baseFont.Name, finalSize);
            TextRenderer.DrawText(
                graphics, letter.IsolatedForm(), finalFont, new Point(x, y + sizeDifference),
                Color.Black, HieroglyphicWordImage.TightTextFormatFlags);
        }

        protected int CalculateFontSize(Font originalFont, int targetSize)
        {
            FontFamily family = originalFont.FontFamily;
            int descent = family.GetCellDescent(originalFont.Style);
            int emHeight = family.GetEmHeight(originalFont.Style);
            float desiredHeightRatio = (float)emHeight / (emHeight - descent);
            return (int)(targetSize * desiredHeightRatio * 0.5f);
        }
    }
}
