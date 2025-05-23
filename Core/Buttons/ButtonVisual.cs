namespace CliMenu.Core.Buttons
{
    public class ButtonVisual(string label, char? symbol)
    {
        public string ButtonLabel { get; private set; } = label;
        public char? ButtonSymbol { get; private set; } = symbol;
 
        public bool IsVisible { private get; set; }
        public bool IsClickable { private get; set; }
        public ConsoleColor Color { get; set; }
    }
}