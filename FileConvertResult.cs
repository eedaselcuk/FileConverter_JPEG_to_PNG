using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileConverter
{
    public class FileConvertResult
    {
        public Image Image { get; set; }
        public byte[] ImageByte { get; set; }
        public bool Error { get; set; }
        public string Message { get; set; }
    }
}
