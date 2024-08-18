
namespace PP1
{
    partial class TextContentView
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
            this.DocumentSplit = new System.Windows.Forms.SplitContainer();
            this.DocumentText = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SectionCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ResetZoom = new System.Windows.Forms.Button();
            this.ZoomReadout = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DocumentPreview = new System.Windows.Forms.PictureBox();
            this.ZoomBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.StyleCombo = new System.Windows.Forms.ComboBox();
            this.SaveImageDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentSplit)).BeginInit();
            this.DocumentSplit.Panel1.SuspendLayout();
            this.DocumentSplit.Panel2.SuspendLayout();
            this.DocumentSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomBar)).BeginInit();
            this.SuspendLayout();
            // 
            // DocumentSplit
            // 
            this.DocumentSplit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DocumentSplit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DocumentSplit.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.DocumentSplit.Location = new System.Drawing.Point(0, 0);
            this.DocumentSplit.Name = "DocumentSplit";
            // 
            // DocumentSplit.Panel1
            // 
            this.DocumentSplit.Panel1.Controls.Add(this.DocumentText);
            // 
            // DocumentSplit.Panel2
            // 
            this.DocumentSplit.Panel2.Controls.Add(this.button2);
            this.DocumentSplit.Panel2.Controls.Add(this.SectionCombo);
            this.DocumentSplit.Panel2.Controls.Add(this.label3);
            this.DocumentSplit.Panel2.Controls.Add(this.button1);
            this.DocumentSplit.Panel2.Controls.Add(this.ResetZoom);
            this.DocumentSplit.Panel2.Controls.Add(this.ZoomReadout);
            this.DocumentSplit.Panel2.Controls.Add(this.label2);
            this.DocumentSplit.Panel2.Controls.Add(this.DocumentPreview);
            this.DocumentSplit.Panel2.Controls.Add(this.ZoomBar);
            this.DocumentSplit.Panel2.Controls.Add(this.label1);
            this.DocumentSplit.Panel2.Controls.Add(this.StyleCombo);
            this.DocumentSplit.Panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DocumentSplit.Panel2MinSize = 560;
            this.DocumentSplit.Size = new System.Drawing.Size(904, 531);
            this.DocumentSplit.SplitterDistance = 300;
            this.DocumentSplit.TabIndex = 1;
            // 
            // DocumentText
            // 
            this.DocumentText.AcceptsTab = true;
            this.DocumentText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DocumentText.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DocumentText.Location = new System.Drawing.Point(3, 3);
            this.DocumentText.Multiline = true;
            this.DocumentText.Name = "DocumentText";
            this.DocumentText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DocumentText.Size = new System.Drawing.Size(292, 523);
            this.DocumentText.TabIndex = 0;
            this.DocumentText.WordWrap = false;
            this.DocumentText.TextChanged += new System.EventHandler(this.DocumentText_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(214, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "&Copy Image";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SectionCombo
            // 
            this.SectionCombo.FormattingEnabled = true;
            this.SectionCombo.Items.AddRange(new object[] {
            "All"});
            this.SectionCombo.Location = new System.Drawing.Point(86, 40);
            this.SectionCombo.Name = "SectionCombo";
            this.SectionCombo.Size = new System.Drawing.Size(121, 23);
            this.SectionCombo.TabIndex = 9;
            this.SectionCombo.Text = "All";
            this.SectionCombo.SelectedIndexChanged += new System.EventHandler(this.SectionCombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.Location = new System.Drawing.Point(4, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Section:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "&Save Image...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResetZoom
            // 
            this.ResetZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetZoom.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ResetZoom.Location = new System.Drawing.Point(566, 63);
            this.ResetZoom.Name = "ResetZoom";
            this.ResetZoom.Size = new System.Drawing.Size(29, 23);
            this.ResetZoom.TabIndex = 6;
            this.ResetZoom.Text = "1x";
            this.ResetZoom.UseVisualStyleBackColor = true;
            this.ResetZoom.Click += new System.EventHandler(this.ResetZoom_Click);
            // 
            // ZoomReadout
            // 
            this.ZoomReadout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ZoomReadout.AutoSize = true;
            this.ZoomReadout.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ZoomReadout.Location = new System.Drawing.Point(525, 67);
            this.ZoomReadout.Name = "ZoomReadout";
            this.ZoomReadout.Size = new System.Drawing.Size(35, 15);
            this.ZoomReadout.TabIndex = 5;
            this.ZoomReadout.Text = "100%";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Location = new System.Drawing.Point(318, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Zoom:";
            // 
            // DocumentPreview
            // 
            this.DocumentPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DocumentPreview.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DocumentPreview.InitialImage = null;
            this.DocumentPreview.Location = new System.Drawing.Point(3, 92);
            this.DocumentPreview.Name = "DocumentPreview";
            this.DocumentPreview.Size = new System.Drawing.Size(592, 434);
            this.DocumentPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DocumentPreview.TabIndex = 0;
            this.DocumentPreview.TabStop = false;
            // 
            // ZoomBar
            // 
            this.ZoomBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ZoomBar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ZoomBar.Location = new System.Drawing.Point(366, 63);
            this.ZoomBar.Maximum = 100;
            this.ZoomBar.Name = "ZoomBar";
            this.ZoomBar.Size = new System.Drawing.Size(153, 45);
            this.ZoomBar.TabIndex = 3;
            this.ZoomBar.TickFrequency = 10;
            this.ZoomBar.Scroll += new System.EventHandler(this.ZoomBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Preview Style";
            // 
            // StyleCombo
            // 
            this.StyleCombo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.StyleCombo.FormattingEnabled = true;
            this.StyleCombo.Items.AddRange(new object[] {
            "Word Lines",
            "Vertical Left-to-Right",
            "Vertical Right-to-Left",
            "Left-to-Right",
            "Right-to-Left",
            "Mirrored",
            "Transliteration",
            "Interlinear"});
            this.StyleCombo.Location = new System.Drawing.Point(86, 7);
            this.StyleCombo.Name = "StyleCombo";
            this.StyleCombo.Size = new System.Drawing.Size(121, 23);
            this.StyleCombo.TabIndex = 1;
            this.StyleCombo.SelectedIndexChanged += new System.EventHandler(this.StyleCombo_SelectedIndexChanged);
            // 
            // SaveImageDialog
            // 
            this.SaveImageDialog.Filter = "PNG image (*.png)|*.png|All Files (*.*)|*.*";
            this.SaveImageDialog.Title = "Save Image";
            // 
            // TextContentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DocumentSplit);
            this.Name = "TextContentView";
            this.Size = new System.Drawing.Size(906, 531);
            this.Load += new System.EventHandler(this.TextContentView_Load);
            this.DocumentSplit.Panel1.ResumeLayout(false);
            this.DocumentSplit.Panel1.PerformLayout();
            this.DocumentSplit.Panel2.ResumeLayout(false);
            this.DocumentSplit.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentSplit)).EndInit();
            this.DocumentSplit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DocumentPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer DocumentSplit;
        private System.Windows.Forms.TextBox DocumentText;
        private System.Windows.Forms.PictureBox DocumentPreview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox StyleCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar ZoomBar;
        private System.Windows.Forms.Label ZoomReadout;
        private System.Windows.Forms.Button ResetZoom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog SaveImageDialog;
        private System.Windows.Forms.ComboBox SectionCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}
