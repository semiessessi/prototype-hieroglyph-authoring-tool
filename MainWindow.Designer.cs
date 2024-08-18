
namespace PP1
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Glyph Library: (default)", 6, 6);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Size: A3 Landscape (297mm x 420mm)", 7, 7);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Images", 4, 4);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("foo.text", 2, 2);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Text", 4, 4, new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Panels", 4, 4);
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Pages");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Project (Untitled)", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode5,
            treeNode6,
            treeNode7});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.GlyphLibraryContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openInEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.resetToDefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageNodeContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextNodeContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProjectNodeContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveProjectAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.closeProjectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.recentProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadBaseGlyphLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripSeparator();
            this.reportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.glyphLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.fileToolbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripSeparator();
            this.hieroglyphPaletteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateGlyphTemplatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateGridTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
            this.dictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripSpringSpacer = new System.Windows.Forms.ToolStripStatusLabel();
            this.LengthStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.LinesStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ProjectTreeView = new System.Windows.Forms.TreeView();
            this.ProjectTreeImageList = new System.Windows.Forms.ImageList(this.components);
            this.DocumentTabs = new System.Windows.Forms.TabControl();
            this.FirstTab = new System.Windows.Forms.TabPage();
            this.GlyphPalette1 = new System.Windows.Forms.ToolStrip();
            this.PaletteButtonA = new System.Windows.Forms.ToolStripButton();
            this.PaletteButtonB = new System.Windows.Forms.ToolStripButton();
            this.PaletteButtonC = new System.Windows.Forms.ToolStripButton();
            this.PaletteButtonD = new System.Windows.Forms.ToolStripButton();
            this.PaletteButtonE = new System.Windows.Forms.ToolStripButton();
            this.PaletteButtonF = new System.Windows.Forms.ToolStripButton();
            this.PaletteButtonG = new System.Windows.Forms.ToolStripButton();
            this.PaletteButtonH = new System.Windows.Forms.ToolStripButton();
            this.PaletteButtonI = new System.Windows.Forms.ToolStripButton();
            this.GlyphPalette2 = new System.Windows.Forms.ToolStrip();
            this.PaletteButtonK = new System.Windows.Forms.ToolStripButton();
            this.PaletteButtonL = new System.Windows.Forms.ToolStripButton();
            this.PaletteButtonM = new System.Windows.Forms.ToolStripButton();
            this.PaletteButtonN = new System.Windows.Forms.ToolStripButton();
            this.PaletteButtonNL = new System.Windows.Forms.ToolStripButton();
            this.PaletteButtonO = new System.Windows.Forms.ToolStripButton();
            this.PaletteButtonP = new System.Windows.Forms.ToolStripButton();
            this.PaletteButtonQ = new System.Windows.Forms.ToolStripButton();
            this.PaletteButtonR = new System.Windows.Forms.ToolStripButton();
            this.GlyphPalette3 = new System.Windows.Forms.ToolStrip();
            this.PaletteButtonS = new System.Windows.Forms.ToolStripButton();
            this.PaletteButtonT = new System.Windows.Forms.ToolStripButton();
            this.PaletteButtonU = new System.Windows.Forms.ToolStripButton();
            this.PaletteButtonV = new System.Windows.Forms.ToolStripButton();
            this.PaletteButtonW = new System.Windows.Forms.ToolStripButton();
            this.PaletteButtonX = new System.Windows.Forms.ToolStripButton();
            this.PaletteButtonY = new System.Windows.Forms.ToolStripButton();
            this.PaletteButtonZ = new System.Windows.Forms.ToolStripButton();
            this.PaletteButtonAa = new System.Windows.Forms.ToolStripButton();
            this.FileToolStrip = new System.Windows.Forms.ToolStrip();
            this.NewFileButton = new System.Windows.Forms.ToolStripButton();
            this.OpenFileButton = new System.Windows.Forms.ToolStripButton();
            this.SaveButton = new System.Windows.Forms.ToolStripButton();
            this.SaveAllButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteFileButton = new System.Windows.Forms.ToolStripButton();
            this.ToolsToolStrip = new System.Windows.Forms.ToolStrip();
            this.DictionaryButton = new System.Windows.Forms.ToolStripButton();
            this.GlyphLibraryButton = new System.Windows.Forms.ToolStripButton();
            this.SaveProjectDialog = new System.Windows.Forms.SaveFileDialog();
            this.OpenProjectDialog = new System.Windows.Forms.OpenFileDialog();
            this.AddImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.AddTextDialog = new System.Windows.Forms.OpenFileDialog();
            this.GlyphLibraryContextMenu.SuspendLayout();
            this.ImageNodeContextMenu.SuspendLayout();
            this.TextNodeContextMenu.SuspendLayout();
            this.ProjectNodeContextMenu.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.ToolStripContainer.BottomToolStripPanel.SuspendLayout();
            this.ToolStripContainer.ContentPanel.SuspendLayout();
            this.ToolStripContainer.LeftToolStripPanel.SuspendLayout();
            this.ToolStripContainer.TopToolStripPanel.SuspendLayout();
            this.ToolStripContainer.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.DocumentTabs.SuspendLayout();
            this.GlyphPalette1.SuspendLayout();
            this.GlyphPalette2.SuspendLayout();
            this.GlyphPalette3.SuspendLayout();
            this.FileToolStrip.SuspendLayout();
            this.ToolsToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // GlyphLibraryContextMenu
            // 
            this.GlyphLibraryContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openInEditorToolStripMenuItem,
            this.toolStripMenuItem6,
            this.resetToDefaultToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.GlyphLibraryContextMenu.Name = "GlyphLibraryContextMenu";
            this.GlyphLibraryContextMenu.Size = new System.Drawing.Size(160, 76);
            // 
            // openInEditorToolStripMenuItem
            // 
            this.openInEditorToolStripMenuItem.Name = "openInEditorToolStripMenuItem";
            this.openInEditorToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.openInEditorToolStripMenuItem.Text = "&Open in Editor...";
            this.openInEditorToolStripMenuItem.Click += new System.EventHandler(this.openInEditorToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(156, 6);
            // 
            // resetToDefaultToolStripMenuItem
            // 
            this.resetToDefaultToolStripMenuItem.Name = "resetToDefaultToolStripMenuItem";
            this.resetToDefaultToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.resetToDefaultToolStripMenuItem.Text = "Reset to Default";
            this.resetToDefaultToolStripMenuItem.Click += new System.EventHandler(this.resetToDefaultToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // ImageNodeContextMenu
            // 
            this.ImageNodeContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewImageToolStripMenuItem});
            this.ImageNodeContextMenu.Name = "ImageNodeContextMenu";
            this.ImageNodeContextMenu.Size = new System.Drawing.Size(169, 26);
            // 
            // addNewImageToolStripMenuItem
            // 
            this.addNewImageToolStripMenuItem.Name = "addNewImageToolStripMenuItem";
            this.addNewImageToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.addNewImageToolStripMenuItem.Text = "Add &New Image...";
            this.addNewImageToolStripMenuItem.Click += new System.EventHandler(this.addNewImageToolStripMenuItem_Click);
            // 
            // TextNodeContextMenu
            // 
            this.TextNodeContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTextToolStripMenuItem,
            this.addNewTextToolStripMenuItem});
            this.TextNodeContextMenu.Name = "TextNodeContextMenu";
            this.TextNodeContextMenu.Size = new System.Drawing.Size(174, 48);
            // 
            // newTextToolStripMenuItem
            // 
            this.newTextToolStripMenuItem.Name = "newTextToolStripMenuItem";
            this.newTextToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.newTextToolStripMenuItem.Text = "Add &New Text";
            this.newTextToolStripMenuItem.Click += new System.EventHandler(this.newTextToolStripMenuItem_Click);
            // 
            // addNewTextToolStripMenuItem
            // 
            this.addNewTextToolStripMenuItem.Name = "addNewTextToolStripMenuItem";
            this.addNewTextToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.addNewTextToolStripMenuItem.Text = "Add &Existing Text...";
            this.addNewTextToolStripMenuItem.Click += new System.EventHandler(this.addNewTextToolStripMenuItem_Click);
            // 
            // ProjectNodeContextMenu
            // 
            this.ProjectNodeContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveProjectAsToolStripMenuItem,
            this.toolStripMenuItem8,
            this.closeProjectToolStripMenuItem1});
            this.ProjectNodeContextMenu.Name = "ProjectNodeContextMenu";
            this.ProjectNodeContextMenu.Size = new System.Drawing.Size(164, 54);
            // 
            // saveProjectAsToolStripMenuItem
            // 
            this.saveProjectAsToolStripMenuItem.Name = "saveProjectAsToolStripMenuItem";
            this.saveProjectAsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.saveProjectAsToolStripMenuItem.Text = "Save Project &As...";
            this.saveProjectAsToolStripMenuItem.Click += new System.EventHandler(this.saveProjectAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(160, 6);
            // 
            // closeProjectToolStripMenuItem1
            // 
            this.closeProjectToolStripMenuItem1.Name = "closeProjectToolStripMenuItem1";
            this.closeProjectToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.closeProjectToolStripMenuItem1.Text = "&Close Project";
            this.closeProjectToolStripMenuItem1.Click += new System.EventHandler(this.closeProjectToolStripMenuItem1_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.projectToolStripMenuItem2,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(804, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripMenuItem1,
            this.closeFileToolStripMenuItem,
            this.closeProjectToolStripMenuItem,
            this.toolStripMenuItem5,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.saveAllToolStripMenuItem,
            this.toolStripMenuItem2,
            this.recentProjectsToolStripMenuItem,
            this.toolStripMenuItem9,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectToolStripMenuItem,
            this.toolStripMenuItem4,
            this.newFileToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.projectToolStripMenuItem.Text = "&Project";
            this.projectToolStripMenuItem.Click += new System.EventHandler(this.projectToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(132, 6);
            // 
            // newFileToolStripMenuItem
            // 
            this.newFileToolStripMenuItem.Enabled = false;
            this.newFileToolStripMenuItem.Image = global::PP1.Properties.Resources.NewDocument;
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.newFileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openProjectToolStripMenuItem,
            this.toolStripMenuItem3,
            this.openFileToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // openProjectToolStripMenuItem
            // 
            this.openProjectToolStripMenuItem.Name = "openProjectToolStripMenuItem";
            this.openProjectToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.openProjectToolStripMenuItem.Text = "&Project...";
            this.openProjectToolStripMenuItem.Click += new System.EventHandler(this.openProjectToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(141, 6);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Enabled = false;
            this.openFileToolStripMenuItem.Image = global::PP1.Properties.Resources.OpenFolder;
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.openFileToolStripMenuItem.Text = "&File...";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(184, 6);
            // 
            // closeFileToolStripMenuItem
            // 
            this.closeFileToolStripMenuItem.Name = "closeFileToolStripMenuItem";
            this.closeFileToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.closeFileToolStripMenuItem.Text = "&Close File";
            // 
            // closeProjectToolStripMenuItem
            // 
            this.closeProjectToolStripMenuItem.Name = "closeProjectToolStripMenuItem";
            this.closeProjectToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.closeProjectToolStripMenuItem.Text = "Close &Project";
            this.closeProjectToolStripMenuItem.Click += new System.EventHandler(this.closeProjectToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(184, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::PP1.Properties.Resources.Save;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // saveAllToolStripMenuItem
            // 
            this.saveAllToolStripMenuItem.Image = global::PP1.Properties.Resources.SaveAll;
            this.saveAllToolStripMenuItem.Name = "saveAllToolStripMenuItem";
            this.saveAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAllToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.saveAllToolStripMenuItem.Text = "Save A&ll";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(184, 6);
            // 
            // recentProjectsToolStripMenuItem
            // 
            this.recentProjectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noneToolStripMenuItem});
            this.recentProjectsToolStripMenuItem.Name = "recentProjectsToolStripMenuItem";
            this.recentProjectsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.recentProjectsToolStripMenuItem.Text = "Recent Pro&jects";
            // 
            // noneToolStripMenuItem
            // 
            this.noneToolStripMenuItem.Enabled = false;
            this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            this.noneToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.noneToolStripMenuItem.Text = "(none)";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(184, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::PP1.Properties.Resources.Exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "F&ormat";
            // 
            // projectToolStripMenuItem2
            // 
            this.projectToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadBaseGlyphLibraryToolStripMenuItem,
            this.toolStripMenuItem11,
            this.reportToolStripMenuItem1});
            this.projectToolStripMenuItem2.Name = "projectToolStripMenuItem2";
            this.projectToolStripMenuItem2.Size = new System.Drawing.Size(56, 20);
            this.projectToolStripMenuItem2.Text = "&Project";
            // 
            // loadBaseGlyphLibraryToolStripMenuItem
            // 
            this.loadBaseGlyphLibraryToolStripMenuItem.Name = "loadBaseGlyphLibraryToolStripMenuItem";
            this.loadBaseGlyphLibraryToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.loadBaseGlyphLibraryToolStripMenuItem.Text = "&Load Base Glyph Library...";
            this.loadBaseGlyphLibraryToolStripMenuItem.Click += new System.EventHandler(this.loadBaseGlyphLibraryToolStripMenuItem_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(206, 6);
            // 
            // reportToolStripMenuItem1
            // 
            this.reportToolStripMenuItem1.Enabled = false;
            this.reportToolStripMenuItem1.Name = "reportToolStripMenuItem1";
            this.reportToolStripMenuItem1.Size = new System.Drawing.Size(209, 22);
            this.reportToolStripMenuItem1.Text = "&Report...";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.glyphLibraryToolStripMenuItem,
            this.toolStripMenuItem7,
            this.fileToolbarToolStripMenuItem,
            this.projectToolbarToolStripMenuItem,
            this.toolsToolStripMenuItem1,
            this.toolStripMenuItem12,
            this.hieroglyphPaletteToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // glyphLibraryToolStripMenuItem
            // 
            this.glyphLibraryToolStripMenuItem.CheckOnClick = true;
            this.glyphLibraryToolStripMenuItem.Name = "glyphLibraryToolStripMenuItem";
            this.glyphLibraryToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.glyphLibraryToolStripMenuItem.Text = "&Glyph Library";
            this.glyphLibraryToolStripMenuItem.Click += new System.EventHandler(this.glyphLibraryToolStripMenuItem_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(189, 6);
            // 
            // fileToolbarToolStripMenuItem
            // 
            this.fileToolbarToolStripMenuItem.Checked = true;
            this.fileToolbarToolStripMenuItem.CheckOnClick = true;
            this.fileToolbarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fileToolbarToolStripMenuItem.Name = "fileToolbarToolStripMenuItem";
            this.fileToolbarToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.fileToolbarToolStripMenuItem.Text = "&File Toolbar";
            this.fileToolbarToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.fileToolbarToolStripMenuItem_CheckStateChanged);
            // 
            // projectToolbarToolStripMenuItem
            // 
            this.projectToolbarToolStripMenuItem.CheckOnClick = true;
            this.projectToolbarToolStripMenuItem.Enabled = false;
            this.projectToolbarToolStripMenuItem.Name = "projectToolbarToolStripMenuItem";
            this.projectToolbarToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.projectToolbarToolStripMenuItem.Text = "&Project Toolbar";
            // 
            // toolsToolStripMenuItem1
            // 
            this.toolsToolStripMenuItem1.Checked = true;
            this.toolsToolStripMenuItem1.CheckOnClick = true;
            this.toolsToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolsToolStripMenuItem1.Name = "toolsToolStripMenuItem1";
            this.toolsToolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.toolsToolStripMenuItem1.Text = "Show &Tools on Toolbar";
            this.toolsToolStripMenuItem1.Click += new System.EventHandler(this.toolsToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(189, 6);
            // 
            // hieroglyphPaletteToolStripMenuItem
            // 
            this.hieroglyphPaletteToolStripMenuItem.Checked = true;
            this.hieroglyphPaletteToolStripMenuItem.CheckOnClick = true;
            this.hieroglyphPaletteToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hieroglyphPaletteToolStripMenuItem.Name = "hieroglyphPaletteToolStripMenuItem";
            this.hieroglyphPaletteToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.hieroglyphPaletteToolStripMenuItem.Text = "&Hieroglyph Palette";
            this.hieroglyphPaletteToolStripMenuItem.Click += new System.EventHandler(this.hieroglyphPaletteToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateGlyphTemplatesToolStripMenuItem,
            this.generateGridTemplateToolStripMenuItem,
            this.toolStripMenuItem10,
            this.dictionaryToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // generateGlyphTemplatesToolStripMenuItem
            // 
            this.generateGlyphTemplatesToolStripMenuItem.Name = "generateGlyphTemplatesToolStripMenuItem";
            this.generateGlyphTemplatesToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.generateGlyphTemplatesToolStripMenuItem.Text = "&Generate Glyph Templates...";
            this.generateGlyphTemplatesToolStripMenuItem.Click += new System.EventHandler(this.generateGlyphTemplatesToolStripMenuItem_Click);
            // 
            // generateGridTemplateToolStripMenuItem
            // 
            this.generateGridTemplateToolStripMenuItem.Name = "generateGridTemplateToolStripMenuItem";
            this.generateGridTemplateToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.generateGridTemplateToolStripMenuItem.Text = "Generate G&rid Template...";
            this.generateGridTemplateToolStripMenuItem.Click += new System.EventHandler(this.generateGridTemplateToolStripMenuItem_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(217, 6);
            // 
            // dictionaryToolStripMenuItem
            // 
            this.dictionaryToolStripMenuItem.Name = "dictionaryToolStripMenuItem";
            this.dictionaryToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.dictionaryToolStripMenuItem.Text = "&Dictionary...";
            this.dictionaryToolStripMenuItem.Click += new System.EventHandler(this.dictionaryToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // ToolStripContainer
            // 
            this.ToolStripContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // ToolStripContainer.BottomToolStripPanel
            // 
            this.ToolStripContainer.BottomToolStripPanel.Controls.Add(this.StatusStrip);
            // 
            // ToolStripContainer.ContentPanel
            // 
            this.ToolStripContainer.ContentPanel.Controls.Add(this.splitContainer1);
            this.ToolStripContainer.ContentPanel.Size = new System.Drawing.Size(693, 430);
            // 
            // ToolStripContainer.LeftToolStripPanel
            // 
            this.ToolStripContainer.LeftToolStripPanel.Controls.Add(this.GlyphPalette1);
            this.ToolStripContainer.LeftToolStripPanel.Controls.Add(this.GlyphPalette2);
            this.ToolStripContainer.LeftToolStripPanel.Controls.Add(this.GlyphPalette3);
            this.ToolStripContainer.Location = new System.Drawing.Point(0, 27);
            this.ToolStripContainer.Name = "ToolStripContainer";
            this.ToolStripContainer.Size = new System.Drawing.Size(804, 477);
            this.ToolStripContainer.TabIndex = 1;
            // 
            // ToolStripContainer.TopToolStripPanel
            // 
            this.ToolStripContainer.TopToolStripPanel.Controls.Add(this.FileToolStrip);
            this.ToolStripContainer.TopToolStripPanel.Controls.Add(this.ToolsToolStrip);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusText,
            this.ToolStripSpringSpacer,
            this.LengthStatusText,
            this.LinesStatusText});
            this.StatusStrip.Location = new System.Drawing.Point(0, 0);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(804, 22);
            this.StatusStrip.TabIndex = 3;
            this.StatusStrip.Text = "StatusStrip";
            // 
            // StatusText
            // 
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(39, 17);
            this.StatusText.Text = "Ready";
            // 
            // ToolStripSpringSpacer
            // 
            this.ToolStripSpringSpacer.Name = "ToolStripSpringSpacer";
            this.ToolStripSpringSpacer.Size = new System.Drawing.Size(648, 17);
            this.ToolStripSpringSpacer.Spring = true;
            // 
            // LengthStatusText
            // 
            this.LengthStatusText.Name = "LengthStatusText";
            this.LengthStatusText.Size = new System.Drawing.Size(56, 17);
            this.LengthStatusText.Text = "Length: 0";
            this.LengthStatusText.ToolTipText = "Source length in characters";
            // 
            // LinesStatusText
            // 
            this.LinesStatusText.Name = "LinesStatusText";
            this.LinesStatusText.Size = new System.Drawing.Size(46, 17);
            this.LinesStatusText.Text = "Lines: 0";
            this.LinesStatusText.ToolTipText = "Source length in lines";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ProjectTreeView);
            this.splitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer1.Panel1MinSize = 150;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DocumentTabs);
            this.splitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitContainer1.Panel2MinSize = 150;
            this.splitContainer1.Size = new System.Drawing.Size(687, 424);
            this.splitContainer1.SplitterDistance = 214;
            this.splitContainer1.TabIndex = 3;
            // 
            // ProjectTreeView
            // 
            this.ProjectTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectTreeView.Cursor = System.Windows.Forms.Cursors.Default;
            this.ProjectTreeView.ImageIndex = 0;
            this.ProjectTreeView.ImageList = this.ProjectTreeImageList;
            this.ProjectTreeView.Location = new System.Drawing.Point(0, 0);
            this.ProjectTreeView.Name = "ProjectTreeView";
            treeNode1.ContextMenuStrip = this.GlyphLibraryContextMenu;
            treeNode1.ImageIndex = 6;
            treeNode1.Name = "LibraryNode";
            treeNode1.SelectedImageIndex = 6;
            treeNode1.Text = "Glyph Library: (default)";
            treeNode2.ImageIndex = 7;
            treeNode2.Name = "Size";
            treeNode2.SelectedImageIndex = 7;
            treeNode2.Text = "Size: A3 Landscape (297mm x 420mm)";
            treeNode3.ContextMenuStrip = this.ImageNodeContextMenu;
            treeNode3.ImageIndex = 4;
            treeNode3.Name = "ImageNode";
            treeNode3.SelectedImageIndex = 4;
            treeNode3.Text = "Images";
            treeNode4.ImageIndex = 2;
            treeNode4.Name = "ExampleText";
            treeNode4.SelectedImageIndex = 2;
            treeNode4.Text = "foo.text";
            treeNode5.ContextMenuStrip = this.TextNodeContextMenu;
            treeNode5.ImageIndex = 4;
            treeNode5.Name = "TextNode";
            treeNode5.SelectedImageIndex = 4;
            treeNode5.Text = "Text";
            treeNode6.ImageIndex = 4;
            treeNode6.Name = "PanelNode";
            treeNode6.SelectedImageIndex = 4;
            treeNode6.Text = "Panels";
            treeNode7.ImageKey = "FolderOpenLightBlue.png";
            treeNode7.Name = "PageNode";
            treeNode7.SelectedImageIndex = 4;
            treeNode7.Text = "Pages";
            treeNode8.ContextMenuStrip = this.ProjectNodeContextMenu;
            treeNode8.ImageIndex = 0;
            treeNode8.Name = "RootNode";
            treeNode8.SelectedImageIndex = 0;
            treeNode8.Text = "Project (Untitled)";
            this.ProjectTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.ProjectTreeView.SelectedImageIndex = 0;
            this.ProjectTreeView.Size = new System.Drawing.Size(215, 424);
            this.ProjectTreeView.TabIndex = 0;
            this.ProjectTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ProjectTreeView_AfterSelect);
            this.ProjectTreeView.DoubleClick += new System.EventHandler(this.ProjectTreeView_DoubleClick);
            // 
            // ProjectTreeImageList
            // 
            this.ProjectTreeImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ProjectTreeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ProjectTreeImageList.ImageStream")));
            this.ProjectTreeImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ProjectTreeImageList.Images.SetKeyName(0, "FolderOpened.png");
            this.ProjectTreeImageList.Images.SetKeyName(1, "FolderClosed.png");
            this.ProjectTreeImageList.Images.SetKeyName(2, "TextFile.png");
            this.ProjectTreeImageList.Images.SetKeyName(3, "Image.png");
            this.ProjectTreeImageList.Images.SetKeyName(4, "FolderOpenLightBlue.png");
            this.ProjectTreeImageList.Images.SetKeyName(5, "FolderClosedLightBlue.png");
            this.ProjectTreeImageList.Images.SetKeyName(6, "DialogGroup.png");
            this.ProjectTreeImageList.Images.SetKeyName(7, "PageContent.png");
            // 
            // DocumentTabs
            // 
            this.DocumentTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DocumentTabs.Controls.Add(this.FirstTab);
            this.DocumentTabs.Cursor = System.Windows.Forms.Cursors.Default;
            this.DocumentTabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.DocumentTabs.Enabled = false;
            this.DocumentTabs.ItemSize = new System.Drawing.Size(192, 20);
            this.DocumentTabs.Location = new System.Drawing.Point(3, -3);
            this.DocumentTabs.Name = "DocumentTabs";
            this.DocumentTabs.SelectedIndex = 0;
            this.DocumentTabs.ShowToolTips = true;
            this.DocumentTabs.Size = new System.Drawing.Size(469, 430);
            this.DocumentTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.DocumentTabs.TabIndex = 2;
            this.DocumentTabs.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.DocumentTabs_DrawItem);
            this.DocumentTabs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DocumentTabs_MouseDown);
            // 
            // FirstTab
            // 
            this.FirstTab.Location = new System.Drawing.Point(4, 24);
            this.FirstTab.Name = "FirstTab";
            this.FirstTab.Padding = new System.Windows.Forms.Padding(3);
            this.FirstTab.Size = new System.Drawing.Size(461, 402);
            this.FirstTab.TabIndex = 0;
            this.FirstTab.Text = "(new)";
            this.FirstTab.UseVisualStyleBackColor = true;
            // 
            // GlyphPalette1
            // 
            this.GlyphPalette1.Dock = System.Windows.Forms.DockStyle.None;
            this.GlyphPalette1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.GlyphPalette1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.GlyphPalette1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PaletteButtonA,
            this.PaletteButtonB,
            this.PaletteButtonC,
            this.PaletteButtonD,
            this.PaletteButtonE,
            this.PaletteButtonF,
            this.PaletteButtonG,
            this.PaletteButtonH,
            this.PaletteButtonI});
            this.GlyphPalette1.Location = new System.Drawing.Point(0, 0);
            this.GlyphPalette1.Name = "GlyphPalette1";
            this.GlyphPalette1.Size = new System.Drawing.Size(37, 430);
            this.GlyphPalette1.Stretch = true;
            this.GlyphPalette1.TabIndex = 4;
            // 
            // PaletteButtonA
            // 
            this.PaletteButtonA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PaletteButtonA.Image = global::PP1.Properties.Resources.A11;
            this.PaletteButtonA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PaletteButtonA.Name = "PaletteButtonA";
            this.PaletteButtonA.Size = new System.Drawing.Size(35, 36);
            this.PaletteButtonA.Tag = "A";
            this.PaletteButtonA.Text = "Man && His Occupations";
            this.PaletteButtonA.ToolTipText = "Man & His Occupations";
            this.PaletteButtonA.Click += new System.EventHandler(this.PaletteButton_Click);
            // 
            // PaletteButtonB
            // 
            this.PaletteButtonB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PaletteButtonB.Image = global::PP1.Properties.Resources.B1;
            this.PaletteButtonB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PaletteButtonB.Name = "PaletteButtonB";
            this.PaletteButtonB.Size = new System.Drawing.Size(35, 36);
            this.PaletteButtonB.Tag = "B";
            this.PaletteButtonB.Text = "Woman && Her Occupations";
            this.PaletteButtonB.ToolTipText = "Woman & Her Occupations";
            this.PaletteButtonB.Click += new System.EventHandler(this.PaletteButton_Click);
            // 
            // PaletteButtonC
            // 
            this.PaletteButtonC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PaletteButtonC.Image = global::PP1.Properties.Resources.C1;
            this.PaletteButtonC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PaletteButtonC.Name = "PaletteButtonC";
            this.PaletteButtonC.Size = new System.Drawing.Size(35, 36);
            this.PaletteButtonC.Tag = "C";
            this.PaletteButtonC.Text = "Gods && Goddesses";
            this.PaletteButtonC.ToolTipText = "Gods & Goddesses";
            this.PaletteButtonC.Click += new System.EventHandler(this.PaletteButton_Click);
            // 
            // PaletteButtonD
            // 
            this.PaletteButtonD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PaletteButtonD.Image = global::PP1.Properties.Resources.D1;
            this.PaletteButtonD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PaletteButtonD.Name = "PaletteButtonD";
            this.PaletteButtonD.Size = new System.Drawing.Size(35, 36);
            this.PaletteButtonD.Tag = "D";
            this.PaletteButtonD.Text = "Parts of the Human Body";
            this.PaletteButtonD.Click += new System.EventHandler(this.PaletteButton_Click);
            // 
            // PaletteButtonE
            // 
            this.PaletteButtonE.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PaletteButtonE.Image = global::PP1.Properties.Resources.E1;
            this.PaletteButtonE.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PaletteButtonE.Name = "PaletteButtonE";
            this.PaletteButtonE.Size = new System.Drawing.Size(35, 36);
            this.PaletteButtonE.Tag = "E";
            this.PaletteButtonE.Text = "Mammals";
            this.PaletteButtonE.Click += new System.EventHandler(this.PaletteButton_Click);
            // 
            // PaletteButtonF
            // 
            this.PaletteButtonF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PaletteButtonF.Image = global::PP1.Properties.Resources.F1;
            this.PaletteButtonF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PaletteButtonF.Name = "PaletteButtonF";
            this.PaletteButtonF.Size = new System.Drawing.Size(35, 36);
            this.PaletteButtonF.Tag = "F";
            this.PaletteButtonF.Text = "Parts of Mammals";
            this.PaletteButtonF.Click += new System.EventHandler(this.PaletteButton_Click);
            // 
            // PaletteButtonG
            // 
            this.PaletteButtonG.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PaletteButtonG.Image = global::PP1.Properties.Resources.G1;
            this.PaletteButtonG.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PaletteButtonG.Name = "PaletteButtonG";
            this.PaletteButtonG.Size = new System.Drawing.Size(35, 36);
            this.PaletteButtonG.Tag = "G";
            this.PaletteButtonG.Text = "Birds";
            this.PaletteButtonG.Click += new System.EventHandler(this.PaletteButton_Click);
            // 
            // PaletteButtonH
            // 
            this.PaletteButtonH.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PaletteButtonH.Image = global::PP1.Properties.Resources.H1;
            this.PaletteButtonH.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PaletteButtonH.Name = "PaletteButtonH";
            this.PaletteButtonH.Size = new System.Drawing.Size(35, 36);
            this.PaletteButtonH.Tag = "H";
            this.PaletteButtonH.Text = "Parts of Birds";
            this.PaletteButtonH.Click += new System.EventHandler(this.PaletteButton_Click);
            // 
            // PaletteButtonI
            // 
            this.PaletteButtonI.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PaletteButtonI.Image = global::PP1.Properties.Resources.I1;
            this.PaletteButtonI.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PaletteButtonI.Name = "PaletteButtonI";
            this.PaletteButtonI.Size = new System.Drawing.Size(35, 36);
            this.PaletteButtonI.Tag = "I";
            this.PaletteButtonI.Text = "Reptiles && Amphibians";
            this.PaletteButtonI.ToolTipText = "Reptiles & Amphibians";
            this.PaletteButtonI.Click += new System.EventHandler(this.PaletteButton_Click);
            // 
            // GlyphPalette2
            // 
            this.GlyphPalette2.Dock = System.Windows.Forms.DockStyle.None;
            this.GlyphPalette2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.GlyphPalette2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.GlyphPalette2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PaletteButtonK,
            this.PaletteButtonL,
            this.PaletteButtonM,
            this.PaletteButtonN,
            this.PaletteButtonNL,
            this.PaletteButtonO,
            this.PaletteButtonP,
            this.PaletteButtonQ,
            this.PaletteButtonR});
            this.GlyphPalette2.Location = new System.Drawing.Point(37, 0);
            this.GlyphPalette2.Name = "GlyphPalette2";
            this.GlyphPalette2.Size = new System.Drawing.Size(37, 430);
            this.GlyphPalette2.Stretch = true;
            this.GlyphPalette2.TabIndex = 5;
            // 
            // PaletteButtonK
            // 
            this.PaletteButtonK.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PaletteButtonK.Image = global::PP1.Properties.Resources.K1;
            this.PaletteButtonK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PaletteButtonK.Name = "PaletteButtonK";
            this.PaletteButtonK.Size = new System.Drawing.Size(35, 36);
            this.PaletteButtonK.Tag = "K";
            this.PaletteButtonK.Text = "Fish && Parts of Fish";
            this.PaletteButtonK.ToolTipText = "Fish & Parts of Fish";
            this.PaletteButtonK.Click += new System.EventHandler(this.PaletteButton_Click);
            // 
            // PaletteButtonL
            // 
            this.PaletteButtonL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PaletteButtonL.Image = global::PP1.Properties.Resources.L1;
            this.PaletteButtonL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PaletteButtonL.Name = "PaletteButtonL";
            this.PaletteButtonL.Size = new System.Drawing.Size(35, 36);
            this.PaletteButtonL.Tag = "L";
            this.PaletteButtonL.Text = "Insects";
            this.PaletteButtonL.Click += new System.EventHandler(this.PaletteButton_Click);
            // 
            // PaletteButtonM
            // 
            this.PaletteButtonM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PaletteButtonM.Image = global::PP1.Properties.Resources.M1;
            this.PaletteButtonM.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PaletteButtonM.Name = "PaletteButtonM";
            this.PaletteButtonM.Size = new System.Drawing.Size(35, 36);
            this.PaletteButtonM.Tag = "M";
            this.PaletteButtonM.Text = "Trees && Plants";
            this.PaletteButtonM.ToolTipText = "Trees & Plants";
            this.PaletteButtonM.Click += new System.EventHandler(this.PaletteButton_Click);
            // 
            // PaletteButtonN
            // 
            this.PaletteButtonN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PaletteButtonN.Image = global::PP1.Properties.Resources.N1;
            this.PaletteButtonN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PaletteButtonN.Name = "PaletteButtonN";
            this.PaletteButtonN.Size = new System.Drawing.Size(35, 36);
            this.PaletteButtonN.Tag = "N";
            this.PaletteButtonN.Text = "Sky, Earth && Water";
            this.PaletteButtonN.ToolTipText = "Sky, Earth & Water";
            this.PaletteButtonN.Click += new System.EventHandler(this.PaletteButton_Click);
            // 
            // PaletteButtonNL
            // 
            this.PaletteButtonNL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PaletteButtonNL.Image = global::PP1.Properties.Resources.NL1;
            this.PaletteButtonNL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PaletteButtonNL.Name = "PaletteButtonNL";
            this.PaletteButtonNL.Size = new System.Drawing.Size(35, 36);
            this.PaletteButtonNL.Tag = "NX";
            this.PaletteButtonNL.Text = "Nomes";
            this.PaletteButtonNL.Click += new System.EventHandler(this.PaletteButton_Click);
            // 
            // PaletteButtonO
            // 
            this.PaletteButtonO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PaletteButtonO.Image = global::PP1.Properties.Resources.O1;
            this.PaletteButtonO.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PaletteButtonO.Name = "PaletteButtonO";
            this.PaletteButtonO.Size = new System.Drawing.Size(35, 36);
            this.PaletteButtonO.Tag = "O";
            this.PaletteButtonO.Text = "Buildings && Parts of Buildings";
            this.PaletteButtonO.ToolTipText = "Buildings & Parts of Buildings";
            this.PaletteButtonO.Click += new System.EventHandler(this.PaletteButton_Click);
            // 
            // PaletteButtonP
            // 
            this.PaletteButtonP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PaletteButtonP.Image = global::PP1.Properties.Resources.P1;
            this.PaletteButtonP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PaletteButtonP.Name = "PaletteButtonP";
            this.PaletteButtonP.Size = new System.Drawing.Size(35, 36);
            this.PaletteButtonP.Tag = "P";
            this.PaletteButtonP.Text = "Ships && Parts of Ships";
            this.PaletteButtonP.ToolTipText = "Ships & Parts of Ships";
            this.PaletteButtonP.Click += new System.EventHandler(this.PaletteButton_Click);
            // 
            // PaletteButtonQ
            // 
            this.PaletteButtonQ.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PaletteButtonQ.Image = global::PP1.Properties.Resources.Q1;
            this.PaletteButtonQ.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PaletteButtonQ.Name = "PaletteButtonQ";
            this.PaletteButtonQ.Size = new System.Drawing.Size(35, 36);
            this.PaletteButtonQ.Tag = "Q";
            this.PaletteButtonQ.Text = "Furniture";
            this.PaletteButtonQ.Click += new System.EventHandler(this.PaletteButton_Click);
            // 
            // PaletteButtonR
            // 
            this.PaletteButtonR.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PaletteButtonR.Image = global::PP1.Properties.Resources.R1;
            this.PaletteButtonR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PaletteButtonR.Name = "PaletteButtonR";
            this.PaletteButtonR.Size = new System.Drawing.Size(35, 36);
            this.PaletteButtonR.Tag = "R";
            this.PaletteButtonR.Text = "Temple && Religion";
            this.PaletteButtonR.ToolTipText = "Temple & Religion";
            this.PaletteButtonR.Click += new System.EventHandler(this.PaletteButton_Click);
            // 
            // GlyphPalette3
            // 
            this.GlyphPalette3.Dock = System.Windows.Forms.DockStyle.None;
            this.GlyphPalette3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.GlyphPalette3.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.GlyphPalette3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PaletteButtonS,
            this.PaletteButtonT,
            this.PaletteButtonU,
            this.PaletteButtonV,
            this.PaletteButtonW,
            this.PaletteButtonX,
            this.PaletteButtonY,
            this.PaletteButtonZ,
            this.PaletteButtonAa});
            this.GlyphPalette3.Location = new System.Drawing.Point(74, 0);
            this.GlyphPalette3.Name = "GlyphPalette3";
            this.GlyphPalette3.Size = new System.Drawing.Size(37, 430);
            this.GlyphPalette3.Stretch = true;
            this.GlyphPalette3.TabIndex = 6;
            // 
            // PaletteButtonS
            // 
            this.PaletteButtonS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PaletteButtonS.Image = global::PP1.Properties.Resources.S1;
            this.PaletteButtonS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PaletteButtonS.Name = "PaletteButtonS";
            this.PaletteButtonS.Size = new System.Drawing.Size(35, 36);
            this.PaletteButtonS.Tag = "S";
            this.PaletteButtonS.Text = "Crowns, Clothes && Staves";
            this.PaletteButtonS.ToolTipText = "Crowns, Clothes & Staves";
            this.PaletteButtonS.Click += new System.EventHandler(this.PaletteButton_Click);
            // 
            // PaletteButtonT
            // 
            this.PaletteButtonT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PaletteButtonT.Image = global::PP1.Properties.Resources.T1;
            this.PaletteButtonT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PaletteButtonT.Name = "PaletteButtonT";
            this.PaletteButtonT.Size = new System.Drawing.Size(35, 36);
            this.PaletteButtonT.Tag = "T";
            this.PaletteButtonT.Text = "Warfare, Hunting && Butchery";
            this.PaletteButtonT.ToolTipText = "Warfare, Hunting & Butchery";
            this.PaletteButtonT.Click += new System.EventHandler(this.PaletteButton_Click);
            // 
            // PaletteButtonU
            // 
            this.PaletteButtonU.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PaletteButtonU.Image = global::PP1.Properties.Resources.U1;
            this.PaletteButtonU.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PaletteButtonU.Name = "PaletteButtonU";
            this.PaletteButtonU.Size = new System.Drawing.Size(35, 36);
            this.PaletteButtonU.Tag = "U";
            this.PaletteButtonU.Text = "Agriculture, Crafts && Professions";
            this.PaletteButtonU.ToolTipText = "Agriculture, Crafts & Professions";
            this.PaletteButtonU.Click += new System.EventHandler(this.PaletteButton_Click);
            // 
            // PaletteButtonV
            // 
            this.PaletteButtonV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PaletteButtonV.Image = global::PP1.Properties.Resources.V1;
            this.PaletteButtonV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PaletteButtonV.Name = "PaletteButtonV";
            this.PaletteButtonV.Size = new System.Drawing.Size(35, 36);
            this.PaletteButtonV.Tag = "V";
            this.PaletteButtonV.Text = "Rope, Fiber, Baskets && Bags";
            this.PaletteButtonV.ToolTipText = "Rope, Fiber, Baskets & Bags";
            this.PaletteButtonV.Click += new System.EventHandler(this.PaletteButton_Click);
            // 
            // PaletteButtonW
            // 
            this.PaletteButtonW.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PaletteButtonW.Image = global::PP1.Properties.Resources.W1;
            this.PaletteButtonW.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PaletteButtonW.Name = "PaletteButtonW";
            this.PaletteButtonW.Size = new System.Drawing.Size(35, 36);
            this.PaletteButtonW.Tag = "W";
            this.PaletteButtonW.Text = "Vessels";
            this.PaletteButtonW.Click += new System.EventHandler(this.PaletteButton_Click);
            // 
            // PaletteButtonX
            // 
            this.PaletteButtonX.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PaletteButtonX.Image = global::PP1.Properties.Resources.X1;
            this.PaletteButtonX.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PaletteButtonX.Name = "PaletteButtonX";
            this.PaletteButtonX.Size = new System.Drawing.Size(35, 36);
            this.PaletteButtonX.Tag = "X";
            this.PaletteButtonX.Text = "Bread";
            this.PaletteButtonX.Click += new System.EventHandler(this.PaletteButton_Click);
            // 
            // PaletteButtonY
            // 
            this.PaletteButtonY.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PaletteButtonY.Image = global::PP1.Properties.Resources.Y1;
            this.PaletteButtonY.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PaletteButtonY.Name = "PaletteButtonY";
            this.PaletteButtonY.Size = new System.Drawing.Size(35, 36);
            this.PaletteButtonY.Tag = "Y";
            this.PaletteButtonY.Text = "Writing, Games && Music";
            this.PaletteButtonY.ToolTipText = "Writing, Games & Music";
            this.PaletteButtonY.Click += new System.EventHandler(this.PaletteButton_Click);
            // 
            // PaletteButtonZ
            // 
            this.PaletteButtonZ.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PaletteButtonZ.Image = global::PP1.Properties.Resources.Z1;
            this.PaletteButtonZ.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PaletteButtonZ.Name = "PaletteButtonZ";
            this.PaletteButtonZ.Size = new System.Drawing.Size(35, 36);
            this.PaletteButtonZ.Tag = "Z";
            this.PaletteButtonZ.Text = "Strokes";
            this.PaletteButtonZ.Click += new System.EventHandler(this.PaletteButton_Click);
            // 
            // PaletteButtonAa
            // 
            this.PaletteButtonAa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PaletteButtonAa.Image = global::PP1.Properties.Resources.J1;
            this.PaletteButtonAa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PaletteButtonAa.Name = "PaletteButtonAa";
            this.PaletteButtonAa.Size = new System.Drawing.Size(35, 36);
            this.PaletteButtonAa.Tag = "AA";
            this.PaletteButtonAa.Text = "Unclassified";
            this.PaletteButtonAa.Click += new System.EventHandler(this.PaletteButton_Click);
            // 
            // FileToolStrip
            // 
            this.FileToolStrip.CanOverflow = false;
            this.FileToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.FileToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewFileButton,
            this.OpenFileButton,
            this.SaveButton,
            this.SaveAllButton,
            this.DeleteFileButton});
            this.FileToolStrip.Location = new System.Drawing.Point(3, 0);
            this.FileToolStrip.Name = "FileToolStrip";
            this.FileToolStrip.Size = new System.Drawing.Size(127, 25);
            this.FileToolStrip.TabIndex = 0;
            // 
            // NewFileButton
            // 
            this.NewFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewFileButton.Image = global::PP1.Properties.Resources.AddDocument;
            this.NewFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewFileButton.Name = "NewFileButton";
            this.NewFileButton.Size = new System.Drawing.Size(23, 22);
            this.NewFileButton.Text = "Add New File";
            this.NewFileButton.Click += new System.EventHandler(this.NewFileButton_Click);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenFileButton.Image = global::PP1.Properties.Resources.OpenFolder;
            this.OpenFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(23, 22);
            this.OpenFileButton.Text = "Add Existing FIle";
            // 
            // SaveButton
            // 
            this.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveButton.Enabled = false;
            this.SaveButton.Image = global::PP1.Properties.Resources.Save;
            this.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(23, 22);
            this.SaveButton.Text = "Save";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SaveAllButton
            // 
            this.SaveAllButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveAllButton.Image = global::PP1.Properties.Resources.SaveAll;
            this.SaveAllButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveAllButton.Name = "SaveAllButton";
            this.SaveAllButton.Size = new System.Drawing.Size(23, 22);
            this.SaveAllButton.Text = "Save All";
            this.SaveAllButton.Click += new System.EventHandler(this.SaveAllButton_Click);
            // 
            // DeleteFileButton
            // 
            this.DeleteFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteFileButton.Image = global::PP1.Properties.Resources.Delete;
            this.DeleteFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteFileButton.Name = "DeleteFileButton";
            this.DeleteFileButton.Size = new System.Drawing.Size(23, 22);
            this.DeleteFileButton.Text = "Remove File";
            this.DeleteFileButton.Click += new System.EventHandler(this.DeleteFileButton_Click);
            // 
            // ToolsToolStrip
            // 
            this.ToolsToolStrip.CanOverflow = false;
            this.ToolsToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.ToolsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DictionaryButton,
            this.GlyphLibraryButton});
            this.ToolsToolStrip.Location = new System.Drawing.Point(130, 0);
            this.ToolsToolStrip.Name = "ToolsToolStrip";
            this.ToolsToolStrip.Size = new System.Drawing.Size(58, 25);
            this.ToolsToolStrip.TabIndex = 3;
            this.ToolsToolStrip.Text = "toolStrip1";
            // 
            // DictionaryButton
            // 
            this.DictionaryButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DictionaryButton.Image = global::PP1.Properties.Resources.SortAscending;
            this.DictionaryButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DictionaryButton.Name = "DictionaryButton";
            this.DictionaryButton.Size = new System.Drawing.Size(23, 22);
            this.DictionaryButton.Text = "Dictionary";
            this.DictionaryButton.Click += new System.EventHandler(this.DictionaryButton_Click);
            // 
            // GlyphLibraryButton
            // 
            this.GlyphLibraryButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GlyphLibraryButton.Image = global::PP1.Properties.Resources.Abbreviation;
            this.GlyphLibraryButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GlyphLibraryButton.Name = "GlyphLibraryButton";
            this.GlyphLibraryButton.Size = new System.Drawing.Size(23, 22);
            this.GlyphLibraryButton.Text = "Glyph Library";
            this.GlyphLibraryButton.Click += new System.EventHandler(this.GlyphLibraryButton_Click);
            // 
            // AddImageDialog
            // 
            this.AddImageDialog.Filter = "PNG image (*.png)|*.png|All Files (*.*)|*.*";
            // 
            // AddTextDialog
            // 
            this.AddTextDialog.Filter = "Text (*.text)|*.text|Plain text (*.txt)|*.txt|All Files (*.*)|*.*";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 505);
            this.Controls.Add(this.ToolStripContainer);
            this.Controls.Add(this.MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.LocationChanged += new System.EventHandler(this.MainWindow_LocationChanged);
            this.SizeChanged += new System.EventHandler(this.MainWindow_SizeChanged);
            this.Move += new System.EventHandler(this.MainWindow_Move);
            this.GlyphLibraryContextMenu.ResumeLayout(false);
            this.ImageNodeContextMenu.ResumeLayout(false);
            this.TextNodeContextMenu.ResumeLayout(false);
            this.ProjectNodeContextMenu.ResumeLayout(false);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ToolStripContainer.BottomToolStripPanel.ResumeLayout(false);
            this.ToolStripContainer.BottomToolStripPanel.PerformLayout();
            this.ToolStripContainer.ContentPanel.ResumeLayout(false);
            this.ToolStripContainer.LeftToolStripPanel.ResumeLayout(false);
            this.ToolStripContainer.LeftToolStripPanel.PerformLayout();
            this.ToolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.ToolStripContainer.TopToolStripPanel.PerformLayout();
            this.ToolStripContainer.ResumeLayout(false);
            this.ToolStripContainer.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.DocumentTabs.ResumeLayout(false);
            this.GlyphPalette1.ResumeLayout(false);
            this.GlyphPalette1.PerformLayout();
            this.GlyphPalette2.ResumeLayout(false);
            this.GlyphPalette2.PerformLayout();
            this.GlyphPalette3.ResumeLayout(false);
            this.GlyphPalette3.PerformLayout();
            this.FileToolStrip.ResumeLayout(false);
            this.FileToolStrip.PerformLayout();
            this.ToolsToolStrip.ResumeLayout(false);
            this.ToolsToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer ToolStripContainer;
        private System.Windows.Forms.TabControl DocumentTabs;
        private System.Windows.Forms.TabPage FirstTab;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusText;
        private System.Windows.Forms.ToolStripStatusLabel LengthStatusText;
        private System.Windows.Forms.ToolStripStatusLabel LinesStatusText;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripSpringSpacer;
        private System.Windows.Forms.ToolStrip FileToolStrip;
        private System.Windows.Forms.ToolStripButton NewFileButton;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton OpenFileButton;
        private System.Windows.Forms.ToolStripButton SaveButton;
        private System.Windows.Forms.ToolStripButton SaveAllButton;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog SaveProjectDialog;
        private System.Windows.Forms.ToolStripMenuItem closeProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.OpenFileDialog OpenProjectDialog;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView ProjectTreeView;
        private System.Windows.Forms.ImageList ProjectTreeImageList;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateGlyphTemplatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dictionaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem glyphLibraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadBaseGlyphLibraryToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip GlyphLibraryContextMenu;
        private System.Windows.Forms.ToolStripMenuItem openInEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem resetToDefaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem fileToolbarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolbarToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton DeleteFileButton;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeFileToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip TextNodeContextMenu;
        private System.Windows.Forms.ToolStripMenuItem addNewTextToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ImageNodeContextMenu;
        private System.Windows.Forms.ToolStripMenuItem addNewImageToolStripMenuItem;
        private System.Windows.Forms.ToolStrip ToolsToolStrip;
        private System.Windows.Forms.ToolStripButton DictionaryButton;
        private System.Windows.Forms.ToolStripButton GlyphLibraryButton;
        private System.Windows.Forms.OpenFileDialog AddImageDialog;
        private System.Windows.Forms.OpenFileDialog AddTextDialog;
        private System.Windows.Forms.ContextMenuStrip ProjectNodeContextMenu;
        private System.Windows.Forms.ToolStripMenuItem saveProjectAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem closeProjectToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recentProjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem generateGridTemplateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem10;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem1;
        private System.Windows.Forms.ToolStrip GlyphPalette1;
        private System.Windows.Forms.ToolStripButton PaletteButtonA;
        private System.Windows.Forms.ToolStripButton PaletteButtonB;
        private System.Windows.Forms.ToolStripButton PaletteButtonC;
        private System.Windows.Forms.ToolStripButton PaletteButtonD;
        private System.Windows.Forms.ToolStripButton PaletteButtonE;
        private System.Windows.Forms.ToolStripButton PaletteButtonF;
        private System.Windows.Forms.ToolStrip GlyphPalette3;
        private System.Windows.Forms.ToolStripButton PaletteButtonS;
        private System.Windows.Forms.ToolStripButton PaletteButtonT;
        private System.Windows.Forms.ToolStripButton PaletteButtonU;
        private System.Windows.Forms.ToolStripButton PaletteButtonV;
        private System.Windows.Forms.ToolStripButton PaletteButtonW;
        private System.Windows.Forms.ToolStripButton PaletteButtonX;
        private System.Windows.Forms.ToolStripButton PaletteButtonY;
        private System.Windows.Forms.ToolStripButton PaletteButtonZ;
        private System.Windows.Forms.ToolStripButton PaletteButtonAa;
        private System.Windows.Forms.ToolStrip GlyphPalette2;
        private System.Windows.Forms.ToolStripButton PaletteButtonK;
        private System.Windows.Forms.ToolStripButton PaletteButtonL;
        private System.Windows.Forms.ToolStripButton PaletteButtonM;
        private System.Windows.Forms.ToolStripButton PaletteButtonN;
        private System.Windows.Forms.ToolStripButton PaletteButtonNL;
        private System.Windows.Forms.ToolStripButton PaletteButtonO;
        private System.Windows.Forms.ToolStripButton PaletteButtonP;
        private System.Windows.Forms.ToolStripButton PaletteButtonQ;
        private System.Windows.Forms.ToolStripButton PaletteButtonR;
        private System.Windows.Forms.ToolStripButton PaletteButtonG;
        private System.Windows.Forms.ToolStripButton PaletteButtonH;
        private System.Windows.Forms.ToolStripButton PaletteButtonI;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem hieroglyphPaletteToolStripMenuItem;
    }
}

