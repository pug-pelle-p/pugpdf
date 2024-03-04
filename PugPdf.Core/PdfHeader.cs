using System.Text;

namespace PugPdf.Core
{
    public class PdfHeader
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
                switchesBuilder.Append($"--header-left \"{LeftText}\" ");

            if (!string.IsNullOrEmpty(CenterText))
                switchesBuilder.Append($"--header-center \"{CenterText}\" ");

            if (!string.IsNullOrEmpty(RightText))
                switchesBuilder.Append($"--header-right \"{RightText}\" ");

            if (!string.IsNullOrEmpty(HTMLUrl))
                switchesBuilder.Append($"--header-html \"{HTMLUrl}\" ");

            if (DisplayLine)
                switchesBuilder.Append("--header-line ");

            switchesBuilder.Append($"--header-font-size {FontSize} ");
            switchesBuilder.Append($"--header-font-name {FontName} ");
            switchesBuilder.Append($"--header-spacing {Spacing} ");

            if (!string.IsNullOrEmpty(Replace))
                switchesBuilder.Append($"--replace {Replace} ");

            return switchesBuilder.ToString();
        }
    }
}
