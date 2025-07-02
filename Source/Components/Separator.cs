using CliMenu.Source.Components.Base;

namespace CliMenu.Source.Components;

public class Separator(string componentName, char separatorChar, int length) : MenuComponent(componentName)
{
    public char SeparatorChar => separatorChar;
    public int Length => length;
}
