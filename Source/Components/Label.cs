using CliMenu.Source.Components.Base;

namespace CliMenu.Source.Components;

public class Label(string componentName, string text) : MenuComponent(componentName)
{
    public string Text => text;
}
