using System.Text;

namespace PugPdf.Core
{
    public class PdfFooter
    {
        public string LeftText { get; set; } = string.Empty;
        public string CenterText { get; set; } = string.Empty;
        public string RightText { get; set; } = string.Empty;
        public string HTMLUrl { get; set; } = string.Empty;
        public bool DisplayLine { get; set; } = false;
        public string FontName { get; set; } = "Arial";
        public double FontSize { get; set; } = 12d;
        public int Spacing { get; set; } = 0;
        public string Replace { get; set; } = string.Empty;

        public string GetSwitches()
        {
            var switchesBuilder = new StringBuilder();

            if (!string.IsNullOrEmpty(LeftText))
                switchesBuilder.Append($"--footer-left \"{LeftText}\" ");

            if (!string.IsNullOrEmpty(CenterText))
                switchesBuilder.Append($"--footer-center \"{CenterText}\" ");

            if (!string.IsNullOrEmpty(RightText))
                switchesBuilder.Append($"--footer-right \"{RightText}\" ");

            if (!string.IsNullOrEmpty(HTMLUrl))
                switchesBuilder.Append($"--footer-html \"{HTMLUrl}\" ");

            if (DisplayLine)
                switchesBuilder.Append("--footer-line ");

            switchesBuilder.Append($"--footer-font-size {FontSize} ");
            switchesBuilder.Append($"--footer-font-name {FontName} ");
            switchesBuilder.Append($"--footer-spacing {Spacing} ");

            if (!string.IsNullOrEmpty(Replace))
                switchesBuilder.Append($"--replace {Replace} ");

            return switchesBuilder.ToString();
        }
    }
}
