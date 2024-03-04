using System.Text;

namespace PugPdf.Core
{
    public class PdfPrintOptions
    {
        public double MarginLeft { get; set; } = 10d;
        public double MarginRight { get; set; } = 10d;
        public double MarginTop { get; set; } = 10d;
        public double MarginBottom { get; set; } = 10d;
        public PdfPageSize PageSize { get; set; } = PdfPageSize.A4;
        public PdfOrientation Orientation { get; set; } = PdfOrientation.Portrait;
        public string Title { get; set; }
        public bool LowQuality { get; set; } = false;
        public bool UsePrintMediaType { get; set; } = false;
        public bool Grayscale { get; set; } = false;
        public int ImageDPI { get; set; } = 600;
        public int ImageQuality { get; set; } = 94;
        public int DPI { get; set; } = 96;

        public PdfHeader Header { get; set; } = new PdfHeader();
        public PdfFooter Footer { get; set; } = new PdfFooter();

        public string GetSwitches()
        {
            var switchesBuilder = new StringBuilder();

            switchesBuilder.Append($"--margin-bottom {MarginBottom} ");
            switchesBuilder.Append($"--margin-top {MarginTop} ");
            switchesBuilder.Append($"--margin-left {MarginLeft} ");
            switchesBuilder.Append($"--margin-right {MarginRight} ");

            switchesBuilder.Append($"--page-size {PageSize} ");

            switchesBuilder.Append($"--orientation {Orientation} ");

            if (!string.IsNullOrEmpty(Title))
                switchesBuilder.Append($"--title \"{Title}\" ");

            if (LowQuality)
                switchesBuilder.Append("--lowquality ");

            if (UsePrintMediaType)
                switchesBuilder.Append("--print-media-type ");

            if (Grayscale)
                switchesBuilder.Append("--grayscale ");

            switchesBuilder.Append($"--image-dpi {ImageDPI} ");
            switchesBuilder.Append($"--image-quality {ImageQuality} ");
            switchesBuilder.Append($"--dpi {DPI} ");
            switchesBuilder.Append("--disable-smart-shrinking ");

            switchesBuilder.Append(Header?.GetSwitches());
            switchesBuilder.Append(Footer?.GetSwitches());

            return switchesBuilder.ToString();
        }
    }
}