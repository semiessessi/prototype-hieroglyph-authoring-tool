using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PP1
{
    public partial class GlyphLibraryReport : Form
    {
        public GlyphLibraryReport()
        {
            InitializeComponent();
        }

        public static void ShowReportDialog(GlyphLibrary library)
        {
            GlyphLibraryReport report = new GlyphLibraryReport();

            report.GlyphCount.Text =
                Letters.GetAllGardinerSigns().Count.ToString();

            CustomGlyphLibrary c = library as CustomGlyphLibrary;
            if(c != null)
            {
                report.OverrideCount.Text =
                    c.GetTotalOverrideCount().ToString();
                report.DirectOverrideCount.Text =
                    c.GetOverrideCount().ToString();
            }

            report.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
