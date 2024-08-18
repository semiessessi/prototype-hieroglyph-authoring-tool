using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace PP1
{
    class TextPanel : Panel
    {
        public string SectionName = "";
        public Text.Layout TextLayout = Text.Layout.LeftToRight;

        public override void Draw(Graphics g, int x, int y, int width, int height)
        {
            base.Draw(g, x, y, width, height);

            if(SectionName == "")
            {
                return;
            }

            // TODO: glyph library override?
            Text.DrawSectionByName(g, SectionName, TextLayout, x, y, width, height);
        }

        public override string GetDisplayName()
        {
            if (SectionName == "")
            {
                return "text";
            }

            return SectionName;
        }

        public override string GetSaveData(int baseIndent = 0)
        {
            string prefix = "";
            for (int i = 0; i < baseIndent; ++i)
            {
                prefix += "\t";
            }

            string data = prefix + "text\n";

            data += prefix + "{\n";

            if (name != "panel")
            {
                data += prefix + "\tname: " + name + "\n";
            }

            if (background != Color.Transparent)
            {
                data += prefix + "\tbackground: ";
                if (background == Color.Black)
                {
                    data += "black";
                }
                else if (background == Color.White)
                {
                    data += "white";
                }
                else
                {
                    data += "rgb(###,###,###)";
                }
                data += "\n";
            }

            data += prefix + "}\n";

            return data;
        }
    }
}
