using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf;
using System;

namespace ImageToPdfUsingPdfSharpCore
{
    public class ToPdf
    {
        public void ConvertImageToPdf(string imagePath,string pdfPath)
        {
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Created Using PDFSharpCore";
            document.Info.Subject = "ImageToPdf";
            document.Info.ModificationDate = DateTime.Now;

            PdfPage page = document.AddPage();
            page.Size = PdfSharpCore.PageSize.A4;
            
            XGraphics graphics = XGraphics.FromPdfPage(page);
            XImage image = XImage.FromFile(imagePath);
            graphics.DrawImage(image, 2, 2, image.PointWidth, image.PointHeight);

            document.Save(pdfPath);
        }
    }
}
