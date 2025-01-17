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
                gardiner = gardiner.Replace("AA", "Aa");
                gardiner = gardiner.Replace("17A", "17a");
                outputText += "\\includegraphics[width=0.5\\linewidth,height=0.5\\linewidth,keepaspectratio]{" + prefix + file + "}";
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
