using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.IO;
using System.Text;

namespace PP1
{
    public interface IContent
    {
        public abstract bool HasPath();
        public abstract string GetPath();
        public abstract bool IsDirty();

        public abstract bool Save(string path);
    }

    public class Content : IContent, IDrawing, IComparable<Content>
    {
        public enum Type
        {
            Generic,
            Text,
            Layout,
            Image
        }

        public static Content CreateFromFile(string path)
        {
            if (File.Exists(path) == false)
            {
                return null;
            }

            string data = File.ReadAllText(path);
            if (data.Length > 4)
            {
                string id4 = data.Substring(0, 4);
                switch (id4)
                {
                    case "‰PNG": return new PNGContent(path);
                    case "PANE": return new PanelContent(data, path);
                    case "PP1F": // don't allow loading projects (yet! allowing referencing them, or parts of them would be good work)
                    {
                        return null;
                    }
                    default: break;
                }
            }

            return new TextContent(data, path);
        }

        public virtual bool HasPath()
        {
            return (saved == true) && (path != "");
        }

        public virtual string GetPath()
        {
            return path;
        }

        public virtual bool IsDirty()
        {
            return isDirty;
        }

        public virtual void Draw(Graphics graphics, int x, int y, int width, int height)
        {
            throw new NotImplementedException("Draw is not implemented on this content type!");
        }

        public int CompareTo(Content obj)
        {
            if(obj == null)
            {
                return path.CompareTo(null);
            }

            return path.CompareTo(obj.path);
        }

        public bool Save()
        {
            if(path == "")
            {
                // TODO: show dialog prompt and do a save as (!!!)
                return false;
            }

            return Save(path);
        }

        public virtual bool Save(string path)
        {
            return false;
        }

        protected string path = "";
        protected bool saved = false;
        protected bool isDirty = false;
    }
}
