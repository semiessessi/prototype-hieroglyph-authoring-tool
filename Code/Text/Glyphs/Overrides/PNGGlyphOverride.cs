using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Text;

namespace PP1
{
    public class PNGGlyphOverride : CustomGlyphSource
    {
        public override void DrawGlyph(Graphics graphics, int x, int y, int width, int height, bool flippedX = false)
        {
            if (imageCache == null)
            {
                LoadImage();
            }

            float proportion = (float)(imageCache.Width) / (imageCache.Height);
            float xProportion = (proportion < 1.0f )
                ? (float)(imageCache.Width) / imageCache.Height
                : 1.0f;
            float yProportion = (proportion >= 1.0f)
                ? (float)(imageCache.Height) / imageCache.Width
                : 1.0f;
            int smallSide = Math.Min(width, height);
            int finalWidth = (int)(smallSide * xProportion);
            int finalHeight = (int)(smallSide * yProportion);
            int finalY = y + (height - finalHeight);
            graphics.DrawImage(flippedX
                ? flippedCache : imageCache,
                new Rectangle(new Point(x, finalY),
                new Size(finalWidth, finalHeight)));
        }

        public override bool FromData(IList<string> data, string basePath = "")
        {
            if(data.Count < 2)
            {
                return false;
            }

            letter = Letters.LookupGardinerSign(data[0]);
            imagePath = data[1];
            if(File.Exists(imagePath) == false)
            {
                imagePath = Path.Combine(basePath, imagePath);
                if (File.Exists(imagePath) == false)
                {
                    imagePath += ".png";
                    if (File.Exists(imagePath) == false)
                    {
                        return false;
                    }
                }
            }

            // DONT do this! its expensive!!
            // check for the file (!)
            //LoadImage();
            //if (imageCache == null)
            //{
                //return false;
            //}
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
            return "PNG";
        }

        public override string GetFriendlyName()
        {
            return "PNG Image";
        }

        public override Letter GetLetter()
        {
            return letter;
        }

        public int GetWidth()
        {
            if (imageCache == null)
            {
                LoadImage();
            }

            return imageCache.Width;
        }

        public int GetHeight()
        {
            if (imageCache == null)
            {
                LoadImage();
            }

            return imageCache.Height;
        }

        public Image GetImage()
        {
            if (imageCache == null)
            {
                LoadImage();
            }

            return imageCache;
        }

        public Image GetSmallImage()
        {
            if (imageCache == null)
            {
                LoadImage();
            }

            return smallImage;
        }

        private const int SmallImageBaseSize = 128;
        private void LoadImage()
        {
            if(System.IO.File.Exists(imagePath))
            {
                imageCache = Bitmap.FromFile(imagePath);
                flippedCache = (Image)imageCache.Clone();
                flippedCache.RotateFlip(RotateFlipType.RotateNoneFlipX);
                int smallWidth = (int)(((float)SmallImageBaseSize * imageCache.Width)/imageCache.Height);
                smallImage = ResizeImage(imageCache, smallWidth, SmallImageBaseSize);
            }
        }

        private static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destinationRect = new Rectangle(0, 0, width, height);
            var destinationImage = new Bitmap(width, height);

            destinationImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (Graphics graphics = Graphics.FromImage(destinationImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (ImageAttributes wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destinationRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destinationImage;
        }

        private Image imageCache = null;
        private Image flippedCache = null;
        private Image smallImage = null;
        private string imagePath = "";
        private Letter letter = Letters.NoLetter;
    }
}
