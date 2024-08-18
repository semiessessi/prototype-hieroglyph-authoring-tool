
namespace PP1
{
    partial class PanelContentView
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
            this.Preview = new System.Windows.Forms.PictureBox();
            this.Hierarchy = new System.Windows.Forms.TreeView();
            this.Split = new System.Windows.Forms.SplitContainer();
            this.DuplicateNodeButton = new System.Windows.Forms.Button();
            this.RemoveNodeButton = new System.Windows.Forms.Button();
            this.AddPanelButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.TypeCombo = new System.Windows.Forms.ComboBox();
            this.DirectionCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BackgroundColourCombo = new Unity3.Controls.QuickColor();
            this.SeperatorsCheck = new System.Windows.Forms.CheckBox();
            this.SeperatorCombo = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PageButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Preview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Split)).BeginInit();
            this.Split.Panel1.SuspendLayout();
            this.Split.Panel2.SuspendLayout();
            this.Split.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Preview
            // 
            this.Preview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Preview.Location = new System.Drawing.Point(3, 78);
            this.Preview.Name = "Preview";
            this.Preview.Size = new System.Drawing.Size(614, 498);
            this.Preview.TabIndex = 0;
            this.Preview.TabStop = false;
            // 
            // Hierarchy
            // 
            this.Hierarchy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Hierarchy.Location = new System.Drawing.Point(3, 34);
            this.Hierarchy.Name = "Hierarchy";
            this.Hierarchy.Size = new System.Drawing.Size(305, 273);
            this.Hierarchy.TabIndex = 1;
            this.Hierarchy.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Hierarchy_AfterSelect);
            // 
            // Split
            // 
            this.Split.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Split.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.Split.Location = new System.Drawing.Point(3, 3);
            this.Split.Name = "Split";
            // 
            // Split.Panel1
            // 
            this.Split.Panel1.Controls.Add(this.DuplicateNodeButton);
            this.Split.Panel1.Controls.Add(this.RemoveNodeButton);
            this.Split.Panel1.Controls.Add(this.AddPanelButton);
            this.Split.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.Split.Panel1.Controls.Add(this.Hierarchy);
            // 
            // Split.Panel2
            // 
            this.Split.Panel2.Controls.Add(this.button2);
            this.Split.Panel2.Controls.Add(this.button3);
            this.Split.Panel2.Controls.Add(this.button1);
            this.Split.Panel2.Controls.Add(this.PageButton);
            this.Split.Panel2.Controls.Add(this.Preview);
            this.Split.Size = new System.Drawing.Size(935, 581);
            this.Split.SplitterDistance = 311;
            this.Split.TabIndex = 2;
            // 
            // DuplicateNodeButton
            // 
            this.DuplicateNodeButton.Location = new System.Drawing.Point(71, 5);
            this.DuplicateNodeButton.Name = "DuplicateNodeButton";
            this.DuplicateNodeButton.Size = new System.Drawing.Size(28, 28);
            this.DuplicateNodeButton.TabIndex = 5;
            this.DuplicateNodeButton.Text = "x2";
            this.DuplicateNodeButton.UseVisualStyleBackColor = true;
            // 
            // RemoveNodeButton
            // 
            this.RemoveNodeButton.Location = new System.Drawing.Point(37, 5);
            this.RemoveNodeButton.Name = "RemoveNodeButton";
            this.RemoveNodeButton.Size = new System.Drawing.Size(28, 28);
            this.RemoveNodeButton.TabIndex = 4;
            this.RemoveNodeButton.Text = "-";
            this.RemoveNodeButton.UseVisualStyleBackColor = true;
            // 
            // AddPanelButton
            // 
            this.AddPanelButton.Location = new System.Drawing.Point(3, 5);
            this.AddPanelButton.Name = "AddPanelButton";
            this.AddPanelButton.Size = new System.Drawing.Size(28, 28);
            this.AddPanelButton.TabIndex = 3;
            this.AddPanelButton.Text = "+";
            this.AddPanelButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TypeCombo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DirectionCombo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.BackgroundColourCombo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.SeperatorsCheck, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.SeperatorCombo, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 313);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(305, 265);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Direction";
            // 
            // TypeCombo
            // 
            this.TypeCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TypeCombo.FormattingEnabled = true;
            this.TypeCombo.Items.AddRange(new object[] {
            "Panel",
            "Text",
            "Image"});
            this.TypeCombo.Location = new System.Drawing.Point(155, 3);
            this.TypeCombo.Name = "TypeCombo";
            this.TypeCombo.Size = new System.Drawing.Size(147, 23);
            this.TypeCombo.TabIndex = 2;
            // 
            // DirectionCombo
            // 
            this.DirectionCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DirectionCombo.FormattingEnabled = true;
            this.DirectionCombo.Items.AddRange(new object[] {
            "...",
            "++"});
            this.DirectionCombo.Location = new System.Drawing.Point(155, 31);
            this.DirectionCombo.Name = "DirectionCombo";
            this.DirectionCombo.Size = new System.Drawing.Size(147, 23);
            this.DirectionCombo.TabIndex = 0;
            this.DirectionCombo.SelectedIndexChanged += new System.EventHandler(this.DirectionCombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Panel Type";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Background Colour";
            // 
            // BackgroundColourCombo
            // 
            this.BackgroundColourCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BackgroundColourCombo.AnchorSize = new System.Drawing.Size(145, 21);
            this.BackgroundColourCombo.BackColor = System.Drawing.Color.White;
            this.BackgroundColourCombo.Color = System.Drawing.Color.Transparent;
            this.BackgroundColourCombo.DockSide = Unity3.Controls.DropDownControl.eDockSide.Left;
            this.BackgroundColourCombo.Location = new System.Drawing.Point(156, 59);
            this.BackgroundColourCombo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BackgroundColourCombo.Name = "BackgroundColourCombo";
            this.BackgroundColourCombo.Size = new System.Drawing.Size(145, 21);
            this.BackgroundColourCombo.TabIndex = 5;
            this.BackgroundColourCombo.ColorChanged += new System.EventHandler(this.BackgroundColorCombo_ColorChanged);
            // 
            // SeperatorsCheck
            // 
            this.SeperatorsCheck.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SeperatorsCheck.AutoSize = true;
            this.SeperatorsCheck.Location = new System.Drawing.Point(3, 88);
            this.SeperatorsCheck.Name = "SeperatorsCheck";
            this.SeperatorsCheck.Size = new System.Drawing.Size(81, 19);
            this.SeperatorsCheck.TabIndex = 6;
            this.SeperatorsCheck.Text = "Seperators";
            this.SeperatorsCheck.UseVisualStyleBackColor = true;
            // 
            // SeperatorCombo
            // 
            this.SeperatorCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SeperatorCombo.FormattingEnabled = true;
            this.SeperatorCombo.Items.AddRange(new object[] {
            "Invisible",
            "Line",
            "Trimmed Line",
            "Trimmed Line with Stripes"});
            this.SeperatorCombo.Location = new System.Drawing.Point(155, 87);
            this.SeperatorCombo.Name = "SeperatorCombo";
            this.SeperatorCombo.Size = new System.Drawing.Size(147, 23);
            this.SeperatorCombo.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "&Copy Image";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(315, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "&Save Image...";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Render";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PageButton
            // 
            this.PageButton.Location = new System.Drawing.Point(3, 3);
            this.PageButton.Name = "PageButton";
            this.PageButton.Size = new System.Drawing.Size(98, 23);
            this.PageButton.TabIndex = 1;
            this.PageButton.Text = "Create Page...";
            this.PageButton.UseVisualStyleBackColor = true;
            // 
            // PanelContentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Split);
            this.Name = "PanelContentView";
            this.Size = new System.Drawing.Size(938, 584);
            this.Load += new System.EventHandler(this.PanelContentView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Preview)).EndInit();
            this.Split.Panel1.ResumeLayout(false);
            this.Split.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Split)).EndInit();
            this.Split.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Preview;
        private System.Windows.Forms.TreeView Hierarchy;
        private System.Windows.Forms.SplitContainer Split;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button PageButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TypeCombo;
        private System.Windows.Forms.ComboBox DirectionCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DuplicateNodeButton;
        private System.Windows.Forms.Button RemoveNodeButton;
        private System.Windows.Forms.Button AddPanelButton;
        private System.Windows.Forms.Label label3;
        private Unity3.Controls.QuickColor BackgroundColourCombo;
        private System.Windows.Forms.CheckBox SeperatorsCheck;
        private System.Windows.Forms.ComboBox SeperatorCombo;
    }
}
