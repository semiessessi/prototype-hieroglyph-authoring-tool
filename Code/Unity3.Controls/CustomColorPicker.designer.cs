using System;
namespace Unity3.Controls
{
    partial class CustomColorPicker
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Unity3.Controls.ColorManager.HSL hsl3 = new Unity3.Controls.ColorManager.HSL();
            Unity3.Controls.ColorManager.HSL hsl4 = new Unity3.Controls.ColorManager.HSL();
            this.colorBox = new Unity3.Controls.ColorBox();
            this.lblOriginalColor = new System.Windows.Forms.Label();
            this.colorSlider = new Unity3.Controls.VerticalColorSlider();
            this.rbBlue = new System.Windows.Forms.RadioButton();
            this.rbGreen = new System.Windows.Forms.RadioButton();
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.rbBrightness = new System.Windows.Forms.RadioButton();
            this.rbSat = new System.Windows.Forms.RadioButton();
            this.rbHue = new System.Windows.Forms.RadioButton();
            this.txtBlue = new System.Windows.Forms.TextBox();
            this.txtGreen = new System.Windows.Forms.TextBox();
            this.txtRed = new System.Windows.Forms.TextBox();
            this.txtBrightness = new System.Windows.Forms.TextBox();
            this.txtSat = new System.Windows.Forms.TextBox();
            this.txtHue = new System.Windows.Forms.TextBox();
            this.tbAlpha = new System.Windows.Forms.TrackBar();
            this.lblAlpha = new System.Windows.Forms.Label();
            this.colorPanelPending = new Unity3.Controls.ColorPanel();
            ((System.ComponentModel.ISupportInitialize)(this.tbAlpha)).BeginInit();
            this.SuspendLayout();
            // 
            // colorBox
            // 
            this.colorBox.DrawStyle = Unity3.Controls.ColorBox.eDrawStyle.Hue;
            hsl3.H = 0;
            hsl3.L = 1;
            hsl3.S = 1;
            this.colorBox.HSL = hsl3;
            this.colorBox.Location = new System.Drawing.Point(0, 0);
            this.colorBox.Name = "colorBox";
            this.colorBox.RGB = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorBox.Size = new System.Drawing.Size(212, 181);
            this.colorBox.TabIndex = 0;
            this.colorBox.Scroll += new System.EventHandler(this.colorBox_Scroll);
            // 
            // lblOriginalColor
            // 
            this.lblOriginalColor.BackColor = System.Drawing.SystemColors.Control;
            this.lblOriginalColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOriginalColor.Location = new System.Drawing.Point(274, 82);
            this.lblOriginalColor.Name = "lblOriginalColor";
            this.lblOriginalColor.Size = new System.Drawing.Size(60, 34);
            this.lblOriginalColor.TabIndex = 39;
            // 
            // colorSlider
            // 
            this.colorSlider.DrawStyle = Unity3.Controls.VerticalColorSlider.eDrawStyle.Hue;
            hsl4.H = 0;
            hsl4.L = 1;
            hsl4.S = 1;
            this.colorSlider.HSL = hsl4;
            this.colorSlider.Location = new System.Drawing.Point(218, 0);
            this.colorSlider.Name = "colorSlider";
            this.colorSlider.RGB = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorSlider.Size = new System.Drawing.Size(40, 181);
            this.colorSlider.TabIndex = 40;
            this.colorSlider.Scroll += new System.EventHandler(this.colorSlider_Scroll);
            // 
            // rbBlue
            // 
            this.rbBlue.Location = new System.Drawing.Point(108, 239);
            this.rbBlue.Name = "rbBlue";
            this.rbBlue.Size = new System.Drawing.Size(35, 24);
            this.rbBlue.TabIndex = 53;
            this.rbBlue.Text = "B:";
            this.rbBlue.CheckedChanged += new System.EventHandler(this.rbBlue_CheckedChanged);
            // 
            // rbGreen
            // 
            this.rbGreen.Location = new System.Drawing.Point(108, 214);
            this.rbGreen.Name = "rbGreen";
            this.rbGreen.Size = new System.Drawing.Size(35, 24);
            this.rbGreen.TabIndex = 52;
            this.rbGreen.Text = "G:";
            this.rbGreen.CheckedChanged += new System.EventHandler(this.rbGreen_CheckedChanged);
            // 
            // rbRed
            // 
            this.rbRed.Location = new System.Drawing.Point(108, 189);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(35, 24);
            this.rbRed.TabIndex = 51;
            this.rbRed.Text = "R:";
            this.rbRed.CheckedChanged += new System.EventHandler(this.rbRed_CheckedChanged);
            // 
            // rbBrightness
            // 
            this.rbBrightness.Location = new System.Drawing.Point(12, 239);
            this.rbBrightness.Name = "rbBrightness";
            this.rbBrightness.Size = new System.Drawing.Size(35, 24);
            this.rbBrightness.TabIndex = 50;
            this.rbBrightness.Text = "B:";
            this.rbBrightness.CheckedChanged += new System.EventHandler(this.rbBrightness_CheckedChanged);
            // 
            // rbSat
            // 
            this.rbSat.Location = new System.Drawing.Point(12, 214);
            this.rbSat.Name = "rbSat";
            this.rbSat.Size = new System.Drawing.Size(35, 24);
            this.rbSat.TabIndex = 49;
            this.rbSat.Text = "S:";
            this.rbSat.CheckedChanged += new System.EventHandler(this.rbSat_CheckedChanged);
            // 
            // rbHue
            // 
            this.rbHue.Location = new System.Drawing.Point(12, 189);
            this.rbHue.Name = "rbHue";
            this.rbHue.Size = new System.Drawing.Size(35, 24);
            this.rbHue.TabIndex = 48;
            this.rbHue.Text = "H:";
            this.rbHue.CheckedChanged += new System.EventHandler(this.rbHue_CheckedChanged);
            // 
            // txtBlue
            // 
            this.txtBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBlue.Location = new System.Drawing.Point(145, 239);
            this.txtBlue.Name = "txtBlue";
            this.txtBlue.Size = new System.Drawing.Size(35, 21);
            this.txtBlue.TabIndex = 46;
            this.txtBlue.Leave += new System.EventHandler(this.txtBlue_Leave);
            // 
            // txtGreen
            // 
            this.txtGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGreen.Location = new System.Drawing.Point(145, 214);
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.Size = new System.Drawing.Size(35, 21);
            this.txtGreen.TabIndex = 45;
            this.txtGreen.Leave += new System.EventHandler(this.txtGreen_Leave);
            // 
            // txtRed
            // 
            this.txtRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRed.Location = new System.Drawing.Point(145, 189);
            this.txtRed.Name = "txtRed";
            this.txtRed.Size = new System.Drawing.Size(35, 21);
            this.txtRed.TabIndex = 44;
            this.txtRed.Leave += new System.EventHandler(this.txtRed_Leave);
            // 
            // txtBrightness
            // 
            this.txtBrightness.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBrightness.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrightness.Location = new System.Drawing.Point(49, 239);
            this.txtBrightness.Name = "txtBrightness";
            this.txtBrightness.Size = new System.Drawing.Size(35, 21);
            this.txtBrightness.TabIndex = 43;
            this.txtBrightness.Leave += new System.EventHandler(this.txtBrightness_Leave);
            // 
            // txtSat
            // 
            this.txtSat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSat.Location = new System.Drawing.Point(49, 214);
            this.txtSat.Name = "txtSat";
            this.txtSat.Size = new System.Drawing.Size(35, 21);
            this.txtSat.TabIndex = 42;
            this.txtSat.Leave += new System.EventHandler(this.txtSat_Leave);
            // 
            // txtHue
            // 
            this.txtHue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHue.Location = new System.Drawing.Point(49, 189);
            this.txtHue.Name = "txtHue";
            this.txtHue.Size = new System.Drawing.Size(35, 21);
            this.txtHue.TabIndex = 41;
            this.txtHue.Leave += new System.EventHandler(this.txtHue_Leave);
            // 
            // tbAlpha
            // 
            this.tbAlpha.Location = new System.Drawing.Point(198, 200);
            this.tbAlpha.Maximum = 255;
            this.tbAlpha.Name = "tbAlpha";
            this.tbAlpha.Size = new System.Drawing.Size(136, 45);
            this.tbAlpha.TabIndex = 54;
            this.tbAlpha.TickFrequency = 20;
            this.tbAlpha.Value = 255;
            this.tbAlpha.ValueChanged += new System.EventHandler(this.tbAlpha_ValueChanged);
            // 
            // lblAlpha
            // 
            this.lblAlpha.AutoSize = true;
            this.lblAlpha.Location = new System.Drawing.Point(229, 232);
            this.lblAlpha.Name = "lblAlpha";
            this.lblAlpha.Size = new System.Drawing.Size(72, 13);
            this.lblAlpha.TabIndex = 55;
            this.lblAlpha.Text = "Transparency";
            // 
            // colorPanelPending
            // 
            this.colorPanelPending.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.colorPanelPending.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.colorPanelPending.Location = new System.Drawing.Point(274, 48);
            this.colorPanelPending.Name = "colorPanelPending";
            this.colorPanelPending.PaintColor = true;
            this.colorPanelPending.Size = new System.Drawing.Size(60, 34);
            this.colorPanelPending.TabIndex = 56;
            this.colorPanelPending.Text = "colorPanel1";
            // 
            // CustomColorPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.colorPanelPending);
            this.Controls.Add(this.lblAlpha);
            this.Controls.Add(this.tbAlpha);
            this.Controls.Add(this.rbBlue);
            this.Controls.Add(this.rbGreen);
            this.Controls.Add(this.rbRed);
            this.Controls.Add(this.rbBrightness);
            this.Controls.Add(this.rbSat);
            this.Controls.Add(this.rbHue);
            this.Controls.Add(this.txtBlue);
            this.Controls.Add(this.txtGreen);
            this.Controls.Add(this.txtRed);
            this.Controls.Add(this.txtBrightness);
            this.Controls.Add(this.txtSat);
            this.Controls.Add(this.txtHue);
            this.Controls.Add(this.colorSlider);
            this.Controls.Add(this.lblOriginalColor);
            this.Controls.Add(this.colorBox);
            this.Name = "CustomColorPicker";
            this.Size = new System.Drawing.Size(350, 270);
            ((System.ComponentModel.ISupportInitialize)(this.tbAlpha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ColorBox colorBox;
        private System.Windows.Forms.Label lblOriginalColor;
        private VerticalColorSlider colorSlider;
        private System.Windows.Forms.RadioButton rbBlue;
        private System.Windows.Forms.RadioButton rbGreen;
        private System.Windows.Forms.RadioButton rbRed;
        private System.Windows.Forms.RadioButton rbBrightness;
        private System.Windows.Forms.RadioButton rbSat;
        private System.Windows.Forms.RadioButton rbHue;
        private System.Windows.Forms.TextBox txtBlue;
        private System.Windows.Forms.TextBox txtGreen;
        private System.Windows.Forms.TextBox txtRed;
        private System.Windows.Forms.TextBox txtBrightness;
        private System.Windows.Forms.TextBox txtSat;
        private System.Windows.Forms.TextBox txtHue;
        private System.Windows.Forms.TrackBar tbAlpha;
        private System.Windows.Forms.Label lblAlpha;
        private ColorPanel colorPanelPending;
    }
}
