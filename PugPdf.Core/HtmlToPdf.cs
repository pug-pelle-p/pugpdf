using System.Threading.Tasks;

namespace PugPdf.Core
{
    public class HtmlToPdf
    {
        public PdfPrintOptions PrintOptions { get; set; } = new PdfPrintOptions();
        public PdfHeader Header { get; set; } = new PdfHeader();
        public PdfFooter Footer { get; set; } = new PdfFooter();

        public async Task<PdfDocument> RenderHtmlAsPdfAsync(string html)
        {
            var switches = string.Concat(PrintOptions?.GetSwitches(), Header?.GetSwitches(), Footer?.GetSwitches());

            var data = await WkHtmlToPdfDriver.ConvertAsync(html, switches);

            return new PdfDocument(data);
        }
    }
}