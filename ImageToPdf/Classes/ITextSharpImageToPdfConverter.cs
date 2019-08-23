using ImageToPdfUsingITextSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImageToPdf.Classes
{
    public class ITextSharpImageToPdfConverter : IImageToPdfConverter
    {
        public void ConvertToPdf(string imageFilePath, string pdfFilePath)
        {
            ToPdf convertToPdf = new ToPdf();
            convertToPdf.ConvertImageToPdf(imageFilePath, pdfFilePath);
        }
    }
}
