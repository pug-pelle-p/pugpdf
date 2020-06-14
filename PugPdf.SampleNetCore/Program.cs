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

        static async Task PrintWithImageFromUrl()
        {
            var renderer = new HtmlToPdf();

            renderer.PrintOptions.Title = "My title";
            
            var pdf = await renderer.RenderHtmlAsPdfAsync("<img src=\"https://www.google.com/images/branding/googlelogo/2x/googlelogo_color_272x92dp.png\"><h1>Hello world</h1>");

            await pdf.SaveAsAsync("c:\\my.pdf");
            
            var filePath = await pdf.SaveInTempFolderAsync();

            Console.WriteLine(filePath);
            
            Console.ReadLine();
        }

        static async Task PrintWithImageFromFile()
        {
            var renderer = new HtmlToPdf();

            renderer.PrintOptions.Title = "My title";
            
            var path = Path.Combine(Directory.GetCurrentDirectory(), "files", "GitHub_Logo.png");
            
            var pdf = await renderer.RenderHtmlAsPdfAsync($"<img src=\"{path}\"><h1>Hello world</h1>");

            await pdf.SaveAsAsync("c:\\my.pdf");
            
            var filePath = await pdf.SaveInTempFolderAsync();

            Console.WriteLine(filePath);
            
            Console.ReadLine();
        }
    }
}