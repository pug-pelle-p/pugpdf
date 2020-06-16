namespace PugPdf.Core
{
    public class PdfHeader
    {
        public string LeftText { get; set; } = string.Empty;
        public string CenterText { get; set; } = string.Empty;
        public string RightText { get; set; } = string.Empty;
        public string HTML { get; set; } = string.Empty;
        public bool DisplayLine { get; set; } = false;
        public string FontName { get; set; } = "Arial";
        public double FontSize { get; set; } = 12d;
        public int Spacing { get; set; } = 0;
        public string Replace { get; set; } = string.Empty;

        public string GetSwitches()
        {
            var switches = string.Empty;

            if (!string.IsNullOrEmpty(LeftText))
                switches += $"--header-left \"{LeftText}\" ";

            if (!string.IsNullOrEmpty(CenterText))
                switches += $"--header-center \"{CenterText}\" ";

            if (!string.IsNullOrEmpty(RightText))
                switches += $"--header-right \"{RightText}\" ";

            if (!string.IsNullOrEmpty(HTML))
                switches += $"--header-html \"{HTML}\" ";

            if (DisplayLine)
                switches += "--header-line ";

            switches += $"--header-font-size {FontSize} ";
            switches += $"--header-font-name {FontName} ";
            switches += $"--header-spacing {Spacing} ";

            if (!string.IsNullOrEmpty(Replace))
                switches += $"--replace {Replace} ";

            return switches;
        }
    }
}
