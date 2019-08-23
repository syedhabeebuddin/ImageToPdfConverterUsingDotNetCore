using ImageToPdf.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ImageToPdfTest
{
    [TestClass]
    public class ITextSharpImageToPdfConverterTest
    {
        [TestMethod]
        public void ConvertToPdf_EmptyPaths_ThrowException()
        {
            ImageToPdf.Classes.
            ITextSharpImageToPdfConverter converter = new ITextSharpImageToPdfConverter();

            Assert.ThrowsException<ArgumentNullException>(() => converter.ConvertToPdf("", ""));
        }

        [TestMethod]
        public void ConvertToPdf_WrongFileType_ThrowException()
        {
            ImageToPdf.Classes.
            ITextSharpImageToPdfConverter converter = new ITextSharpImageToPdfConverter();

            Assert.ThrowsException<InvalidDataException>(() => converter.ConvertToPdf("Test.txt", "Test.pdf"));
        }

        [TestMethod]
        public void ConvertToPdf_Success()
        {
            ImageToPdf.Classes.
            ITextSharpImageToPdfConverter converter = new ITextSharpImageToPdfConverter();
            converter.ConvertToPdf("Android_Error.png", "Error1.pdf");

            Assert.IsTrue(File.Exists("Error1.pdf"));
        }
    }
}
