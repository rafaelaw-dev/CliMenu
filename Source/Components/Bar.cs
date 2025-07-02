using CliMenu.Source.Components.Base;

namespace CliMenu.Source.Components;

public class Bar(string componentName) : MenuComponent(componentName)
{
    private float _percentage;
    public float Percentage { get => _percentage; set => _percentage = Math.Clamp(value, 0, 100); }
}
