using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fotofilter
{
    public partial class MainWIndow : Form
    {
        Bitmap OriginalImage;
        Bitmap ModifiedImage;
        Color OriginalColor;
        Color ModifiedColor;

        public MainWIndow()
        {
            InitializeComponent();
        }

        private void brnOpen_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                //Open File
                OriginalImage = new Bitmap(openFile.FileName);
                pbImage.Image = OriginalImage;
                
                //
                //Defultbitmap.Save("minFil.png");
            }
        }

        private void FilterNr1()
        {
            for (int x = 0; x < OriginalImage.Width; x++)
            {
                for (int y = 0; y < OriginalImage.Height; y++)
                {

                    OriginalColor = OriginalImage.GetPixel(x, y);
                    ModifiedColor = Color.FromArgb(OriginalColor.G, OriginalColor.B, OriginalColor.R);

                    ModifiedImage.SetPixel(x, y, ModifiedColor);
                    //bitmap.GetPixel(x, y);
                }
            }
            pbChangedImage.Image = ModifiedImage;
        }

        private void BlackAndWhite()
        {
            ModifiedImage = (Bitmap)OriginalImage.Clone();
            for (int x = 0; x < OriginalImage.Width; x++)
            {
                for (int y = 0; y < OriginalImage.Height; y++)
                {
                    OriginalColor = OriginalImage.GetPixel(x, y);
                    int NewColor = (OriginalColor.R + OriginalColor.G + OriginalColor.B) / 3;
                    ModifiedColor = Color.FromArgb(NewColor, NewColor, NewColor);

                    ModifiedImage.SetPixel(x, y, ModifiedColor);
                }
            }
            pbChangedImage.Image = ModifiedImage;
            pbImage.Image = OriginalImage;
        }
        private void InvertColors()
        {
            ModifiedImage = (Bitmap)OriginalImage.Clone();
            for (int x = 0; x < OriginalImage.Width; x++)
            {
                for (int y = 0; y < OriginalImage.Height; y++)
                {
                    OriginalColor = OriginalImage.GetPixel(x, y);
                    ModifiedColor = Color.FromArgb(255 - OriginalColor.R, 255 - OriginalColor.G, 255 - OriginalColor.B);

                    ModifiedImage.SetPixel(x, y, ModifiedColor);
                }
            }
            pbChangedImage.Image = ModifiedImage;
            pbImage.Image = OriginalImage;
        }

        private void RedLVL()
        {
            ModifiedImage = (Bitmap)OriginalImage.Clone();
            for (int x = 0; x < OriginalImage.Width; x++)
            {
                for (int y = 0; y < OriginalImage.Height; y++)
                {
                    OriginalColor = OriginalImage.GetPixel(x, y);
                    ModifiedColor = Color.FromArgb(OriginalColor.R, 200, 200);

                    ModifiedImage.SetPixel(x, y, ModifiedColor);
                }
            }
            pbChangedImage.Image = ModifiedImage;
            pbImage.Image = OriginalImage;
        }
        private void GreenLVL()
        {
            ModifiedImage = (Bitmap) OriginalImage.Clone();
            for (int x = 0; x < OriginalImage.Width; x++)
            {
                for (int y = 0; y < OriginalImage.Height; y++)
                {
                    OriginalColor = OriginalImage.GetPixel(x, y);
                    ModifiedColor = Color.FromArgb(200, OriginalColor.G, 200);

                    ModifiedImage.SetPixel(x, y, ModifiedColor);
                }
            }
            pbChangedImage.Image = ModifiedImage;
            pbImage.Image = OriginalImage;
        }
        private void BlueLVL()
        {
            ModifiedImage = (Bitmap)OriginalImage.Clone();
            for (int x = 0; x < OriginalImage.Width; x++)
            {
                for (int y = 0; y < OriginalImage.Height; y++)
                {
                    OriginalColor = OriginalImage.GetPixel(x, y);
                    ModifiedColor = Color.FromArgb(200, 200, OriginalColor.B);

                    ModifiedImage.SetPixel(x, y, ModifiedColor);
                }
            }
            pbChangedImage.Image = ModifiedImage;
            pbImage.Image = OriginalImage;
        }

        private void avslutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void FilterNr1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilterNr1();
        }
        private void blackAndWhiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BlackAndWhite();
        }
        private void invertColorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvertColors();
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RedLVL();
        }
        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GreenLVL();
        }
        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BlueLVL();
        }
    }
}
