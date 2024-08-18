using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Unity3.Controls
{
    public partial class QuickColor : DropDownControl
    {
        private Color _Color = Color.White;
        public Color Color
        {
            get {return _Color;}
            set 
            {
                isUpdating = true;
                _Color = value;
                if (value == Color.Empty)
                    btnNoColor.Focus();
                colorPanel1.Color = _Color;
                colorGrid1.Color = value;
                OnColorChanged();
                isUpdating = false;
            }
        }
        private bool isUpdating = true;

        public QuickColor()
        {
            isUpdating = true;
            InitializeComponent();
            InitializeDropDown(pnlControls);
            this.btnNoColor.Focus();
            isUpdating = false;
        }

        private void colorPanel1_Click(object sender, EventArgs e)
        {
            OpenDropDown();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            colorPanel1.Bounds = AnchorClientBounds;
            lblNoColor.Bounds = AnchorClientBounds;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.FromArgb(193, 210, 238);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = pnlControls.BackColor;
        }

        private void colorGrid1_SelectedIndexChange(object sender, EventArgs e)
        {
            if (isUpdating) return;
            this.Color = colorGrid1.Color;
            colorPanel1.Visible = true;
            this.CloseDropDown();
            OnColorChanged();
        }

        public event EventHandler ColorChanged;
        protected void OnColorChanged()
        {
            if (ColorChanged != null)
                ColorChanged(null, null);
        }

        private void btnNoColor_Click(object sender, EventArgs e)
        {
            colorPanel1.Color = Color.Empty;
            colorPanel1.Visible = false;
            lblNoColor.Visible = true;
            this.CloseDropDown();
            OnColorChanged();
        }

        private void btnMoreSolidColors_Click(object sender, EventArgs e)
        {
            if (isUpdating) return;
            this.FreezeDropDown(false);
            ColorChooser frm = new ColorChooser(_Color);
            if (frm.ShowDialog() != DialogResult.Cancel && !frm.Color.Equals(_Color))
            {
                this.Color = frm.Color;
                colorPanel1.Visible = true;
                lblNoColor.Visible = false;
                this.CloseDropDown();
                OnColorChanged();
            }
            else
                this.UnFreezeDropDown();
        }
    }
}
