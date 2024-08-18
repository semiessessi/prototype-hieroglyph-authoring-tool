using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace PP1
{
    public class CustomGlyphSource : ICustomGlyphSource
    {
        public static ICustomGlyphSource CreateFromFile(string filename)
        {
            if(File.Exists(filename) == false)
            {
                return null;
            }

            string basePath = Path.GetDirectoryName(filename);
            ICustomGlyphSource source = CreateFromDataLines(
                File.ReadAllLines(filename), basePath);
            if (source != null)
            {
                source.UpdateSourcePath(filename);
            }
            return source;
        }

        public static ICustomGlyphSource CreateFromDataLines(string[] lines, string basePath = "")
        {
            if(lines.Length < 1)
            {
                return null;
            }

            string header = lines[0].Trim();
            List<string> data = lines.ToList();
            data.RemoveAt(0);
            {
                PNGGlyphOverride test = new PNGGlyphOverride();
                if (header == test.GetIdentifierString())
                {
                    test.FromData(data, basePath);
                    return test;
                }
            }
            // ...
            return null;
        }
        public virtual void DrawGlyph(Graphics graphics, int x, int y, int width, int height, bool flippedX = false)
        {

        }

        public virtual Letter GetLetter()
        {
            return Letters.NoLetter;
        }

        public virtual string GetSourcePath()
        {
            return sourcePath;
        }

        public virtual void UpdateSourcePath(string path)
        {
            sourcePath = path;
        }

        public virtual string GetIdentifierString()
        {
            return "";
        }

        public virtual string GetFriendlyName()
        {
            return "(unknown)";
        }

        public virtual string[] GetData(string basePath = "")
        {
            return new string[0];
        }

        public virtual bool FromData(IList<string> data, string basePath = "")
        {
            return false;
        }

        private string sourcePath = "";
    }
}
