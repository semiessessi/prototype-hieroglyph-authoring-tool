using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PP1
{
    public partial class GlyphLibraryEditor : Form
    {
        public ToolStripMenuItem MainWindowMenuItem = null;
        public MainWindow MainWindow = null;

        public static readonly string[] ExampleTexts = new string[]
        {
            "sbA A30 Y1a r a rA C2a x f t w b n rA f im axt t pr ab b t t N25 n t p t pt i N iri st A43 sS nTr Htp H t n nTr nTr nTr nb Z2 a n Z2 y A1"
        };
        
        private GlyphLibrary glyphLibrary = GlyphLibrary.Default;
        private string lastLibraryPath = "";

        public GlyphLibraryEditor()
        {
            InitializeComponent();
        }

        public void ShowForProject()
        {
            LibraryCombo.SelectedIndex = 2;
            UpdateAll();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GlyphLibraryEditor_Load(object sender, EventArgs e)
        {
            LibraryCombo.SelectedIndex = 2;

            // populate the combo box.
            ICollection<Letter> letters = Letters.GetAllGardinerSigns();
            GlyphPreviewCombo.Items.Clear();
            foreach(Letter letter in letters)
            {
                // TODO: better than hacks.
                if(letter.Transliteration().Length > 1)
                {
                    string name = Letters.CanonicaliseGardinerSign(letter.Transliteration());
                    GlyphPreviewCombo.Items.Add(name);
                }
            }

            GlyphPreviewCombo.SelectedIndex = 0;
            textBox1.Text = ExampleTexts[0];
            UpdateAll();
        }

        public void UpdateAll()
        {
            UpdateLibraryCombo();
            UpdateGlyphLibrary();
        }

        private void LibraryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGlyphLibrary();
        }

        private void UpdateGlyphLibrary()
        {
            RefCombo.Items.Clear();
            switch (LibraryCombo.SelectedIndex)
            {
                default:
                case 0: // default
                {
                    glyphLibrary = GlyphLibrary.Default;
                    break;
                }

                case 1: // project base
                {
                    Project project = Program.GetProject();
                    if (project == null)
                    {
                        glyphLibrary = GlyphLibrary.Default;
                    }
                    else
                    {
                        glyphLibrary = project.BaseGlyphLibrary;
                    }
                    break;
                }

                case 2: // project
                {
                    Project project = Program.GetProject();
                    if (project == null)
                    {
                        glyphLibrary = GlyphLibrary.Default;
                    }
                    else
                    {
                        glyphLibrary = project.FinalGlyphLibrary;
                    }
                    break;
                }

                case 3: // custom
                {
                    GlyphLibrary fileLibrary = CustomGlyphLibrary.CreateFromFile(lastLibraryPath);
                    if(fileLibrary != null)
                    {
                        glyphLibrary = fileLibrary;
                    }
                    break;
                }
            }

            // update references
            CustomGlyphLibrary c = glyphLibrary as CustomGlyphLibrary;
            if (c != null)
            {
                int count = c.GetReferenceCount();
                for(int i = 0; i < count; ++i)
                {
                    CustomGlyphLibrary referencedLibrary = c.GetReference(i);
                    RefCombo.Items.Add(referencedLibrary.GetPath());
                }
            }

            button1.Enabled = button2.Enabled = button3.Enabled = !glyphLibrary.IsReadOnly();
            //button6.Enabled = LibraryCombo.SelectedIndex == 3;
            UpdateOverrides();
            UpdatePreviewString();
            UpdatePreview();
        }

        private void UpdateLibraryCombo()
        {
            //int oldSelection = LibraryCombo.SelectedIndex;

            LibraryCombo.Items[3] = "Custom Library ("
                + ((lastLibraryPath.Length > 1)
                    ? Path.GetFileName(lastLibraryPath)
                    : "default")
                + ")";
            // ...

            //LibraryCombo.SelectedIndex = Math.Max(oldSelection, LibraryCombo.Items.Count - 1);
        }

        private void UpdateOverrides()
        {
            OverrideListBox.Items.Clear();

            for(int i = 0; i < glyphLibrary.GetOverrideCount(); ++i)
            {
                ICustomGlyphSource source = glyphLibrary.GetOverride(i);
                OverrideListBox.Items.Add(
                    source.GetLetter().Transliteration()
                    + " - " + source.GetFriendlyName());
            }
        }
        private void UpdatePreview()
        {
            pictureBox1.Image = new Bitmap(
                pictureBox1.Width, pictureBox1.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            if (GlyphPreviewCombo.SelectedItem == null)
            {
                return;
            }

            Letter letter = Letters.LookupGardinerSign((string)(GlyphPreviewCombo.SelectedItem));
            if(letter != null)
            {
                glyphLibrary.DrawLetter(
                    Graphics.FromImage(pictureBox1.Image), letter,
                    0, 0, pictureBox1.Width, pictureBox1.Height);
            }
        }

        private void GlyphLibraryMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void GlyphPreviewCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        private void GlyphLibraryEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
            MainWindowMenuItem.Checked = false;
            MainWindow.HandleGlyphLibraryToggle();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            HandleOpenFile();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HandleOpenFile();
        }

        private void HandleOpenFile()
        {
            if(OpenLibraryDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            lastLibraryPath = OpenLibraryDialog.FileName;

            LibraryCombo.SelectedIndex = 3;
            UpdateAll();
        }

        private void HandleRemoveOverride()
        {
            string listItem = (string)OverrideListBox.SelectedItem;
            string[] split = listItem.Split('-');
            string letterName = split[0].Trim();
            glyphLibrary.RemoveOverride(letterName);

            UpdateOverrides();
            UpdatePreview();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if((lastLibraryPath == "") || (LibraryCombo.SelectedIndex != 3))
            {
                // save as...
                if (SaveLibraryDialog.ShowDialog() == DialogResult.OK)
                {
                    lastLibraryPath = SaveLibraryDialog.FileName;
                }
            }

            glyphLibrary.Save(lastLibraryPath);
        }

        private void OverrideListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string listItem = (string)OverrideListBox.SelectedItem;
            string[] split = listItem.Split('-');
            string letterName = split[0].Trim();
            for(int i = 0; i < GlyphPreviewCombo.Items.Count; ++i)
            {
                if(letterName == (string)(GlyphPreviewCombo.Items[i]))
                {
                    GlyphPreviewCombo.SelectedIndex = i;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HandleRemoveOverride();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (OpenImageDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            PNGGlyphOverride image = new PNGGlyphOverride();
            string[] data = new string[2]
                {
                    (string)(GlyphPreviewCombo.SelectedItem),
                    OpenImageDialog.FileName
                };
            image.FromData(data);
            CustomGlyphLibrary cl = glyphLibrary as CustomGlyphLibrary;
            if (cl != null)
            {
                cl.AddOrUpdateOverride(image.GetLetter(), image);
            }

            UpdateOverrides();
            UpdatePreview();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Add new reference
            if(OpenLibraryDialog.ShowDialog() == DialogResult.OK)
            {
                 // 
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // remove current reference
            if (RefCombo.SelectedIndex >= 0)
            {
                //RefCombo.Items.RemoveAt(RefCombo.SelectedIndex);
            }
        }

        private void useCurrentLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Project project = Program.GetProject();
            if (project == null)
            {
                MessageBox.Show("No project loaded!", Program.Name, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to use this library?",
                Program.Name,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                project.ReplaceBaseGlyphLibrary(glyphLibrary);
            }
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlyphLibraryReport.ShowReportDialog(glyphLibrary);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdatePreviewString();
        }

        private void UpdatePreviewString()
        {
            TestOutput.Image = new Bitmap(
                TestOutput.Width * 4, TestOutput.Height * 4, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            if (textBox1.Text != "")
            {
                HieroglyphicWordImage.DrawWordSimple(
                    Graphics.FromImage(TestOutput.Image), Word.FromMdC(textBox1.Text), 256, glyphLibrary);
            }
        }

        private void TestOutput_SizeChanged(object sender, EventArgs e)
        {
            UpdatePreviewString();
        }

        private void RefCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void generateLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlyphLibraryGenerator newGenerator = new GlyphLibraryGenerator();
            newGenerator.ShowDialog();
        }
    }
}
