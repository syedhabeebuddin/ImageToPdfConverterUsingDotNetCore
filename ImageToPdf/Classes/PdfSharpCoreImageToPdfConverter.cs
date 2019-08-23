using ImageToPdfUsingPdfSharpCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ImageToPdf.Classes
{
    public class PdfSharpCoreImageToPdfConverter : IImageToPdfConverter
    {
        public void ConvertToPdf(string imageFilePath, string pdfFilePath)
        {
            if (string.IsNullOrEmpty(imageFilePath)) throw new ArgumentNullException();
            if (string.IsNullOrEmpty(pdfFilePath)) throw new ArgumentNullException();

            FileInfo fileInfo = new FileInfo(imageFilePath);
            string fileType = fileInfo.Extension.Trim();
            if (!(fileType.Equals(".jpg") || fileType.Equals(".png") || fileType.Equals(".ico"))) throw new InvalidDataException();

            ToPdf convertToPdf = new ToPdf();
            convertToPdf.ConvertImageToPdf(imageFilePath, pdfFilePath);
        }
    }
}
