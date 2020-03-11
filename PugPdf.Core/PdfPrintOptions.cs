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
            
            switches += "--disable-smart-shrinking ";

            return switches;
        }
    }
}