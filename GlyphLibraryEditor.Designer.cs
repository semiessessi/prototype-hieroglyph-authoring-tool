
namespace PP1
{
    partial class GlyphLibraryEditor
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlyphLibraryEditor));
            this.LibraryCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.RefCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.OverrideListBox = new System.Windows.Forms.ListBox();
            this.GlyphPreviewCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TestOutput = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GlyphLibraryTools = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.GlyphLibraryMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useCurrentLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.findDefaultGlyphsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenLibraryDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveLibraryDialog = new System.Windows.Forms.SaveFileDialog();
            this.OpenImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.generateLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TestOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GlyphLibraryTools.SuspendLayout();
            this.GlyphLibraryMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // LibraryCombo
            // 
            this.LibraryCombo.FormattingEnabled = true;
            this.LibraryCombo.Items.AddRange(new object[] {
            "Default",
            "Project Base Library (default)",
            "Project Library",
            "Other Library (default)"});
            this.LibraryCombo.Location = new System.Drawing.Point(93, 3);
            this.LibraryCombo.Name = "LibraryCombo";
            this.LibraryCombo.Size = new System.Drawing.Size(212, 23);
            this.LibraryCombo.TabIndex = 0;
            this.LibraryCombo.Text = "Project Library";
            this.LibraryCombo.SelectedIndexChanged += new System.EventHandler(this.LibraryCombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Glyphs:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(270, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(11, 52);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button4);
            this.splitContainer1.Panel1.Controls.Add(this.button5);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.RefCombo);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.OverrideListBox);
            this.splitContainer1.Panel1.Controls.Add(this.GlyphPreviewCombo);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.LibraryCombo);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1MinSize = 308;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Panel2.Controls.Add(this.TestOutput);
            this.splitContainer1.Panel2.Controls.Add(this.button3);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(673, 386);
            this.splitContainer1.SplitterDistance = 308;
            this.splitContainer1.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(270, 55);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 32);
            this.button4.TabIndex = 12;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(232, 55);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(32, 32);
            this.button5.TabIndex = 11;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "References:";
            // 
            // RefCombo
            // 
            this.RefCombo.FormattingEnabled = true;
            this.RefCombo.Location = new System.Drawing.Point(93, 61);
            this.RefCombo.Name = "RefCombo";
            this.RefCombo.Size = new System.Drawing.Size(121, 23);
            this.RefCombo.TabIndex = 9;
            this.RefCombo.SelectedIndexChanged += new System.EventHandler(this.RefCombo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "NOTE: Overrides in referenced libraries are not shown";
            // 
            // OverrideListBox
            // 
            this.OverrideListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.OverrideListBox.FormattingEnabled = true;
            this.OverrideListBox.ItemHeight = 15;
            this.OverrideListBox.Location = new System.Drawing.Point(3, 130);
            this.OverrideListBox.Name = "OverrideListBox";
            this.OverrideListBox.ScrollAlwaysVisible = true;
            this.OverrideListBox.Size = new System.Drawing.Size(302, 229);
            this.OverrideListBox.TabIndex = 7;
            this.OverrideListBox.SelectedIndexChanged += new System.EventHandler(this.OverrideListBox_SelectedIndexChanged);
            // 
            // GlyphPreviewCombo
            // 
            this.GlyphPreviewCombo.FormattingEnabled = true;
            this.GlyphPreviewCombo.Location = new System.Drawing.Point(93, 32);
            this.GlyphPreviewCombo.Name = "GlyphPreviewCombo";
            this.GlyphPreviewCombo.Size = new System.Drawing.Size(121, 23);
            this.GlyphPreviewCombo.TabIndex = 6;
            this.GlyphPreviewCombo.Text = "A1";
            this.GlyphPreviewCombo.SelectedIndexChanged += new System.EventHandler(this.GlyphPreviewCombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Overrides:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Preview:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(187, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 175);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TestOutput
            // 
            this.TestOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TestOutput.Location = new System.Drawing.Point(3, 224);
            this.TestOutput.Name = "TestOutput";
            this.TestOutput.Size = new System.Drawing.Size(355, 159);
            this.TestOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TestOutput.TabIndex = 2;
            this.TestOutput.TabStop = false;
            this.TestOutput.SizeChanged += new System.EventHandler(this.TestOutput_SizeChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 31);
            this.button3.TabIndex = 1;
            this.button3.Text = "Add Override from Image...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // GlyphLibraryTools
            // 
            this.GlyphLibraryTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.GlyphLibraryTools.Location = new System.Drawing.Point(0, 24);
            this.GlyphLibraryTools.Name = "GlyphLibraryTools";
            this.GlyphLibraryTools.Size = new System.Drawing.Size(696, 25);
            this.GlyphLibraryTools.TabIndex = 5;
            this.GlyphLibraryTools.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::PP1.Properties.Resources.OpenFolder;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Open";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::PP1.Properties.Resources.Save;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Save";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // GlyphLibraryMenu
            // 
            this.GlyphLibraryMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.projectToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.GlyphLibraryMenu.Location = new System.Drawing.Point(0, 0);
            this.GlyphLibraryMenu.Name = "GlyphLibraryMenu";
            this.GlyphLibraryMenu.Size = new System.Drawing.Size(696, 24);
            this.GlyphLibraryMenu.TabIndex = 6;
            this.GlyphLibraryMenu.Text = "menuStrip1";
            this.GlyphLibraryMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.GlyphLibraryMenu_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As...";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(120, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.useCurrentLibraryToolStripMenuItem,
            this.toolStripMenuItem2,
            this.findDefaultGlyphsToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.projectToolStripMenuItem.Text = "&Project";
            // 
            // useCurrentLibraryToolStripMenuItem
            // 
            this.useCurrentLibraryToolStripMenuItem.Name = "useCurrentLibraryToolStripMenuItem";
            this.useCurrentLibraryToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.useCurrentLibraryToolStripMenuItem.Text = "Use Current Library";
            this.useCurrentLibraryToolStripMenuItem.Click += new System.EventHandler(this.useCurrentLibraryToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(183, 6);
            // 
            // findDefaultGlyphsToolStripMenuItem
            // 
            this.findDefaultGlyphsToolStripMenuItem.Enabled = false;
            this.findDefaultGlyphsToolStripMenuItem.Name = "findDefaultGlyphsToolStripMenuItem";
            this.findDefaultGlyphsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.findDefaultGlyphsToolStripMenuItem.Text = "Find Default Glyphs...";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateLibraryToolStripMenuItem,
            this.toolStripMenuItem3,
            this.reportToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reportToolStripMenuItem.Text = "&Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // OpenLibraryDialog
            // 
            this.OpenLibraryDialog.Filter = "Glyph Library (*.glyphlibrary)|*.glyphlibrary|All Files (*.*)|*.*";
            // 
            // SaveLibraryDialog
            // 
            this.SaveLibraryDialog.Filter = "Glyph Library (*.glyphlibrary)|*.glyphlibrary|All Files (*.*)|*.*";
            // 
            // OpenImageDialog
            // 
            this.OpenImageDialog.Filter = "PNG Image (*.png)|*.png|All Files (*.*)|*.*";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(177, 6);
            // 
            // generateLibraryToolStripMenuItem
            // 
            this.generateLibraryToolStripMenuItem.Name = "generateLibraryToolStripMenuItem";
            this.generateLibraryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.generateLibraryToolStripMenuItem.Text = "&Generate Library...";
            this.generateLibraryToolStripMenuItem.Click += new System.EventHandler(this.generateLibraryToolStripMenuItem_Click);
            // 
            // GlyphLibraryEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 450);
            this.Controls.Add(this.GlyphLibraryTools);
            this.Controls.Add(this.GlyphLibraryMenu);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.GlyphLibraryMenu;
            this.Name = "GlyphLibraryEditor";
            this.Text = "Glyph Library Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GlyphLibraryEditor_FormClosing);
            this.Load += new System.EventHandler(this.GlyphLibraryEditor_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TestOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GlyphLibraryTools.ResumeLayout(false);
            this.GlyphLibraryTools.PerformLayout();
            this.GlyphLibraryMenu.ResumeLayout(false);
            this.GlyphLibraryMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox LibraryCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip GlyphLibraryTools;
        private System.Windows.Forms.ComboBox GlyphPreviewCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip GlyphLibraryMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenLibraryDialog;
        private System.Windows.Forms.ListBox OverrideListBox;
        private System.Windows.Forms.SaveFileDialog SaveLibraryDialog;
        private System.Windows.Forms.OpenFileDialog OpenImageDialog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox RefCombo;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem useCurrentLibraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem findDefaultGlyphsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox TestOutput;
        private System.Windows.Forms.ToolStripMenuItem generateLibraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
    }
}