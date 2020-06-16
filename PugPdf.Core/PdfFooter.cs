namespace PugPdf.Core
{
    public class PdfFooter
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
                switches += $"--footer-left \"{LeftText}\" ";

            if (!string.IsNullOrEmpty(CenterText))
                switches += $"--footer-center \"{CenterText}\" ";

            if (!string.IsNullOrEmpty(RightText))
                switches += $"--footer-right \"{RightText}\" ";

            if (!string.IsNullOrEmpty(HTML))
                switches += $"--footer-html \"{HTML}\" ";

            if (DisplayLine)
                switches += "--footer-line ";

            switches += $"--footer-font-size {FontSize} ";
            switches += $"--footer-font-name {FontName} ";
            switches += $"--footer-spacing {Spacing} ";

            if (!string.IsNullOrEmpty(Replace))
                switches += $"--replace {Replace} ";

            return switches;
        }
    }
}
