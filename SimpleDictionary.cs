using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PP1
{
    public partial class SimpleDictionary : Form
    {
        public SimpleDictionary()
        {
            InitializeComponent();

            UpdateListBox();
        }

        private void UpdateListBox()
        {
            SearchListBox.Items.Clear();
            currentTranslationList.Clear();
            if (SearchEntry.Text.Length == 0)
            {
                foreach(Translation wordTranslation in LanguageDictionary.GetEnglishWords())
                {
                    currentTranslationList.Add(wordTranslation);
                    Word word = wordTranslation.GetOriginal();
                    SearchListBox.Items.Add(word.ToSimpleUnicode());
                }

                return;
            }

            foreach (Translation wordTranslation in LanguageDictionary.GetEnglishWords())
            {
                Word word = wordTranslation.GetOriginal();
                string unicode = word.ToSimpleUnicode();
                if (unicode.Contains(SearchEntry.Text))
                {
                    currentTranslationList.Add(wordTranslation);
                    SearchListBox.Items.Add(word.ToSimpleUnicode());
                }
            }
        }

        private void SearchEntry_TextChanged(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        private void SearchListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SearchListBox.SelectedIndex >= 0)
            {
                Translation translation = currentTranslationList[SearchListBox.SelectedIndex];
                int width = pictureBox1.Width * 4;
                int height = pictureBox1.Height * 4;
                pictureBox1.Image = HieroglyphicWordImage.CreateSimple(
                    translation.GetTranslated(),
                    width, height);
                Word original = translation.GetOriginal();
                string simple = original.ToSimpleUnicode(
                    (original.GetUsage() == Word.Usage.Name)
                    || (original.GetUsage() == Word.Usage.Interjection));

                Font boldFont = new Font(HieroglyphicWordImage.GetBaseFont().Name, 64, FontStyle.Bold);
                Font smallerFont = new Font(HieroglyphicWordImage.GetBaseFont().Name, 48);
                TextRenderer.DrawText(Graphics.FromImage(pictureBox1.Image),
                    simple, smallerFont,
                    new Rectangle(new Point(0, 256), new Size(width, height)),
                    Color.Black, HieroglyphicWordImage.TightTextFormatFlags);
                TextRenderer.DrawText(Graphics.FromImage(pictureBox1.Image),
                    translation.GetTranslated().ToTransliteration(true), boldFont,
                    new Rectangle(new Point(0, 384), new Size(width, height)),
                    Color.Black, HieroglyphicWordImage.TightTextFormatFlags);
            }
        }

        private List<Translation> currentTranslationList = new List<Translation>();
    }
}
