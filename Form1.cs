using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

        }
        static byte[] imgByte;
        private void btnConvert_Click(object sender, EventArgs e)
        {
            string FileName = openFileDialog1.FileName;
            Image img = Image.FromFile(FileName);
            FileConvertResult _result = FileConversionManager.Convert(img, FileName, "PNG");
            pcImg.Image = _result.Image;
            imgByte = _result.ImageByte;
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            lblFilePath.Text = openFileDialog1.FileName;
        }
        private void btnDown_Click(object sender, EventArgs e)
        {
            string savePath = @"C:\Users\eedas\Downloads\Image1.png";
            File.WriteAllBytes(savePath, imgByte);
            MessageBox.Show("Resminiz Başarıyla İndirildi");
        }
    }
}