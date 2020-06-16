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

        public PdfHeader Header { get; set; } = new PdfHeader();
        public PdfFooter Footer { get; set; } = new PdfFooter();

        public string GetSwitches()
        {
            var switches = string.Empty;

            switches += $"--margin-bottom {MarginBottom} ";
            switches += $"--margin-top {MarginTop} ";
            switches += $"--margin-left {MarginLeft} ";
            switches += $"--margin-right {MarginRight} ";

            switches += $"--page-size {PageSize} ";

            switches += $"--orientation {Orientation} ";

            if (!string.IsNullOrEmpty(Title))
                switches += $"--title \"{Title}\" ";

            if (LowQuality)
                switches += "--lowquality ";

            if (UsePrintMediaType)
                switches += "--print-media-type ";

            if (Grayscale)
                switches += "--grayscale ";

            switches += $"--image-dpi {ImageDPI} ";
            switches += $"--image-quality {ImageQuality} ";
            switches += "--disable-smart-shrinking ";

            switches += Header?.GetSwitches();
            switches += Footer?.GetSwitches();

            return switches;
        }
    }
}