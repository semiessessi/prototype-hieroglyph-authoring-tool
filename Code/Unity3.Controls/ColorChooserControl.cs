using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Unity3.Controls
{
    public partial class ColorChooserControl : UserControl
    {
        UserControl curControl = null;

        private Color _color;
        public Color Color
        {
            get {return ((IColorPicker)curControl).Color;}
            set { ((IColorPicker)curControl).Color = value; }
        }

        public ColorChooserControl()
        {
            showControl(0); //custom picker
        }

        public ColorChooserControl(Color color)
        {
            InitializeComponent();
            _color = color;
            showControl(0); //custom picker

        }

        private void btnShowColorPicker_Click(object sender, EventArgs e)
        {
            if (btnShowColorPicker.Text == "Color Picker")
            {
                showControl(0);
            }
        }

        private void showControl(byte index)
        {
            if (curControl != null)
            {
                _color = ((IColorPicker)curControl).Color;
                this.Controls.Remove(curControl);
                curControl.Dispose();
                curControl = null;
            }
            switch (index)
            {
                case 0: //custom picker
                    curControl = new CustomColorPicker(_color);
                    break;
            }
            if (curControl == null)
                throw new ArgumentException("The specified color picker could not be loaded!");

            curControl.Bounds = new Rectangle(0, 0, 350, 270);
            this.Controls.Add(curControl);
        }
    }
}
