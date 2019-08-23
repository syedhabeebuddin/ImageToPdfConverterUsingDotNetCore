using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using ImageToPdf.Classes;
using System.IO;

namespace ImageToPdfTest
{
    [TestClass]
    public class PdfSharpCoreImageToPdfConverterTest
    {
        [TestMethod]
        public void ConvertToPdf_EmptyPaths_ThrowException()
        {
            ImageToPdf.Classes.
            PdfSharpCoreImageToPdfConverter converter = new PdfSharpCoreImageToPdfConverter();
            
            Assert.ThrowsException<ArgumentNullException>(() => converter.ConvertToPdf("", ""));
        }

        [TestMethod]
        public void ConvertToPdf_WrongFileType_ThrowException()
        {
            ImageToPdf.Classes.
            PdfSharpCoreImageToPdfConverter converter = new PdfSharpCoreImageToPdfConverter();

            Assert.ThrowsException<InvalidDataException>(() => converter.ConvertToPdf("Test.txt", "Test.pdf"));
        }

        [TestMethod]
        public void ConvertToPdf_Success()
        {
            ImageToPdf.Classes.
            PdfSharpCoreImageToPdfConverter converter = new PdfSharpCoreImageToPdfConverter();
            converter.ConvertToPdf("Android_Error.png", "Error1.pdf");

            Assert.IsTrue(File.Exists("Error1.pdf"));           
        }
    }
}
