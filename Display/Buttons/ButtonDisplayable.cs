using CliMenu.Helpers;
using CliMenu.Abstract.Interfaces;

namespace CliMenu.Display.Buttons
{
    public class ButtonDisplayable : IDisplayable
    {
        private readonly string displayFormat;
        private readonly ButtonVisual visual;

        public ButtonDisplayable(ButtonVisual visual, string displayFormat = "[<label>]")
        {
            this.displayFormat = displayFormat;
            this.visual = visual;
        }

        public string GetDisplay()
        {
            return ParseDisplayFormat();
        }

        private string ParseDisplayFormat()
        {
            Dictionary<string, string> parseCode = new Dictionary<string, string>
            {
                {"label", visual.ButtonLabel},
                {"symbol", visual.ButtonSymbol.ToString() ?? ""},
            };

            return DisplayFormatParser.Parse(displayFormat, parseCode);
        }
    }
}