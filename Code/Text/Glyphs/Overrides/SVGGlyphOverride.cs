using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace PP1
{
    public class SVGGlyphOverride : CustomGlyphSource
    {
        public override void DrawGlyph(Graphics graphics, int x, int y, int width, int height, bool flippedX = false)
        {
            if (imageCache == null)
            {
                LoadImage();
            }

            // TODO: non square?
            int smallSide = Math.Min(width, height);
            graphics.DrawImage(imageCache, new Rectangle(new Point(x, y), new Size(smallSide, smallSide)));
        }

        public override bool FromData(IList<string> data, string basePath = "")
        {
            if (data.Count < 2)
            {
                return false;
            }

            letter = Letters.LookupGardinerSign(data[0]);
            imagePath = data[1];
            if (File.Exists(imagePath) == false)
            {
                imagePath = Path.Combine(basePath, imagePath);
                if (File.Exists(imagePath) == false)
                {
                    imagePath += ".svg";
                    if (File.Exists(imagePath) == false)
                    {
                        return false;
                    }
                }
            }

            // check for the file (!)
            LoadImage();
            if (imageCache == null)
            {
                return false;
            }
            return true;
        }

        public override string[] GetData(string basePath = "")
        {
            string[] data = new string[2];
            data[0] = letter.Transliteration();
            data[1] = Path.GetRelativePath(basePath, imagePath);
            return data;
        }

        public override string GetIdentifierString()
        {
            return "SVG";
        }

        public override string GetFriendlyName()
        {
            return "SVG Image";
        }

        public override Letter GetLetter()
        {
            return letter;
        }

        private void LoadImage()
        {
            if (System.IO.File.Exists(imagePath))
            {
                imageCache = Bitmap.FromFile(imagePath);
            }
        }

        private Image imageCache = null;
        private string imagePath = "";
        private Letter letter = Letters.NoLetter;
    }
}
