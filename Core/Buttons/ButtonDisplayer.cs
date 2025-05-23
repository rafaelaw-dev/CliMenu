using CliMenu.Helpers;
using CliMenu.Interfaces;

namespace CliMenu.Core.Buttons
{
    public class ButtonDisplayer(ButtonVisual visual, string displayFormat = "[<label>]") : IDisplayer
    {
        private readonly string displayFormat = displayFormat;
        private readonly ButtonVisual visual = visual;

        public void Display()
        {
            Console.ForegroundColor = visual.Color;
            Console.Write(ParseDisplayFormat());
            Console.ResetColor();
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