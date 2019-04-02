using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using MaterialSkin;
using MaterialSkin.Controls;

namespace EX_BootLogo
{
    public partial class Load_Image_Form : MaterialForm
    {
        public Load_Image_Form()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange100, Primary.Orange300, Primary.Orange800, Accent.DeepOrange700, TextShade.BLACK);
        }
       
        Bitmap Creat_BootLogo(bool rotate, string input)
        {
            rotate = false;
            Bitmap ImageInput = new Bitmap(input);
            Bitmap ImageOutput = new Bitmap(ImageInput.Width, ImageInput.Height, PixelFormat.Format32bppArgb);
            Graphics ImageHandle = Graphics.FromImage(ImageOutput);
            ImageHandle.DrawImage(ImageInput, new Rectangle(0, 0, ImageOutput.Width, ImageOutput.Height));
            ImageHandle.Dispose();
            if (rotate)
            {
                ImageOutput.RotateFlip(RotateFlipType.Rotate180FlipNone);
            }
            return ImageOutput;
        }

        private void LoadImageButton_Click(object sender, EventArgs e)
        {
            LoadImageDilaog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (LoadImageDilaog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Bitmap Image_var = new Bitmap(LoadImageDilaog.FileName);
                    HeightLabel.Text = "Height: ";
                    WidthLabel.Text = "Width: ";
                    HeightLabel.Text = HeightLabel.Text + Convert.ToString(Image_var.Height);
                    WidthLabel.Text = WidthLabel.Text + Convert.ToString(Image_var.Width);
                    LoadedImageBox.ImageLocation = LoadImageDilaog.FileName;
                    LoadedImageBox.SizeMode = PictureBoxSizeMode.CenterImage;
                    LoadedImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    MessageBox.Show("Image Loaded :)", "OK !", MessageBoxButtons.OK);
                }
                catch (Exception)
                {
                    MessageBox.Show("Cant Load Image :(\nTry again!", "Ohh !", MessageBoxButtons.OK);
                    return;
                }
               
            }
        }

        private void Load_Image_Form_Load(object sender, EventArgs e)
        {
            LoadedImageBox.SizeMode = PictureBoxSizeMode.CenterImage;
            //LoadedImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            IconBox.SizeMode = PictureBoxSizeMode.CenterImage;
            //IconBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void SaveBootLogoButton_Click(object sender, EventArgs e)
        {
            SaveBootLogoDialog.Filter = "Hekate/Atmosphere bootlogo|*.BMP";
            SaveBootLogoDialog.FileName = "bootlogo.bmp";
            if (SaveBootLogoDialog.ShowDialog() == DialogResult.OK)
            {
                bool rotate = true;
                try
                {
                    Creat_BootLogo(rotate, LoadImageDilaog.FileName).Save(SaveBootLogoDialog.FileName, ImageFormat.Bmp);
                    MessageBox.Show("Boot Logo Exported :)", "OK !", MessageBoxButtons.OK);
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Error Exporting Logo :(\nTry again!", "Ohh!", MessageBoxButtons.OK);
                    return;
                }
                
            }
        }
    }
}
