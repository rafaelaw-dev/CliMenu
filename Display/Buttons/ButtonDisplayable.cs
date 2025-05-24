using CliMenu.Helpers;
using CliMenu.Abstract.Interfaces.Display;

namespace CliMenu.Display.Buttons
{
    /// <summary>
    /// Represents a displayable button with customizable visual formatting.
    /// </summary>
    public class ButtonDisplayable : IDisplayable
    {
        private readonly string displayFormat;
        private readonly ButtonVisual visual;

        /// <summary>
        /// Initializes a new ButtonDisplayable with the given visual and display format.
        /// </summary>
        /// <param name="visual">Visual configuration of the button.</param>
        /// <param name="displayFormat">Format string that defines how the button appears (e.g., "[&lt;label&gt;]").</param>
        public ButtonDisplayable(ButtonVisual visual, string displayFormat = "[<label>]") 
        {
            this.displayFormat = displayFormat;
            this.visual = visual;
        }

        /// <summary>
        /// Returns the formatted string to display the button.
        /// </summary>
        /// <returns>The display string for the button.</returns>
        public string GetDisplay()
        {
            return ParseDisplayFormat();
        }

        /// <summary>
        /// Parses the display format string and replaces tokens with actual values.
        /// </summary>
        /// <returns>A parsed and formatted string.</returns>
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