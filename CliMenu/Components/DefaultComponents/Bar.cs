using CliMenu.Components.Base;
using CliMenu.Components.Behaviors;
using CliMenu.Components.DefaultComponents.BarBehaviors;
using CliMenu.Helpers;
using CliMenu.Helpers.NoOp;

namespace CliMenu.Components.DefaultComponents;

/// <summary>
/// Represents a non-interactive progress bar component that visually displays a percentage value (0–100%).
/// Can be used to indicate progress, loading states, or resource usage in a menu context.
/// </summary>
public sealed class Bar : BaseComponent<Displayer<Bar>, NoInput>
{
    private double percentage;

    /// <summary>
    /// The current percentage value represented by the bar (0 to 100).
    /// Values outside this range will be clamped automatically.
    /// </summary>
    public double Percentage
    {
        get => percentage;
        set => percentage = Math.Clamp(value, 0, 100);
    }

    /// <inheritdoc/>
    protected override ComponentConfig<Displayer<Bar>, NoInput> Defaults => new(
        new BarDisplayer(),
        new NoInput(),
        new NoFocus()
    );

    /// <summary>
    /// Initializes a new instance of the <see cref="Bar"/> component.
    /// </summary>
    /// <param name="name">Unique identifier for the component.</param>
    /// <param name="initialPercentage">Initial percentage value (clamped between 0 and 100).</param>
    /// <param name="config">Optional configuration to override default behavior.</param>
    /// <param name="enableOnStart">Specifies if the component is active upon creation.</param>
    public Bar(
        string name,
        double initialPercentage,
        ComponentConfig<Displayer<Bar>, NoInput>? config = null,
        bool enableOnStart = true)
    : base(name, config, enableOnStart)
    {
        Percentage = initialPercentage;
    }
}