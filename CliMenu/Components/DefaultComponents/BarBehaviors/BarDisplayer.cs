using CliMenu.Components.Behaviors;

namespace CliMenu.Components.DefaultComponents.BarBehaviors;

/// <summary>
/// Defines how the <see cref="Bar"/> component is rendered on screen.
/// Displays a progress-style bar based on the component's percentage value.
/// </summary>
public class BarDisplayer : Displayer<Bar>
{
    /// <inheritdoc/>
    protected override string ProtectedGetDisplay(Bar component)
    {
        int roundedPercentage = (int)Math.Floor(component.Percentage / 5);
        return new string('#', roundedPercentage) + new string('-', 20 - roundedPercentage);
    }
}