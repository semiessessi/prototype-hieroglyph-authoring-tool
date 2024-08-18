using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace PP1
{
    public interface IDrawing
    {
        public abstract void Draw(Graphics graphics, int x, int y, int width, int height);
    }

    public class Drawing : IDrawing
    {
        public float OutlineThicknessScale = 1.0f;
        public float XOffset = 0.0f;
        public float YOffset = 0.0f;
        public float Scale = 1.0f;
        public float Proportions = 1.0f;

        public enum Transform
        {
            Up = 0,
            Down,
            Left90,
            Right90,
            MirroredX,
            MirroredY
        }
        public Drawing()
        {

        }

        public virtual void Draw(Graphics graphics, int x, int y, int width, int height)
        {

        }
    }

    public class CompositeDrawing : Drawing
    {
        public ICollection<Drawing> Children = new List<Drawing>();

        public override void Draw(Graphics graphics, int x, int y, int width, int height)
        {
            foreach(Drawing drawing in Children)
            {
                drawing.Draw(graphics, x, y, width, height);
            }
        }
    }

    public class CircleDrawing : Drawing
    {
        public Color FillColour = Color.Red;
        public bool OutlineCircumference = true;

        // TODO: should the centre be a pixel or not?
        // one wonders what the old masters would have decided
        // ... i decided it should be in the spaces between the pixels
        // one can ask whether it is in zero or four pixels at once, or both
        // it has a reflection axis that doesn't deform the shape (...or is this bad?)
        // two semi-circles can come together as a circle (...or is this bad?)
        public override void Draw(Graphics graphics, int x, int y, int width, int height)
        {
            int min = Math.Min(width, height);
            int radius = (int)(Scale * min) / 2;

            Brush fill = new SolidBrush(FillColour);
            Pen pen = new Pen(Brushes.Black, OutlineThicknessScale);
            Rectangle rect = new Rectangle(new Point(x, y), new Size(radius, radius));
            graphics.FillEllipse(fill, rect);
            if (OutlineCircumference)
            {
                graphics.DrawEllipse(pen, rect);
            }
        }
    }

    public class SemicircleDrawing : Drawing
    {
        public Color FillColour = Color.Red;
        public bool OutlineCircumference = true;
        public bool OutlineDiameter = true;
        public Transform Orientation = Transform.Up;

        public override void Draw(Graphics graphics, int x, int y, int width, int height)
        {
            int min = Math.Min(width, height);
            int radius = (int)(Scale * min) / 2;

            Brush fill = new SolidBrush(FillColour);
            Pen pen = new Pen(Brushes.Black, OutlineThicknessScale);
            Rectangle rect = new Rectangle(new Point(x, y), new Size(radius, radius));
            graphics.FillEllipse(fill, rect);
            if (OutlineCircumference)
            {
                graphics.DrawEllipse(pen, rect);
            }
        }
    }

    public class CircleSegmentDrawing : Drawing
    {
        public Color FillColour = Color.Red;
        public bool OutlineCircumference = true;
        public bool OutlineAntiClockwideSide = true;
        public bool OutlineClockwideSide = true;
        public float Angle = 90.0f;
        public float CentreOffsetProportion = 0.0f;
        public Transform Orientation = Transform.Up;

        public override void Draw(Graphics graphics, int x, int y, int width, int height)
        {

        }
    }
}
