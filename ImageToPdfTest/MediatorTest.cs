using ImageToPdf.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImageToPdfTest
{
    [TestClass]
    public class MediatorTest
    {
        [TestMethod]
        public void GetImageConverter_ITextSharpConverter_Success()
        {
            Mediator mediator = new Mediator();
            var obj = mediator.GetImageConverter(ImageToPdf.ImageToPdfConverter.ITEXTSHARP);

            Assert.IsInstanceOfType(new ITextSharpImageToPdfConverter(), obj.GetType());
        }

        [TestMethod]
        public void GetImageConverter_PDFSharpConverter_Success()
        {
            Mediator mediator = new Mediator();
            var obj = mediator.GetImageConverter(ImageToPdf.ImageToPdfConverter.PDFSHARPCORE);

            Assert.IsInstanceOfType(new PdfSharpCoreImageToPdfConverter(), obj.GetType());
        }
        
    }
}
