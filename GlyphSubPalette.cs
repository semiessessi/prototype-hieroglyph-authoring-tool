using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PP1
{
    public partial class GlyphSubPalette : Form
    {
        public GlyphSubPalette(string prefix)
        {
            Cursor.Current = Cursors.WaitCursor;
            
            signPrefix = prefix;

            InitializeComponent();

            ICollection<Letter> letters = Letters.GetAllGardinerSigns();
            if (prefix == "A")
            {
                foreach (Letter letter in letters)
                {
                    string name = Letters.CanonicaliseGardinerSign(letter.Transliteration());
                    if ((name.Length > 1)
                        && (name[0] == 'A')
                        && (name[1] != 'a'))
                    {
                        signs.Add(name);
                    }
                }
            }
            else if (prefix == "N")
            {
                foreach (Letter letter in letters)
                {
                    string name = Letters.CanonicaliseGardinerSign(letter.Transliteration());
                    if ((name.Length > 1)
                        && (name[0] == 'N')
                        && (name[1] != 'U')
                        && (name[1] != 'L'))
                    {
                        signs.Add(name);
                    }
                }
            }
            else if (prefix == "NX")
            {
                foreach (Letter letter in letters)
                {
                    string name = Letters.CanonicaliseGardinerSign(letter.Transliteration());
                    if ((name.Length > 1)
                        && (name[0] == 'N')
                        && ((name[1] == 'U')
                            || (name[1] == 'L')))
                    {
                        signs.Add(name);
                    }
                }
            }
            else
            {
                foreach (Letter letter in letters)
                {
                    string name = Letters.CanonicaliseGardinerSign(letter.Transliteration());
                    if (name.StartsWith(prefix))
                    {
                        signs.Add(name);
                    }
                }
            }

            // create buttons?
            const int buttonWidth = 48;
            const int buttonHeight = 48;
            const int gap = 8;
            int rowLength = Math.Min(9, signs.Count);
            int buttonX = 0;
            int posY = gap;
            Font fontCache = null;
            foreach (string sign in signs)
            {
                Letter letter = Letter.FromGardinerSign(sign);
                Button newButton = new Button();
                newButton.Left = gap + buttonX * (buttonWidth + gap);
                newButton.Top = posY;
                newButton.Width = buttonWidth;
                newButton.Height = buttonHeight;
                newButton.Text = letter.IsolatedForm();
                newButton.Tag = sign;
                newButton.Click += new System.EventHandler(Button_Click);
                if(fontCache == null)
                {
                    fontCache = new Font(newButton.Font.FontFamily, buttonHeight / 2 - 2);
                }
                newButton.Font = fontCache;
                newButton.FlatStyle = FlatStyle.Flat;
                newButton.FlatAppearance.BorderSize = 0;

                // does this sign have an image?
                Project project = Program.GetProject();
                if (project != null && (project.FinalGlyphLibrary != null))
                {
                    bool square = false;
                    CustomGlyphLibrary library = project.FinalGlyphLibrary as CustomGlyphLibrary;
                    ICustomGlyphSource glyph = library.GetOverrideForLetter(letter, out square);
                    if(glyph is PNGGlyphOverride)
                    {
                        PNGGlyphOverride pngGlyph = glyph as PNGGlyphOverride;
                        newButton.BackgroundImage = pngGlyph.GetImage();
                        newButton.BackgroundImageLayout = ImageLayout.Zoom;
                        newButton.Text = "";
                    }
                }

                buttons.Add(newButton);
                Controls.Add(newButton);

                ++buttonX;
                if (buttonX > rowLength)
                {
                    buttonX = 0;
                    posY += buttonHeight + gap;
                }
            }

            Width = rowLength * (buttonWidth + gap) + gap;
            Height = posY + buttonHeight + gap;

            Cursor.Current = Cursors.Default;
        }

        private List<Button> buttons = new List<Button>();
        private List<string> signs = new List<string>();

        private string signPrefix = "";

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void GlyphSubPalette_Load(object sender, EventArgs e)
        {

        }

        private void GlyphSubPalette_Leave(object sender, EventArgs e)
        {

        }

        private void GlyphSubPalette_Deactivate(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
