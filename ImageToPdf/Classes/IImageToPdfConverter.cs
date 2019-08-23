using System;
using System.Collections.Generic;
using System.Text;

namespace ImageToPdf.Classes
{
    public interface IImageToPdfConverter
    {
        void ConvertToPdf(string imageFilePath, string pdfFilePath);
    }
}
