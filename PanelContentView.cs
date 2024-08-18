using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PP1
{
    public partial class PanelContentView : UserControl
    {
        public PanelContent ProjectContent = null;
        public TabPage Page = null;

        public PanelContentView()
        {
            InitializeComponent();
        }

        private void PanelContentView_Load(object sender, EventArgs e)
        {

        }

        public void LoadFromContent()
        {
            Properties.Settings settings = Properties.Settings.Default;
            Panel panel = ProjectContent.GetPanel();
            if (panel == null)
            {
                return;
            }

            UpdateHierarchy();
            UpdateNodeProperties();
            UpdatePreview();
        }

        private void UpdateHierarchy()
        {
            Panel panel = ProjectContent.GetPanel();
            if (panel == null)
            {
                return;
            }

            Hierarchy.Nodes.Clear();

            string name = panel.GetDisplayName();
            TreeNode parent = Hierarchy.Nodes.Add(name);
            AddPanelNodes(parent, panel);
        }

        private void AddPanelNodes(TreeNode parent, Panel panel)
        {
            IList<Panel> children = panel.GetChildren();
            parent.Tag = panel;
            foreach(Panel childPanel in children)
            {
                TreeNode newParent = parent.Nodes.Add(childPanel.GetDisplayName());
                AddPanelNodes(newParent, childPanel);
            }
        }

        private void UpdatePreview()
        {
            Panel panel = ProjectContent.GetPanel();
            if (panel == null)
            {
                return;
            }

            if(Preview.Image != null)
            {
                Preview.Image.Dispose();
            }

            Preview.Image = new Bitmap(Preview.Width, Preview.Height);
            panel.Draw(Graphics.FromImage(Preview.Image), 0, 0, Preview.Width, Preview.Height);
        }

        private void UpdateNodeProperties()
        {
            bool hasNode = Hierarchy.SelectedNode != null;
            TypeCombo.Enabled = hasNode;
            DirectionCombo.Enabled = hasNode;
            BackgroundColourCombo.Enabled = hasNode;
            DuplicateNodeButton.Enabled = hasNode;
            RemoveNodeButton.Enabled = hasNode;
            if (hasNode == false)
            {
                TypeCombo.SelectedIndex = -1;
                DirectionCombo.SelectedIndex = -1;
                BackgroundColourCombo.Color = Color.Transparent;
                return;
            }

            Panel panel = Hierarchy.SelectedNode.Tag as Panel;

            BackgroundColourCombo.Color = panel.GetBackgroundColour();

            if (panel is TextPanel)
            {
                TextPanel textPanel = panel as TextPanel;
                TypeCombo.SelectedIndex = 1;
                SetDirectionComboText(textPanel.TextLayout);
            }
            //else if(panel is Panel)
            else
            {
                TypeCombo.SelectedIndex = 0;
                SetDirectionComboPanel(panel.GetDirection());
            }
        }
        
        private void SetDirectionComboText(Text.Layout layout)
        {
            DirectionCombo.Items.Clear();
            DirectionCombo.Items.Add("Vertical Left-to-Right");
            DirectionCombo.Items.Add("Vertical Right-to-Left");
            DirectionCombo.Items.Add("Left-to-Right");
            DirectionCombo.Items.Add("Right-to-Left");
            DirectionCombo.Items.Add("Mirrored");
            DirectionCombo.Items.Add("Transliteration");
            DirectionCombo.Items.Add("Interlinear");
            switch(layout)
            {
                default:
                {
                    DirectionCombo.SelectedIndex = -1;
                    break;
                }
                case PP1.Text.Layout.VerticalLeftToRight:
                {
                    DirectionCombo.SelectedIndex = 0;
                    break;
                }
                case PP1.Text.Layout.VerticalRightToLeft:
                {
                    DirectionCombo.SelectedIndex = 1;
                    break;
                }
                case PP1.Text.Layout.LeftToRight:
                {
                    DirectionCombo.SelectedIndex = 2;
                    break;
                }
                case PP1.Text.Layout.RightToLeft:
                {
                    DirectionCombo.SelectedIndex = 3;
                    break;
                }
                case PP1.Text.Layout.Mirrored:
                {
                    DirectionCombo.SelectedIndex = 4;
                    break;
                }
                case PP1.Text.Layout.Transliteration:
                {
                    DirectionCombo.SelectedIndex = 5;
                    break;
                }
                case PP1.Text.Layout.Interlinear:
                {
                    DirectionCombo.SelectedIndex = 6;
                    break;
                }
            }
        }

        private void SetDirectionComboPanel(Panel.Layout layout)
        {
            DirectionCombo.Items.Clear();
            DirectionCombo.Items.Add("Vertical");
            DirectionCombo.Items.Add("Left-to-Right");
            DirectionCombo.Items.Add("Right-to-Left");
            DirectionCombo.Items.Add("Mirrored");
            switch(layout)
            {
                default:
                case Panel.Layout.None:
                {
                    DirectionCombo.SelectedIndex = -1;
                    break;
                }
                case Panel.Layout.Vertical:
                {
                    DirectionCombo.SelectedIndex = 0;
                    break;
                }
                case Panel.Layout.HorizontalLeftToRight:
                {
                    DirectionCombo.SelectedIndex = 1;
                    break;
                }
                case Panel.Layout.HorizontalRightToLeft:
                {
                    DirectionCombo.SelectedIndex = 2;
                    break;
                }
                case Panel.Layout.Mirrored:
                {
                    DirectionCombo.SelectedIndex = 3;
                    break;
                }
            }
        }

        private void Hierarchy_AfterSelect(object sender, TreeViewEventArgs e)
        {
            UpdateNodeProperties();
        }

        private void BackgroundColorCombo_ColorChanged(object sender, EventArgs e)
        {
            bool hasNode = Hierarchy.SelectedNode != null;
            if(hasNode == false)
            {
                return;
            }

            Panel panel = Hierarchy.SelectedNode.Tag as Panel;
            panel.SetBackgroundColour(BackgroundColourCombo.Color);

            UpdatePreview();
        }

        private void DirectionCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool hasNode = Hierarchy.SelectedNode != null;
            if (hasNode == false)
            {
                return;
            }

            Panel panel = Hierarchy.SelectedNode.Tag as Panel;
            if(panel is TextPanel)
            {
                TextPanel textPanel = panel as TextPanel;
                switch (DirectionCombo.SelectedIndex)
                {
                    default:
                    case -1:
                    {
                        // do nothing. TODO: ?
                        break;
                    }
                    case 0:
                    {
                        textPanel.TextLayout = PP1.Text.Layout.VerticalLeftToRight;
                        break;
                    }
                    case 1:
                    {
                        textPanel.TextLayout = PP1.Text.Layout.VerticalRightToLeft;
                        break;
                    }
                    case 2:
                    {
                        textPanel.TextLayout = PP1.Text.Layout.LeftToRight;
                        break;
                    }
                    case 3:
                    {
                        textPanel.TextLayout = PP1.Text.Layout.RightToLeft;
                        break;
                    }
                    case 4:
                    {
                        textPanel.TextLayout = PP1.Text.Layout.Mirrored;
                        break;
                    }
                    case 5:
                    {
                        textPanel.TextLayout = PP1.Text.Layout.Transliteration;
                        break;
                    }
                    case 6:
                    {
                        textPanel.TextLayout = PP1.Text.Layout.Interlinear;
                        break;
                    }
                }
                UpdatePreview();
                return;
            }
            switch(DirectionCombo.SelectedIndex)
            {
                default:
                case -1:
                {
                    // do nothing. TODO: ?
                    break;
                }
                case 0:
                {
                    panel.SetDirection(Panel.Layout.Vertical);
                    break;
                }
                case 1:
                {
                    panel.SetDirection(Panel.Layout.HorizontalLeftToRight);
                    break;
                }
                case 2:
                {
                    panel.SetDirection(Panel.Layout.HorizontalRightToLeft);
                    break;
                }
                case 3:
                {
                    panel.SetDirection(Panel.Layout.Mirrored);
                    break;
                }
            }
            //panel.SetDirection()

            UpdatePreview();
        }
    }
}
