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

            renderer.PrintOptions.Title = "My title";
            
            var pdf = await renderer.RenderHtmlAsPdfAsync("<h1>Hello world</h1>");

            await pdf.SaveAsAsync("c:\\my.pdf");
            
            var filePath = await pdf.SaveInTempFolderAsync();

            Console.WriteLine(filePath);
            
            Console.ReadLine();
        }
    }
}