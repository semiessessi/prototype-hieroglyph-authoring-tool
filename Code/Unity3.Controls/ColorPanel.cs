using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace Unity3.Controls
{
    [DefaultEvent("Click")]
    public class ColorPanel : Label
    {
        private Color _Color;
        public Color Color
        {
            get {return _Color;}
            set 
            {
                _Color = value;
                this.Invalidate();
            }
        }

        private bool _PaintColor = true;
        public bool PaintColor
        {
            get {return _PaintColor;}
            set 
            {
                _PaintColor = value;
                this.Invalidate();
            }
        }

        public override bool AutoSize
        {
            get { return false; }
            set
            { }
        }

        public ColorPanel()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);
            this.BorderStyle = BorderStyle.FixedSingle;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (!_PaintColor || _Color.IsEmpty)
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.Clear(this.BackColor);
                e.Graphics.DrawLine(Pens.Black, 0, 0, this.ClientSize.Width, this.ClientSize.Height);
                e.Graphics.DrawLine(Pens.Black, this.ClientSize.Width, 0, 0, this.ClientSize.Height);
                return;
            }

            if (_Color.A != 255)
            {
                bool b = false;
                Rectangle r = new Rectangle(0,0,8,8);
                e.Graphics.Clear(Color.White);
                for (r.Y = 0; r.Y < this.Height; r.Y += 8)
                    for (r.X = ((b = !b) ? 0 : 8); r.X < this.Width; r.X += 16)
                        e.Graphics.FillRectangle(Brushes.LightGray, r);     
            }

            using (SolidBrush br = new SolidBrush(_Color))
            {
                e.Graphics.FillRectangle(br, this.ClientRectangle);
            }
        }

    }
}
