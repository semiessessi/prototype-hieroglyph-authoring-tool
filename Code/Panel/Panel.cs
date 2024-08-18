using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace PP1
{

    public interface IPanel
    {
        public abstract void Draw(Graphics g, int x, int y, int width, int height);
    }

    public class Panel : IPanel
    {
        public enum Layout
        {
            None,
            Vertical,
            HorizontalLeftToRight,
            HorizontalRightToLeft,
            Mirrored
        }

        public enum Border
        {
            None,
            Single,
            Double,
            Trim,
            TrimWithStripes
        }

        public enum Seperators
        {
            None,
            Line,
            TrimmedLine,
            TrimmedLineWithStripes
        }

        public static Panel CreateFromString(string description)
        {
            string[] lines = description.Split('\n');
            //bool isImagePanel = false;
            int depth = 0;
            Panel newPanel = new Panel();
            Stack<Panel> panelStack = new Stack<Panel>();
            panelStack.Push(newPanel);
            foreach (string line in lines)
            {
                if (line == "PANE") // ignore the 4cc
                {
                    continue;
                }
                string clean = line.Trim();
                if (clean == "{")
                {
                    ++depth;
                }
                else if (clean == "}")
                {
                    panelStack.Pop();
                    --depth;
                }
                else if (depth >= 1)
                {
                    if (clean == "vertical")
                    {
                        Panel parent = panelStack.Peek();
                        panelStack.Push(new Panel());
                        parent.children.Add(panelStack.Peek());
                        panelStack.Peek().layout = Layout.Vertical;
                    }
                    else if (clean == "horizontal-left-to-right")
                    {
                        Panel parent = panelStack.Peek();
                        panelStack.Push(new Panel());
                        parent.children.Add(panelStack.Peek());
                        panelStack.Peek().layout = Layout.HorizontalLeftToRight;
                    }
                    else if (clean == "horizontal-right-to-left")
                    {
                        Panel parent = panelStack.Peek();
                        panelStack.Push(new Panel());
                        parent.children.Add(panelStack.Peek());
                        panelStack.Peek().layout = Layout.HorizontalRightToLeft;
                    }
                    else if (clean == "text")
                    {
                        Panel parent = panelStack.Peek();
                        panelStack.Push(new TextPanel());
                        parent.children.Add(panelStack.Peek());
                        panelStack.Peek().layout = Layout.None;
                    }
                    else if (clean == "image")
                    {
                        Panel parent = panelStack.Peek();
                        panelStack.Push(new TextPanel()); // TODO: make image panel.
                        parent.children.Add(panelStack.Peek());
                        panelStack.Peek().layout = Layout.None;
                    }
                    else if (clean.StartsWith("name:"))
                    {
                        int lengthToRemove = "name:".Length;
                        string value = clean.Substring(lengthToRemove, clean.Length - lengthToRemove).Trim();
                        panelStack.Peek().name = value;
                    }
                    else if (clean.StartsWith("content:"))
                    {
                        int lengthToRemove = "content:".Length;
                        string value = clean.Substring(lengthToRemove, clean.Length - lengthToRemove).Trim();
                        if(panelStack.Peek() is TextPanel)
                        {
                            (panelStack.Peek() as TextPanel).SectionName = value;
                        }
                    }
                    else if (clean.StartsWith("size:"))
                    {
                        int lengthToRemove = "size:".Length;
                        string value = clean.Substring(lengthToRemove, clean.Length - lengthToRemove).Trim();
                        double scale = Convert.ToDouble(value) / 100.0;
                        panelStack.Peek().proportion = (float)scale;
                    }
                    else if (clean.StartsWith("proportion:"))
                    {
                        int lengthToRemove = "proportion:".Length;
                        string value = clean.Substring(lengthToRemove, clean.Length - lengthToRemove).Trim();
                        double scale = Convert.ToDouble(value);
                        panelStack.Peek().proportion = (float)scale;
                    }
                    else if (clean.StartsWith("background:"))
                    {
                        int lengthToRemove = "background:".Length;
                        string value = clean.Substring(lengthToRemove, clean.Length - lengthToRemove).Trim();
                        switch (value)
                        {
                            case "black":
                            {
                                panelStack.Peek().background = Color.Black;
                                break;
                            }
                            case "white":
                            {
                                panelStack.Peek().background = Color.White;
                                break;
                            }
                            default:
                            {
                                panelStack.Peek().background = Color.HotPink;
                                break;
                            }
                        }
                    }
                }
                else if (depth == 0)
                {
                    if (clean == "vertical")
                    {
                        panelStack.Peek().layout = Layout.Vertical;
                    }
                    else if (clean == "horizontal-left-to-right")
                    {
                        panelStack.Peek().layout = Layout.HorizontalLeftToRight;
                    }
                    else if (clean == "horizontal-right-to-left")
                    {
                        panelStack.Peek().layout = Layout.HorizontalRightToLeft;
                    }
                    else if (clean == "text")
                    {
                        // error???
                    }
                }
            }

            return newPanel;
        }

        public virtual void Draw(Graphics g, int x, int y, int width, int height)
        {
            if(background != Color.Transparent)
            {
                g.FillRectangle(
                    new SolidBrush(background),
                    new Rectangle(
                        new Point(x, y),
                        new Size(width, height)));
            }
            
            switch(layout)
            {
                default:
                case Layout.None:
                {
                    // draw no children.
                    break;
                }
                case Layout.Vertical:
                {
                    int count = children.Count;
                    if (count == 1)
                    {
                        children[0].Draw(g,
                            x + borderSize + borderPadding,
                            y + borderSize + borderPadding,
                            width - 2 * (borderSize + borderPadding),
                            height - 2 * (borderSize + borderPadding));
                    }

                    // TODO: where exactly to put spare pixels?
                    int newHeight = ((height - 2 * borderSize) / count);// - seperatorPadding;
                    int startY = y + borderSize;
                    foreach(Panel child in children)
                    {
                        child.Draw(g, x + borderSize, startY, width - 2 * borderSize, newHeight);
                        startY += newHeight + borderSize;
                    }
                    break;
                }
                case Layout.HorizontalLeftToRight:
                {
                    int count = children.Count;
                    if (count == 1)
                    {
                        children[0].Draw(g,
                            x + borderSize + borderPadding,
                            y + borderSize + borderPadding,
                            width - 2 * (borderSize + borderPadding),
                            height - 2 * (borderSize + borderPadding));
                    }

                    // TODO: where exactly to put spare pixels?
                    int newWidth = ((width - 2 * borderSize) / count);// - seperatorPadding;
                    int startX = x;
                    foreach (Panel child in children)
                    {
                        child.Draw(g, startX + borderSize, y, newWidth, height - 2 * borderSize);
                        startX += newWidth;
                    }
                    break;
                }
                case Layout.HorizontalRightToLeft:
                {
                    int count = children.Count;
                    if (count == 1)
                    {
                        children[0].Draw(g, x, y, width, height);
                    }

                    // TODO: where exactly to put spare pixels?
                    int newWidth = width / count;
                    int startX = x + width - newWidth;
                    foreach (Panel child in children)
                    {
                        child.Draw(g, startX, y, newWidth, height);
                        startX -= newWidth;
                    }
                    break;
                }
            }
        }

        public float GetProportion()
        {
            return proportion;
        }

        public Layout GetDirection()
        {
            return layout;
        }

        public void SetDirection(Layout newLayout)
        {
            layout = newLayout;
        }

        public Color GetBackgroundColour()
        {
            return background;
        }

        public void SetBackgroundColour(Color colour)
        {
            background = colour;
        }

        public virtual string GetDisplayName()
        {
            if(name == "panel")
            {
                if(layout == Layout.Vertical)
                {
                    return "vertical";
                }

                if (layout == Layout.HorizontalLeftToRight)
                {
                    return "left-to-right";
                }

                if (layout == Layout.HorizontalRightToLeft)
                {
                    return "right-to-left";
                }
            }

            return name;
        }

        public virtual IList<Panel> GetChildren()
        {
            return children;
        }

        public virtual string GetSaveData(int baseIndent = 0)
        {
            string prefix = "";
            for(int i = 0; i < baseIndent; ++i)
            {
                prefix += "\t";
            }

            string data = "";
            switch(layout)
            {
                default:
                case Layout.Vertical:
                {
                    data += prefix + "vertical\n";
                    break;
                }
                case Layout.HorizontalLeftToRight:
                {
                    data += prefix + "horizontal-left-to-right\n";
                    break;
                }
            }

            data += prefix + "{\n";

            if (name != "panel")
            {
                data += prefix + "\tname: " + name + "\n";
            }

            if (background != Color.Transparent)
            {
                data += prefix + "\tbackground: ";
                if(background == Color.Black)
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

            foreach (Panel child in children)
            {
                data += child.GetSaveData(baseIndent + 1);
            }

            data += prefix + "}\n";

            return data;
        }

        private List<Panel> children = new List<Panel>();
        protected string name = "panel";
        private float aspectRatio = 1.0f;
        protected float proportion = 1.0f;
        private float heightOffset = 0.0f;
        private float widthOffset = 0.0f;
        private int borderSize = 32;
        private int seperatorSize = 8;
        private int borderPadding = 4;
        protected Color background = Color.Transparent;
        private Layout layout;
        private Border border;
    }
}
