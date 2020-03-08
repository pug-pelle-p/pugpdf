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
            var renderer = new HtmlToPdf();

            renderer.PrintOptions.Title = "Kalle";
            
            var pdf = await renderer.RenderHtmlAsPdfAsync("<html><body><h1>Pelle</h1></body></html>");

            var filePath = await pdf.SaveInTempFolderAsync();

            Console.WriteLine(filePath);
            
            Console.ReadLine();
        }
    }
}