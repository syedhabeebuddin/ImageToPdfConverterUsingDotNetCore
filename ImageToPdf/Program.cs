using ImageToPdf.Classes;
using System;

namespace ImageToPdf
{
    public enum ImageToPdfConverter
    {
        PDFSHARPCORE,
        ITEXTSHARP
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Please enter image file path :");
            var imageFilePath = Console.ReadLine().Trim();

            Console.WriteLine("Please enter Pdf file path :");
            var pdfFilePath = Console.ReadLine().Trim();

            Mediator mediator = new Mediator();
            IImageToPdfConverter converter = mediator.GetImageConverter(ImageToPdfConverter.PDFSHARPCORE);
            converter.ConvertToPdf(imageFilePath, pdfFilePath);

            Console.WriteLine("Image Converted to Pdf Successfully !!");
        }
    }
}
