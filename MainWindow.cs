using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP1
{
    public partial class MainWindow : Form
    {

        private readonly Component[] EnableIfProject;
        private readonly Component[] EnableIfFileSelected;
        private readonly Component[] EnableIfFileOpen;
        private TabPage tabPageTemplate = null;
        private Dictionary<TreeNode, Content> currentContentMap = new Dictionary<TreeNode, Content>();

        private bool settingsLoaded = false;
        public MainWindow()
        {
            InitializeComponent();

            EnableIfProject = new Component[]
            {
                NewFileButton,
                OpenFileButton,
                SaveButton,
                SaveAllButton,
                saveAsToolStripMenuItem,
                saveToolStripMenuItem,
                DocumentTabs,
                closeProjectToolStripMenuItem,
                ProjectTreeView,
                newFileToolStripMenuItem,
                openFileToolStripMenuItem
            };

            EnableIfFileSelected = new Component[]
            {
                DeleteFileButton
            };


            EnableIfFileOpen = new Component[]
            {
                closeFileToolStripMenuItem
            };

            DisableProjectUI();

            instance = this;
        }

        private void DisableProjectUI()
        {
            EnableProjectUI(false);
        }

        private void DisableFileOpenUI()
        {
            EnableFileOpenUI(false);
        }

        private void DisableFileSelectedUI()
        {
            EnableFileSelectedUI(false);
        }

        private void EnableProjectUI(bool enabled = true)
        {
            foreach (Component c in EnableIfProject)
            {
                ToolStripItem tsi = c as ToolStripItem;
                if (tsi != null)
                {
                    tsi.Enabled = enabled;
                }
                Control control = c as Control;
                if (control != null)
                {
                    control.Enabled = enabled;
                }
            }
        }

        private void EnableFileSelectedUI(bool enabled = true)
        {
            foreach (Component c in EnableIfFileSelected)
            {
                ToolStripItem tsi = c as ToolStripItem;
                if (tsi != null)
                {
                    tsi.Enabled = enabled;
                }
                Control control = c as Control;
                if (control != null)
                {
                    control.Enabled = enabled;
                }
            }
        }

        private void EnableFileOpenUI(bool enabled = true)
        {
            foreach (Component c in EnableIfFileOpen)
            {
                ToolStripItem tsi = c as ToolStripItem;
                if (tsi != null)
                {
                    tsi.Enabled = enabled;
                }
                Control control = c as Control;
                if (control != null)
                {
                    control.Enabled = enabled;
                }
            }
        }

        private static string MakeRelativePath(string inputPath)
        {
            string path = inputPath;
            string basePath = Path.GetDirectoryName(Program.GetProjectPath());
            if ((basePath != null) && (basePath != "") && (path != ""))
            {
                path = Path.GetRelativePath(basePath, path);
            }
            return path;
        }

        public static void SaveProjectAs()
        {
            instance.HandleSaveProjectAs();
        }

        private void HandleProjectChange()
        {
            Project project = Program.GetProject();
            Text = Program.Name;
            ProjectTreeView.Nodes[0].Expand();
            ProjectTreeView.Nodes[0].Nodes[0].Text = "Glyph Library: (default)";
            bool hasProject = project != null;
            if (hasProject)
            {
                Text = project.Name + " - " + Program.Name;
                if(project.IsDirty())
                {
                    Text += "*";
                }
                //bool hasProjectPath = hasProject && (Program.GetProjectPath() != "");
                string path = project.BaseGlyphLibrary.GetPath();
                if (path == "")
                {
                    path = "(default)";
                }
                else
                {
                    path = MakeRelativePath(path);
                }

                ProjectTreeView.Nodes[0].Nodes[0].Text = "Glyph Library: " + path;
            }

            EnableProjectUI(hasProject);
            EnableFileSelectedUI(false);
            EnableFileOpenUI(false);

            glyphLibraryEditorWindow.UpdateAll();

            UpdateProjectFiles();
        }

        private void HandleSaveProjectAs()
        {
            if(SaveProjectDialog.ShowDialog() == DialogResult.OK)
            {
                Program.UpdateProjectPath(SaveProjectDialog.FileName);
                Program.SaveProject();
                HandleProjectChange();
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            tabPageTemplate = DocumentTabs.TabPages[0];
            DocumentTabs.TabPages.Clear();
            HandleSettingsLoad();
            // TODO: load last project?
            HandleProjectChange();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show(
                "Are you sure you want to quit?",
                Program.Name,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No;
        }

        private void NewFileButton_Click(object sender, EventArgs e)
        {
            AddNewFile();
        }

        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.NewProject();

            HandleProjectChange();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: if a file is open, and save that if its dirty...
            Program.SaveProject();
        }

        private static MainWindow instance = null;

        private void closeProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.CloseProject();

            HandleProjectChange();
        }

        private void openProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(OpenProjectDialog.ShowDialog() == DialogResult.OK)
            {
                if(Program.OpenProject(OpenProjectDialog.FileName) == false)
                {
                    MessageBox.Show(
                        "Failed to load project: " + OpenProjectDialog.FileName,
                        Program.Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                HandleProjectChange();
            }
        }

        private void generateGlyphTemplatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlyphTemplateWindow newWindow = new GlyphTemplateWindow();
            newWindow.ShowDialog();
        }

        private void dictionaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimpleDictionary dic = new SimpleDictionary();
            dic.ShowDialog();
        }

        private void glyphLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HandleGlyphLibraryToggle(false);
        }

        public void HandleGlyphLibraryToggle(bool noAction = true)
        {
            if (noAction == false)
            {
                if (glyphLibraryToolStripMenuItem.Checked)
                {
                    glyphLibraryEditorWindow.Show();
                }
                else
                {
                    glyphLibraryEditorWindow.Hide();
                }

                //glyphLibraryEditorWindow.UpdateAll();

                glyphLibraryEditorWindow.MainWindow = this;
                glyphLibraryEditorWindow.MainWindowMenuItem = glyphLibraryToolStripMenuItem;
            }

            Properties.Settings.Default.GlyphLibraryOpen = glyphLibraryToolStripMenuItem.Checked;
            Properties.Settings.Default.Save();
        }

        private void HandleSettingsLoad()
        {
            Properties.Settings settings = Properties.Settings.Default;
            glyphLibraryToolStripMenuItem.Checked = settings.GlyphLibraryOpen;

            HandleGlyphLibraryToggle(false);

            if(settings.MainWindowX < 2000)
            {
                settings.MainWindowX = 0;
            }
            else if (settings.MainWindowX > 20000)
            {
                settings.MainWindowX = 0;
            }

            if (settings.MainWindowY < 2000)
            {
                settings.MainWindowY = 0;
            }
            else if (settings.MainWindowY > 20000)
            {
                settings.MainWindowY = 0;
            }

            if (settings.Maximised == true)
            {
                this.WindowState = FormWindowState.Maximized;
                //this.MinimumSize = this.Size;
                //this.MaximumSize = this.Size;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                Size = new Size((int)settings.MainWindowSizeX, (int)settings.MainWindowSizeY);
                Left = (int)settings.MainWindowX;
                Top = (int)settings.MainWindowY;
            }

            settingsLoaded = true;

            UpdateRecentFileLists();
        }

        public void UpdateRecentFileLists()
        {
            Properties.Settings settings = Properties.Settings.Default;
            recentProjectsToolStripMenuItem.DropDownItems.Clear();
            if(settings.RecentProjects == null)
            {
                settings.RecentProjects = new StringCollection();
            }
            int i = 1;
            foreach (string file in settings.RecentProjects)
            {
                ToolStripItem item = recentProjectsToolStripMenuItem.DropDownItems.Add("&" + i.ToString() + ": " + file);
                ++i;
                item.Click += recentProject_Click;
            }
            settings.Save();
        }

        public void AddMostRecentProjectFile(string path)
        {
            Properties.Settings settings = Properties.Settings.Default;
            if (settings.RecentProjects == null)
            {
                settings.RecentProjects = new StringCollection();
                settings.RecentProjects.Add(path);
                settings.Save();
                return;
            }

            if (settings.RecentProjects.Contains(path))
            {
                settings.RecentProjects.Remove(path);
            }
            else if (settings.RecentProjects.Count >= 5)
            {
                settings.RecentProjects.RemoveAt(4);
            }

            settings.RecentProjects.Insert(0, path);
            settings.Save();
        }

        private void recentProject_Click(object sender, EventArgs e)
        {
            ToolStripItem item = sender as ToolStripItem;
            if(item != null)
            {
                string filePath = item.Text.Substring(4, item.Text.Length - 4);
                Program.OpenProject(filePath);
                HandleProjectChange();
            }
        }

        private void UpdateSizeSettings()
        {
            if(settingsLoaded == false)
            {
                return;
            }

            Properties.Settings settings = Properties.Settings.Default;
            settings.Maximised = WindowState == FormWindowState.Maximized;
            settings.MainWindowSizeX = (uint)Width;
            settings.MainWindowSizeY = (uint)Height;
            settings.MainWindowX = (uint)Left;
            settings.MainWindowY = (uint)Top;
            settings.Save();
        }

        private void UpdateProjectFiles()
        {
            TreeNode[] nodes = ProjectTreeView.Nodes.Find("TextNode", true);
            TreeNode textNode = nodes[0];
            nodes = ProjectTreeView.Nodes.Find("ImageNode", true);
            TreeNode imageNode = nodes[0];
            nodes = ProjectTreeView.Nodes.Find("PanelNode", true);
            TreeNode panelNode = nodes[0];
            textNode.Nodes.Clear();
            imageNode.Nodes.Clear();
            panelNode.Nodes.Clear();

            currentContentMap.Clear();

            Project project = Program.GetProject();
            if(project == null)
            {
                return;
            }

            int count = project.GetFileCount();
            for(int i = 0; i < count; ++i)
            {
                TreeNode newNode = new TreeNode();
                Content content = project.GetContentForFile(i);
                if(content == null)
                {
                    continue;
                }
                newNode.Text = MakeRelativePath(content.GetPath());
                currentContentMap.Add(newNode, content);
                if (content is PNGContent)
                {
                    newNode.ImageIndex = newNode.SelectedImageIndex = 3;
                    imageNode.Nodes.Add(newNode);
                    imageNode.Expand();
                }
                else if(content is TextContent)
                {
                    newNode.ImageIndex = newNode.SelectedImageIndex = 2;
                    textNode.Nodes.Add(newNode);
                    textNode.Expand();
                }
                else if (content is PanelContent)
                {
                    newNode.ImageIndex = newNode.SelectedImageIndex = 2;
                    panelNode.Nodes.Add(newNode);
                    panelNode.Expand();
                }
                // TODO: ... other cases
            }
        }

        private void OpenFileInProject(Content content)
        {
            string title = "(no file)";
            if (content.HasPath())
            {
                title = MakeRelativePath(content.GetPath());
            }
            //TabPage newPage = tabPageTemplate.Dupl
            TabPage newPage = new TabPage(title);
            newPage.ToolTipText = title;
            DocumentTabs.TabPages.Add(newPage);

            if (content is TextContent)
            {
                TextContentView newView = new TextContentView();
                newPage.Controls.Add(newView);
                newView.ProjectContent = content as TextContent;
                newView.Page = newPage;
                newView.Width = newPage.Width;
                newView.Height = newPage.Height;
                newView.Left = 0;
                newView.Top = 0;
                newView.Anchor = AnchorStyles.Top
                    | AnchorStyles.Bottom
                    | AnchorStyles.Left
                    | AnchorStyles.Right;

                newView.LoadFromContent();
                //newPage.Focus();
                DocumentTabs.SelectedTab = newPage;
                return;
            }
            else if(content is PanelContent)
            {
                PanelContentView newView = new PanelContentView();
                newPage.Controls.Add(newView);
                newView.ProjectContent = content as PanelContent;
                newView.Page = newPage;
                newView.Width = newPage.Width;
                newView.Height = newPage.Height;
                newView.Left = 0;
                newView.Top = 0;
                newView.Anchor = AnchorStyles.Top
                    | AnchorStyles.Bottom
                    | AnchorStyles.Left
                    | AnchorStyles.Right;

                newView.LoadFromContent();
                //newPage.Focus();
                DocumentTabs.SelectedTab = newPage;
                return;
            }
        }

        private GlyphLibraryEditor glyphLibraryEditorWindow = new GlyphLibraryEditor();

        private void loadBaseGlyphLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HandleSaveProjectAs();
        }

        private void ProjectTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (ProjectTreeView.SelectedNode == null)
            {
                EnableFileSelectedUI(false);
                return;
            }

            TreeNode parent = ProjectTreeView.SelectedNode.Parent;
            if(parent == null)
            {
                EnableFileSelectedUI(false);
                return;
            }

            EnableFileSelectedUI(
                (parent.Name == "TextNode")
                || (parent.Name == "ImageNode")
                || (parent.Name == "PageNode")
                || (parent.Name == "PanelNode"));
        }

        private void resetToDefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Project project = Program.GetProject();
            if (project != null)
            {
                if (project.BaseGlyphLibrary != GlyphLibrary.Default)
                {
                    project.ReplaceBaseGlyphLibrary(GlyphLibrary.Default);
                    HandleProjectChange();
                }
            }
        }

        private void openInEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (glyphLibraryEditorWindow.Visible == false)
            {
                glyphLibraryEditorWindow.Show();
            }

            glyphLibraryEditorWindow.ShowForProject();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Project project = Program.GetProject();
            if (project != null)
            {
                GlyphLibraryReport.ShowReportDialog(project.FinalGlyphLibrary);
            }
        }

        private void fileToolbarToolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
        {
            FileToolStrip.Visible = fileToolbarToolStripMenuItem.CheckState == CheckState.Checked;
        }

        private void MainWindow_SizeChanged(object sender, EventArgs e)
        {
            UpdateSizeSettings();
        }

        private void MainWindow_Move(object sender, EventArgs e)
        {
            //UpdateSizeSettings();
        }

        private void MainWindow_LocationChanged(object sender, EventArgs e)
        {
            UpdateSizeSettings();
        }

        private void toolsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ToolsToolStrip.Visible = toolsToolStripMenuItem1.CheckState == CheckState.Checked;
        }

        private void addNewImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(AddImageDialog.ShowDialog() == DialogResult.OK)
            {
                // add the imge file
                Project project = Program.GetProject();
                if(project == null)
                {
                    // TODO: error?
                    return;
                }

                if (File.Exists(AddImageDialog.FileName))
                {
                    project.AddSourceFile(AddImageDialog.FileName);
                }
            }

            UpdateProjectFiles();
        }

        private void addNewTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AddTextDialog.ShowDialog() == DialogResult.OK)
            {
                // add the imge file
                Project project = Program.GetProject();
                if (project == null)
                {
                    // TODO: error?
                    return;
                }

                if (File.Exists(AddTextDialog.FileName))
                {
                    project.AddSourceFile(AddTextDialog.FileName);
                }
            }

           UpdateProjectFiles();
        }

        private void saveProjectAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.SaveProjectAs();
        }

        private void closeProjectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Program.CloseProject();

            HandleProjectChange();
        }

        private void DictionaryButton_Click(object sender, EventArgs e)
        {
            dictionaryToolStripMenuItem_Click(sender, e);
        }

        private void GlyphLibraryButton_Click(object sender, EventArgs e)
        {
            glyphLibraryToolStripMenuItem.Checked = true;
            glyphLibraryToolStripMenuItem_Click(sender, e);
            glyphLibraryEditorWindow.Focus();
        }

        private void DocumentTabs_DrawItem(object sender, DrawItemEventArgs e)
        {
            // TODO: magic numbers from stack overflow. should be improved.
            Rectangle closeBoxRectangle = new Rectangle(
                new Point(e.Bounds.Right - 15, e.Bounds.Top + 7),
                new Size(11, 11));

            StringFormat format = new StringFormat();
            format.Trimming = StringTrimming.EllipsisPath;
            Brush darkBrush = DocumentTabs.Enabled ? Brushes.Black : Brushes.DarkGray;
            // draw 'x'
            //e.Graphics.Clear(Color.Transparent);
            e.Graphics.FillEllipse(DocumentTabs.Enabled ? Brushes.Pink : Brushes.LightGray, closeBoxRectangle);
            //e.Graphics.DrawEllipse(DocumentTabs.Enabled ? Pens.Black : Pens.Gray, closeBoxRectangle);
            e.Graphics.DrawString("x", e.Font, darkBrush, e.Bounds.Right - 14, e.Bounds.Top + 3);
            
            Rectangle textBounds = e.Bounds;
            textBounds.Location = new Point(textBounds.Location.X + 12, textBounds.Location.Y + 4);
            textBounds.Size = new Size(textBounds.Size.Width - 24, textBounds.Size.Height - 4);

            e.Graphics.DrawString(DocumentTabs.TabPages[e.Index].Text, e.Font, darkBrush, textBounds, format);
            
            e.DrawFocusRectangle();
        }

        private void DocumentTabs_MouseDown(object sender, MouseEventArgs e)
        {
            // TODO: this needs improvement.
            for (int i = 0; i < DocumentTabs.TabPages.Count; i++)
            {
                Rectangle r = DocumentTabs.GetTabRect(i);
                Rectangle closeButton = new Rectangle(r.Right - 15, r.Top + 2, 13, 12);
                if (closeButton.Contains(e.Location))
                {
                    CloseFileTab(i);
                    break;
                }
            }
        }

        private void CloseFileTab(int index)
        {
            // TODO: this is... awful
            if (this.DocumentTabs.TabPages[index].Text.EndsWith("*"))
            {
                if (MessageBox.Show("Would you like to save this file before closing it?", Program.Name,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SaveFileByTabIndex(index);
                }
            }

            this.DocumentTabs.TabPages.RemoveAt(index);
        }

        private void SaveFileByTabIndex(int index)
        {
            // ..
            //TabPage page = this.DocumentTabs.TabPages[index];
            //if (currentContentMap.ContainsKey(page))
            //{
            //    currentContentMap[page]
            //}
        }

        private void ProjectTreeView_DoubleClick(object sender, EventArgs e)
        {
            if(ProjectTreeView.SelectedNode == null)
            {
                return;
            }

            TreeNode node = ProjectTreeView.SelectedNode;
            if(currentContentMap.ContainsKey(node))
            {
                OpenFileInProject(currentContentMap[node]);
            }
        }

        private void newTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewFile();
        }

        private void AddNewFile()
        {
            Project project = Program.GetProject();
            if (project == null)
            {
                return;
            }

            project.AddNewText();

            UpdateProjectFiles();
        }

        private void DeleteFileButton_Click(object sender, EventArgs e)
        {
            Project project = Program.GetProject();
            if (project == null)
            {
                return;
            }

            // TODO: ...
        }

        private void generateGridTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenericTemplateWindow dialog = new GenericTemplateWindow();
            dialog.ShowDialog();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveCurrentFile();
        }

        private void SaveAllButton_Click(object sender, EventArgs e)
        {
            SaveAll();
        }

        private void SaveAll()
        {
            Project project = Program.GetProject();
            if(project == null)
            {
                return;
            }

            //project.SaveAll();
        }

        private void SaveCurrentFile()
        {
            SaveFileByTabIndex(DocumentTabs.SelectedIndex);
        }

        private void hieroglyphPaletteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // this order is a bit insane 
            GlyphPalette2.Visible = hieroglyphPaletteToolStripMenuItem.Checked;
            GlyphPalette3.Visible = hieroglyphPaletteToolStripMenuItem.Checked;
            GlyphPalette1.Visible = hieroglyphPaletteToolStripMenuItem.Checked;
        }

        private void PaletteButton_Click(object sender, EventArgs e)
        {
            ToolStripItemClickedEventArgs args = e as ToolStripItemClickedEventArgs;
            ToolStripButton source = sender as ToolStripButton;
            if(source == null)
            {
                return;
            }

            string prefix = source.Tag as string;
            GlyphSubPalette dropdown = new GlyphSubPalette(prefix);
            dropdown.Show();
            dropdown.Left = MousePosition.X;
            dropdown.Top = MousePosition.Y;
        }

        private void generateTeXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TexGenerators dialog = new TexGenerators();
            dialog.ShowDialog();
        }
    }
}
