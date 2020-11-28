using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileConverter
{
    public static class FileConversionManager
    {
        // 'Drawing' library is used to convert from one type to another.

        public static FileConvertResult Convert(object input, string inputFileFormat, string outputFileFormat)
        {
            FileConvertResult result = new FileConvertResult();
            string newFile = Path.GetFileNameWithoutExtension(inputFileFormat);
            newFile = newFile + ".png";
            Image img = (Image)input;
            MemoryStream memory = new MemoryStream();
            try
            {
                img.Save(newFile, ImageFormat.Png);
                img.Save(memory, ImageFormat.Png);
                result.ImageByte = memory.ToArray();  
                result.Error = false;
                result.Message = "Converted successfully!";
            }
            catch
            {
                result.Error = true;
                result.Message = "Not successful!";
            }
            result.Image = img;
            return result;
        }
    }
}
