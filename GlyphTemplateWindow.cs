using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PP1
{
    public partial class GlyphTemplateWindow : Form
    {
        public GlyphTemplateWindow()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                resultLabel.Text = "(no result)";
                return;
            }

            resultLabel.Text = GetUnicode(textBox1.Text);

            RefreshImage();
        }

        private void RefreshImage()
        {
            pictureBox1.Image = new Bitmap(2048, 2048, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Graphics graphics = Graphics.FromImage(pictureBox1.Image);

            // TODO: use better layout description to pack stuff together etc.
            pictureBox1.Image = GenerateTightImage(resultLabel.Text);
        }

        private static string GetUnicode(string input)
        {
            string result = "";

            // split by spaces.
            string[] glyphs = input.Split(' ');
            foreach (string substring in glyphs)
            {
                string gardniner = Letters.MdCToGardinerSign(substring);
                Letter letter = Letters.LookupGardinerSign(gardniner);
                if (letter != null)
                {
                    result += letter.IsolatedForm();
                }
                else
                {
                    result += "?";
                }
            }

            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = textBox1.Text + ".png";
            save.Filter = "PNG Image (*.png)|*.png|All Files (*.*)|*.*";
            save.Title = "Save Glyph Template...";
            if(save.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(save.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog save = new FolderBrowserDialog();
            save.Description = "Select location to save all possible glyph templates...";
            save.UseDescriptionForTitle = true;
            if (save.ShowDialog() == DialogResult.OK)
            {
                string basePath = save.SelectedPath;
                ICollection<Letter> letters = Letters.GetAllGardinerSigns();
                foreach(Letter letter in letters)
                {
                    Image image = GenerateTightImage(letter.IsolatedForm());
                    if (letter.Transliteration() != "?")
                    {
                        image.Save(Path.Combine(basePath, letter.Transliteration() + ".png"));
                    }
                }
            }
        }

        private const TextFormatFlags ListFormatFlags =
            TextFormatFlags.NoPadding
            | TextFormatFlags.WordBreak
            | TextFormatFlags.Top
            | TextFormatFlags.Left;
        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(4096, 4096, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "test_all_glyphs.png";
            save.Filter = "PNG Image (*.png)|*.png|All Files (*.*)|*.*";
            save.Title = "Save Glyph Template...";
            if (save.ShowDialog() == DialogResult.OK)
            {
                Graphics graphics = Graphics.FromImage(pictureBox1.Image);
                graphics.Clear(Color.Transparent);
                ICollection<Letter> letters = Letters.GetAllGardinerSigns();
                string output = "";
                string first = "A";
                foreach (Letter letter in letters)
                {
                    string translit = letter.Transliteration();
                    if((translit.Length > 1) && (translit.Substring(0, 1) != first))
                    {
                        output += "\n";
                        first = translit.Substring(0, 1);
                    }

                    output += translit;
                    output += "";
                    output += letter.InitialForm();
                    output += " ";
                }

                Font font = new Font(HieroglyphicWordImage.GetBaseFont().Name, 32);
                TextRenderer.DrawText(
                    graphics, output, font,
                    new Rectangle(new Point(1,1), new Size(4094,4094)),
                    Color.Black, ListFormatFlags);

                pictureBox1.Image.Save(save.FileName);
            }
        }

        private const TextFormatFlags TightFormatFlags =
            TextFormatFlags.NoPadding
            | TextFormatFlags.NoClipping
            | TextFormatFlags.SingleLine
            | TextFormatFlags.Top
            | TextFormatFlags.Left;

        private Image GenerateTightImage(string unicode, int maxDimension = 2048)
        {
            Image image = new Bitmap(maxDimension, maxDimension, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            if (unicode == "")
            {
                return image;
            }

            int maxBounds = maxDimension - 2;

            // find font size to fill it as much as possible.
            // guess range to search by doubling size at first...
            Font originalFont = HieroglyphicWordImage.GetBaseFont();
            int finalSize = 64;
/*
            int testSize = 64;
            int finalMax = -1;
            int testWidth = -1;
            int testHeight = -1;
            while ((testWidth < maxDimension) && (testHeight < maxDimension))
            {
                finalSize = testSize;
                finalMax = Math.Max(testWidth, testHeight);
                testSize *= 2;
                Font testFont = new Font(originalFont.Name, testSize);
                Size size = TextRenderer.MeasureText(
                    unicode, testFont, new Size(maxBounds, maxBounds), TightFormatFlags);
                testWidth = size.Width;
                testHeight = size.Height;

                if((size.Height == 0)
                    || (size.Width == 0))
                {
                    // TODO: something better than just going NOPE!!!
                    return image;
                }
            }

            // refine with binary search on both dimensions
            finalSize = BinarySearchFontSize(unicode, originalFont, testSize >> 1, testSize << 1, maxBounds);
*/
            // refine the result further
            finalSize = CalculateFontSize(originalFont, maxBounds);
            int sizeDifference = finalSize - maxBounds;
            
            Font finalFont = new Font(originalFont.Name, finalSize);
            Graphics graphics = Graphics.FromImage(image);
            TextRenderer.DrawText(
                graphics, unicode, finalFont, new Point(0, sizeDifference), Color.Black, TightFormatFlags);

            return image;
        }

        private int CalculateFontSize(Font originalFont, int targetSize)
        {
            FontFamily family = originalFont.FontFamily;
            int descent = family.GetCellDescent(originalFont.Style);
            int emHeight = family.GetEmHeight(originalFont.Style);
            float desiredHeightRatio = (float)emHeight / (emHeight - descent);
            return (int)(targetSize * desiredHeightRatio * 0.5f);
        }

        private int BinarySearchFontSize(
            string unicode, Font originalFont,
            int startSize, int endSize, int maxBounds)
        {
            if(endSize == startSize + 1)
            {
                return startSize;
            }

            int testSize = startSize + ((endSize - startSize) >> 1);
            Font testFont = new Font(originalFont.Name, testSize);
            Size size = TextRenderer.MeasureText(
                unicode, testFont, new Size(maxBounds, maxBounds), TightFormatFlags);

            int testMax = Math.Max(size.Width, size.Height);

            if(testMax > maxBounds)
            {
                return BinarySearchFontSize(unicode, originalFont, startSize, testSize, maxBounds);
            }

            return BinarySearchFontSize(unicode, originalFont, testSize, endSize, maxBounds);
        }
    }
}
