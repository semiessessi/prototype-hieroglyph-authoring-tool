using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace PP1
{
    public class PanelContent : Content
    {
        public PanelContent(string data, string filePath)
        {
            path = filePath;
            panel = Panel.CreateFromString(data);
            saved = true;
        }

        public override void Draw(Graphics graphics, int x, int y, int width, int height)
        {
            panel.Draw(graphics, x, y, width, height);
        }

        public Panel GetPanel()
        {
            return panel;
        }

        protected Panel panel = null;
    }
}
