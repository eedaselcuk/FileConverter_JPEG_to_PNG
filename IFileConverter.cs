using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileConverter
{
    public  interface IFileConverter
    {
        string InputFileFormat { get; }

        string OutputFileFormat { get; }

        object Convert(object input);
    }
}