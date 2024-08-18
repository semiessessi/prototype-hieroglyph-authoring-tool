using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace PP1
{
    public class TextContent : Content
    {
        public TextContent()
        {
            saved = false;
            isDirty = true;
            textContent = new Text();
        }

        public TextContent(string data, string dataPath)
        {
            textContent = Text.CreateFromData(data.Split('\n'));
            path = dataPath;
            saved = true;
            isDirty = false;
        }

        public override void Draw(Graphics graphics, int x, int y, int width, int height)
        {
            if(textContent == null)
            {
                return;
            }

            // TODO: better?
            textContent.DrawPreview(graphics, x, y, width, height);
        }

        public Text GetText()
        {
            return textContent;
        }

        public void MarkDirty()
        {
            isDirty = true;
        }

        public IList<string> GetSectionNames()
        {
            return textContent.GetSectionNames();
        }

        public IList<Word> GetSectionByName(string name)
        {
            return Text.GetSectionByName(name);
        }

        public override bool Save(string path)
        {
            if(textContent == null)
            {
                return false; // TODO: is this ok?
            }

            string data = textContent.GetSourceString();
            File.WriteAllText(path, data);
            isDirty = false;
            return true;
        }

        private Text textContent = null;
    }
}
