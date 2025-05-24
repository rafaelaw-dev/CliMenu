namespace CliMenu.Display.Buttons
{
    public class ButtonVisual
    {
        public string ButtonLabel { get; set; }
        public char ButtonSymbol { get; set; }
        public ConsoleColor Color { get; set; }

        public ButtonVisual(string label, ConsoleColor color, char symbol = '?')
        {
            ButtonLabel = label;
            ButtonSymbol = symbol;
            Color = color;
        }
    }
}