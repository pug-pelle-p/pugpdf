using System;
using System.IO;
using System.Threading.Tasks;
using PugPdf.Core;

namespace PugPdf.SampleNetCore
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var pdf = await WkHtmlToPdfDriver.ConvertAsync("<h1>Hello world</h1>");

            var pdfFilePath = Path.GetTempFileName() + ".pdf";

            File.WriteAllBytes(pdfFilePath, pdf);
            
            Console.WriteLine(pdfFilePath);

            Console.ReadLine();
        }
    }
}