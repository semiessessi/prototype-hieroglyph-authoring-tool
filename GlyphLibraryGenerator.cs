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
    public partial class GlyphLibraryGenerator : Form
    {
        public GlyphLibraryGenerator()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SaveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            // try opening all the possible character images in the path...
            string output = "";
            string basePath = lastPath;
            ICollection<Letter> signs = Letters.GetAllGardinerSigns();
            foreach(Letter sign in signs)
            {
                // TODO: better than hacks.
                if (sign.Transliteration().Length > 1)
                {
                    string name = Letters.CanonicaliseGardinerSign(sign.Transliteration());
                    string png = ValidPathForGardinerSignPNG(basePath, name);
                    string svg = ValidPathForGardinerSignSVG(basePath, name);
                    if(svg != null)
                    {
                        output += "{\nSVG\n" + sign.Transliteration() + "\n" + svg + "\n}\n";
                    }
                    else if(png != null)
                    {
                        output += "{\nPNG\n" + sign.Transliteration() + "\n" + png + "\n}\n";
                    }
                }
            }

            File.WriteAllText(SaveFileDialog.FileName, output);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(ChooseFolderDialog.ShowDialog() == DialogResult.OK)
            {
                lastPath = ChooseFolderDialog.SelectedPath;
                label2.Text = lastPath;
            }
        }

        private string ValidPathForGardinerSignPNG(string basePath, string sign)
        {
            return ValidPathForGardinerSign(basePath, sign, ".png");
        }

        private string ValidPathForGardinerSignSVG(string basePath, string sign)
        {
            return ValidPathForGardinerSign(basePath, sign, ".svg");
        }

        private string ValidPathForGardinerSign(string basePath, string sign, string extension)
        {
            // the extra tests allow using J to stand in for Aa...
            string test = Path.Join(basePath, sign + extension);
            bool bAA = sign.ToUpper().StartsWith("AA");
            string secondSign = "J" + sign.Substring(2, sign.Length - 2);
            string secondTest = Path.Join(basePath, secondSign + extension);
            // TODO: validate its an svg/png/whatever?
            if (File.Exists(test))
            {
                return test;
            }

            if(bAA && File.Exists(secondTest))
            {
                return secondTest;
            }

            for (int i = 0; i < 3; ++i)
            {
                sign = ZeroExtendSign(sign);
                if (bAA)
                {
                    secondSign = ZeroExtendSign(secondSign);
                    secondTest = Path.Join(basePath, secondSign + extension);
                }
                test = Path.Join(basePath, sign + extension);
                if (File.Exists(test))
                {
                    return test;
                }

                if (bAA && File.Exists(secondTest))
                {
                    return secondTest;
                }
            }

            return null;
        }

        private string ZeroExtendSign(string sign)
        {
            int pos = 0;
            foreach(char c in sign)
            {
                if (c.IsDigit() == false)
                {
                    ++pos;
                }
                else
                {
                    break;
                }
            }
            string extended = sign.Substring(0, pos) + "0" + sign.Substring(pos, sign.Length - pos);
            return extended;
        }

        private string lastPath = ".";
    }
}
