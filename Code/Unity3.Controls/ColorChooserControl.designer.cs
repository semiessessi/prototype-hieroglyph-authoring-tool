namespace Unity3.Controls
{
    partial class ColorChooserControl
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
            this.btnShowColorPicker = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowColorPicker
            // 
            this.btnShowColorPicker.Location = new System.Drawing.Point(244, 274);
            this.btnShowColorPicker.Name = "btnShowColorPicker";
            this.btnShowColorPicker.Size = new System.Drawing.Size(106, 23);
            this.btnShowColorPicker.TabIndex = 0;
            this.btnShowColorPicker.Text = "Custom Color";
            this.btnShowColorPicker.UseVisualStyleBackColor = true;
            this.btnShowColorPicker.Click += new System.EventHandler(this.btnShowColorPicker_Click);
            // 
            // ColorPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnShowColorPicker);
            this.Name = "ColorPicker";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowColorPicker;
    }
}
