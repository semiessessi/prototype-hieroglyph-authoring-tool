namespace Unity3.Controls
{
    partial class QuickColor
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
            this.colorPanel1 = new Unity3.Controls.ColorPanel();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnNoColor = new System.Windows.Forms.Button();
            this.colorGrid1 = new Unity3.Controls.ColorGrid();
            this.btnMoreSolidColors = new System.Windows.Forms.Button();
            this.lblNoColor = new System.Windows.Forms.Label();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorPanel1
            // 
            this.colorPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPanel1.Color = System.Drawing.Color.Lime;
            this.colorPanel1.Location = new System.Drawing.Point(2, 2);
            this.colorPanel1.Name = "colorPanel1";
            this.colorPanel1.PaintColor = true;
            this.colorPanel1.Size = new System.Drawing.Size(164, 17);
            this.colorPanel1.TabIndex = 0;
            this.colorPanel1.Text = "colorPanel1";
            this.colorPanel1.Click += new System.EventHandler(this.colorPanel1_Click);
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlControls.Controls.Add(this.btnNoColor);
            this.pnlControls.Controls.Add(this.colorGrid1);
            this.pnlControls.Controls.Add(this.btnMoreSolidColors);
            this.pnlControls.Location = new System.Drawing.Point(14, 20);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(160, 179);
            this.pnlControls.TabIndex = 1;
            // 
            // btnNoColor
            // 
            this.btnNoColor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNoColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNoColor.Location = new System.Drawing.Point(-1, 0);
            this.btnNoColor.Name = "btnNoColor";
            this.btnNoColor.Size = new System.Drawing.Size(163, 26);
            this.btnNoColor.TabIndex = 3;
            this.btnNoColor.Text = "No Color";
            this.btnNoColor.UseVisualStyleBackColor = false;
            this.btnNoColor.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.btnNoColor.Click += new System.EventHandler(this.btnNoColor_Click);
            this.btnNoColor.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            // 
            // colorGrid1
            // 
            this.colorGrid1.ClipColors = false;
            this.colorGrid1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorGrid1.GridPadding = ((byte)(5));
            this.colorGrid1.GridSize = new System.Drawing.Size(16, 12);
            this.colorGrid1.Location = new System.Drawing.Point(3, 24);
            this.colorGrid1.Name = "colorGrid1";
            this.colorGrid1.SelectedIndex = 0;
            this.colorGrid1.Size = new System.Drawing.Size(157, 124);
            this.colorGrid1.TabIndex = 2;
            this.colorGrid1.SelectedIndexChange += new System.EventHandler(this.colorGrid1_SelectedIndexChange);
            // 
            // btnMoreSolidColors
            // 
            this.btnMoreSolidColors.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMoreSolidColors.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMoreSolidColors.Location = new System.Drawing.Point(-1, 154);
            this.btnMoreSolidColors.Name = "btnMoreSolidColors";
            this.btnMoreSolidColors.Size = new System.Drawing.Size(163, 26);
            this.btnMoreSolidColors.TabIndex = 1;
            this.btnMoreSolidColors.Text = "More Solid Colors ...";
            this.btnMoreSolidColors.UseVisualStyleBackColor = false;
            this.btnMoreSolidColors.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.btnMoreSolidColors.Click += new System.EventHandler(this.btnMoreSolidColors_Click);
            this.btnMoreSolidColors.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            // 
            // lblNoColor
            // 
            this.lblNoColor.Location = new System.Drawing.Point(7, 7);
            this.lblNoColor.Name = "lblNoColor";
            this.lblNoColor.Size = new System.Drawing.Size(158, 10);
            this.lblNoColor.TabIndex = 2;
            this.lblNoColor.Text = "No Color";
            this.lblNoColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNoColor.Click += new System.EventHandler(this.colorPanel1_Click);
            // 
            // QuickColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.colorPanel1);
            this.Controls.Add(this.lblNoColor);
            this.Name = "QuickColor";
            this.Size = new System.Drawing.Size(185, 228);
            this.pnlControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ColorPanel colorPanel1;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Button btnMoreSolidColors;
        private ColorGrid colorGrid1;
        private System.Windows.Forms.Button btnNoColor;
        private System.Windows.Forms.Label lblNoColor;


    }
}
