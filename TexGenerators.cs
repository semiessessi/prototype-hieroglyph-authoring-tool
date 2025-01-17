using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PP1
{
    public partial class TexGenerators : Form
    {
        public TexGenerators()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerateUniliteralTable();
        }

        private void GenerateUniliteralTable()
        {
            string[] baseList = isSemetic.Checked ? mdcSemetic : mdcAlphabetic;
            string top = "\\begin{center}\r\n\\begin{tabularx}{\\linewidth}{YYYY}\r\n"
                + "Hieroglyph & MdC+ & Transliteration & Gardiner code\\\\\r\n\\hline\\\\\r\n";
            string bottom = "\\end{tabularx}\r\n\\end{center}\r\n";
            string outputText = top;
            int count = 0;
            int batchSize = (int)numericUpDown1.Value;
            string prefix = textBox1.Text;
            foreach(string mdc in baseList)
            {
                string gardiner = Letters.MdCToGardinerSign(mdc);
                string file = gardiner.Replace("AA", "J");
                gardiner = Letters.CanonicaliseGardinerSign(gardiner);
                
                float size = 0.5f;
                if(sizeOverrides.ContainsKey(gardiner))
                {
                    size = sizeOverrides[gardiner];
                }
                string sizeString = size.ToString("0.00");

                bool pad = paddingLookup.ContainsKey(gardiner);
                float padAmount = 0.0f;
                if(pad)
                {
                    padAmount = paddingLookup[gardiner];
                }

                if(pad)
                {
                    outputText += "\\vspace{" + padAmount.ToString("0.00000") + "cm} ";
                }

                outputText += "\\includegraphics[width="
                    + sizeString + "\\linewidth,height="
                    + sizeString + "\\linewidth,keepaspectratio]{"
                    + prefix + file + "}";

                if(pad)
                {
                    outputText += " \\vspace{" + padAmount.ToString("0.00000") + "cm}";
                }

                outputText += " & ";
                outputText += mdc;
                outputText += " & ";
                outputText += Letters.ConvertToTransliterationSymbols(mdc);
                outputText += " & ";
                outputText += gardiner;
                outputText += " \\\\ ";
                outputText += "\r\n";
                ++count;
                if(count >= batchSize)
                {
                    outputText += bottom;
                    outputText += "\r\n\r\n";
                    outputText += top;
                    count = 0;
                }
            }

            outputText += bottom;

            output.Text = outputText;
        }

        Dictionary<string, float> sizeOverrides = new Dictionary<string, float>()
        {
            { "Z4", 0.25f },
            { "Q3", 0.25f },
            { "X1", 0.25f },
            { "Aa1", 0.25f },
            { "N29", 0.3f },
            { "W11", 0.35f },
            { "V33", 0.35f },
            { "O4", 0.35f },
            { "V1", 0.4f },
        };

        Dictionary<string, float> paddingLookup = new Dictionary<string, float>()
        {
            { "D36", 0.3f },
            { "I9", 0.175f },
            { "D46", 0.125f },
            { "V31", 0.3f },
            { "E23", 0.3f },
            { "N35", 0.5f },
            { "D21", 0.3f },
            { "X1", 0.25f },
            { "V13", 0.375f },
            { "F32", 0.325f },
            { "O34", 0.325f },
            { "Aa15", 0.325f },
        };

        string[] mdcSemetic =
        {
            "A",
            "i",
            "y",
            "Y",
            "a",
            "w",
            "W",
            "b",
            "p",
            "f",
            "m",
            "M",
            "n",
            "N",
            "r",
            "l",
            "h",
            "H",
            "x",
            "X",
            "z",
            "s",
            "S",
            "q",
            "k",
            //"K",
            "g",
            "G",
            "t",
            "T",
            "d",
            "D",
        };

        string[] mdcAlphabetic =
        {
            "A",
            "a",
            "b",
            "d",
            "D",
            "f",
            "g",
            "G",
            "h",
            "H",
            "i",
            "k",
            //"K",
            "l",
            "m",
            "M",
            "n",
            "N",
            "p",
            "q",
            "r",
            "s",
            "S",
            "t",
            "T",
            "w",
            "W",
            "x",
            "X",
            "y",
            "Y",
            "z",
        };
    }
}
