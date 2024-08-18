using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace PP1
{
    public interface ICustomGlyphSource
    {
        public abstract void DrawGlyph(Graphics graphics, int x, int y, int width, int height, bool flippedX = false);
        public abstract Letter GetLetter();
        public abstract string GetIdentifierString();
        public abstract string GetFriendlyName();
        public abstract string GetSourcePath();
        public abstract void UpdateSourcePath(string path);
        public abstract string[] GetData(string basePath = "");
        public abstract bool FromData(IList<string> data, string basePath = "");
    }

    public class GlyphLibrary
    {

        public static readonly DefaultGlyphLibrary Default = new DefaultGlyphLibrary();

        public virtual bool IsReadOnly()
        {
            return true;
        }

        public virtual bool HasPath()
        {
            return false;
        }

        public virtual string GetPath()
        {
            return "";
        }

        public virtual void Load(string path)
        {

        }

        public virtual void Save(string path)
        {
            File.WriteAllText(path, "");
        }

        public virtual void DrawLetter(Graphics g, Letter letter, int x, int y, int width, int height, bool flippedX = false)
        {
        }

        public virtual ICustomGlyphSource GetOverride(int index)
        {
            return null;
        }

        public virtual int GetOverrideCount()
        {
            return 0;
        }

        public virtual void RemoveOverride(string identifier)
        {

        }
    }
}
