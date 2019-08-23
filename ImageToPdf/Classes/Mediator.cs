using System;
using System.Collections.Generic;
using System.Text;

namespace ImageToPdf.Classes
{
    public class Mediator
    {
        public IImageToPdfConverter GetImageConverter(ImageToPdfConverter pdfConverter)
        {
            IImageToPdfConverter imageToPdfConverter = null;
            if (pdfConverter.Equals(ImageToPdfConverter.PDFSHARPCORE))
                imageToPdfConverter = new PdfSharpCoreImageToPdfConverter();
            else
                imageToPdfConverter = new ITextSharpImageToPdfConverter();

            return imageToPdfConverter;
        }
    }
}
