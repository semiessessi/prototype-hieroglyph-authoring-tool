using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PP1
{
    public partial class GenericTemplateWindow : Form
    {
        private const int GridSize = 256;
        public GenericTemplateWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(SaveDialog.ShowDialog() == DialogResult.OK)
            {
                SaveGrid(
                    SaveDialog.FileName,
                    Convert.ToInt32(GridWidthSelector.Text),
                    Convert.ToInt32(GridHeightSelector.Text));
            }
        }

        private static void SaveGrid(string path, int width, int height)
        {
            Image image = new Bitmap(width * GridSize, height * GridSize, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(image);
            //g.DrawRectangle()
            Pen pen = Pens.Gray;
            for (int y = 0; y < height; ++y)
            {
                for (int x = 0; x < width; ++x)
                {
                    g.DrawRectangle(pen, new Rectangle(new Point(x * GridSize, y * GridSize), new Size(GridSize, GridSize)));
                }
            }

            image.Save(path);
        }
    }
}
