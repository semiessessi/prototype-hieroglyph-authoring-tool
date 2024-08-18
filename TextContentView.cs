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
    public partial class TextContentView : UserControl
    {
        public TextContent ProjectContent = null;
        public TabPage Page = null;

        public TextContentView()
        {
            InitializeComponent();
        }

        private void DocumentText_TextChanged(object sender, EventArgs e)
        {
            Text text = ProjectContent.GetText();
            if (text == null)
            {
                return;
            }

            if (text.GetSourceString() != DocumentText.Text)
            {
                text.UpdateSourceString(DocumentText.Text);

                ProjectContent.MarkDirty();
                UpdateTabTitle();
                UpdateSections();
                UpdatePreview();
            }
        }

        private void TextContentView_Load(object sender, EventArgs e)
        {
            StyleCombo.SelectedIndex = 0;
            ZoomBar.Value = 50;
        }

        public void LoadFromContent()
        {
            Properties.Settings settings = Properties.Settings.Default;
            zoom = settings.LastTextPreviewZoom;
            Text text = ProjectContent.GetText();
            if (text == null)
            {
                return;
            }

            DocumentText.Text = text.GetSourceString();
            UpdateSections();
            SectionCombo.SelectedIndex = 0; // updates preview.
        }

        private void UpdateTabTitle()
        {
            if (ProjectContent != null)
            {
                string path = MakeRelativePath(ProjectContent.GetPath());
                Page.Text = path + (ProjectContent.IsDirty() ? "*" : "");
            }
        }


        // TODO: duplication
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

        private void UpdatePreview()
        {
            const int scale = 1;
            if (DocumentPreview.Image != null)
            {
                DocumentPreview.Image.Dispose();
            }
            DocumentPreview.Image = new Bitmap(scale * DocumentPreview.Width, scale * DocumentPreview.Height);
            if (ProjectContent == null)
            {
                return;
            }

            Graphics graphics = Graphics.FromImage(DocumentPreview.Image);
            Text text = ProjectContent.GetText();
            if (text != null)
            {
                text.UpdatePreviewLayout(StyleCombo.SelectedIndex, zoom);
            }
            if (SectionCombo.SelectedIndex <= 0)
            {
                text.DrawPreview(
                    graphics, 
                    0, 0,
                    DocumentPreview.Width * scale,
                    DocumentPreview.Height * scale);
            }
            else
            {
                string sectionName = (string)SectionCombo.Items[SectionCombo.SelectedIndex];
                text.DrawSectionPreview(
                    graphics, sectionName,
                    0, 0,
                    DocumentPreview.Width * scale,
                    DocumentPreview.Height * scale);
            }
        }

        private void UpdateSections()
        {
            int oldIndex = SectionCombo.SelectedIndex;
            SectionCombo.Items.Clear();
            SectionCombo.Items.Add("All");
            foreach (string section in ProjectContent.GetSectionNames())
            {
                SectionCombo.Items.Add(section);
            }

            // TODO: recover the correct section, not the index.
            if(oldIndex >= SectionCombo.Items.Count)
            {
                SectionCombo.SelectedIndex = 0;
            }
            else
            {
                SectionCombo.SelectedIndex = oldIndex;
            }
        }

        private void StyleCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        private void ZoomBar_Scroll(object sender, EventArgs e)
        {
            float maxScaleKey = 8.0f;
            float minScaleKey = 4.0f;
            float key = (float)(ZoomBar.Value - 50) / 50.0f;
            if(key >= 0.0f)
            {
                zoom = 1.0f + (maxScaleKey - 1.0f) * key;
            }
            else
            {
                zoom = 1.0f + key * (1.0f - 1.0f / minScaleKey);
            }
            ZoomReadout.Text = ((int)(zoom * 100)).ToString() + "%";

            Properties.Settings settings = Properties.Settings.Default;
            settings.LastTextPreviewZoom = zoom;
            settings.Save();
            UpdatePreview();
        }

        private void ResetZoom_Click(object sender, EventArgs e)
        {
            ZoomBar.Value = 50;
            zoom = 1.0f;
            ZoomReadout.Text = ((int)(zoom * 100)).ToString() + "%";
            Properties.Settings settings = Properties.Settings.Default;
            settings.LastTextPreviewZoom = zoom;
            settings.Save();
            UpdatePreview();
        }

        private float zoom = 1.0f;

        private void button1_Click(object sender, EventArgs e)
        {
            if(SaveImageDialog.ShowDialog() == DialogResult.OK)
            {
                DocumentPreview.Image.Save(SaveImageDialog.FileName);
            }
        }

        private void SectionCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // TODO: better
            Clipboard.SetDataObject(DocumentPreview.Image);
        }
    }
}
