using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace PP1
{
    public class PNGContent : Content
    {

        public PNGContent(string filePath)
        {
            path = filePath;
            saved = true;
        }

        public override void Draw(Graphics graphics, int x, int y, int width, int height)
        {
            if (imageCache == null)
            {
                LoadImage();
            }

            // TODO: non square? error?
            if (imageCache != null)
            {
                int smallSide = Math.Min(width, height);
                graphics.DrawImage(imageCache, new Rectangle(new Point(x, y), new Size(smallSide, smallSide)));
            }
        }

        private void LoadImage()
        {
            if(path == "")
            {
                return;
            }

            imageCache = Bitmap.FromFile(path);
        }

        public override bool IsDirty()
        {
            return false;
        }

        private Image imageCache = null;
    }
}
