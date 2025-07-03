using CliMenu.Source.Base;
using CliMenu.Source.Components;
using CliMenu.Source.Components.Helpers;


public class Program
{
    public static void Main()
    {
        Label label = new("component", "Ola", new NoExecutable(), new CustomLabelDisplayer(label), )
    }
}

internal class CustomLabelDisplayer(Label component) : Displayer<Label>(component)
{
    public override string GetDisplay()
    {
        return "lol";
    }
}