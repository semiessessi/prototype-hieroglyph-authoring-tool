using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Unity3.Controls
{
    public partial class ColorChooser : Form
    {
        public Color Color
        {
            get {return colorPicker1.Color;}
        }

        public ColorChooser(Color color)
        {
            InitializeComponent();
            colorPicker1.Color = color;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
