using CliMenu.Components.Base;
using CliMenu.Components.Behaviors;
using CliMenu.Components.DefaultComponents.BarBehaviors;
using CliMenu.Components.DefaultComponents.SliderBehaviors;
using CliMenu.Helpers;
using CliMenu.Helpers.NoOp;

namespace CliMenu.Components.DefaultComponents;

/// <summary>
/// A slider component that visually represents a modifiable percentage bar.
/// Wraps an internal <see cref="Bar"/> and allows value modification via input keys.
/// </summary>
public sealed class SliderBar : BaseComponent<Displayer<Bar>, InputHandler<SliderBar>>
{
    /// <summary>
    /// The inner <see cref="Bar"/> component used for rendering the slider percentage.
    /// </summary>
    public Bar InnerBar { get; }

    /// <summary>
    /// The rate at which the percentage is incremented or decremented when keys are pressed.
    /// </summary>
    public int Rate { get; }

    /// <inheritdoc/>
    protected override ComponentConfig<Displayer<Bar>, InputHandler<SliderBar>> Defaults => new(
        new BarDisplayer(),
        new SliderInput()
    );

    /// <summary>
    /// Initializes a new instance of the <see cref="SliderBar"/> class.
    /// </summary>
    /// <param name="name">The name of the component.</param>
    /// <param name="rate">The amount the percentage changes on input (default is 1).</param>
    /// <param name="initialPercentage">The initial percentage to be displayed by the bar.</param>
    /// <param name="config">Optional configuration for custom behavior and rendering.</param>
    /// <param name="enableOnStart">Whether the component is enabled upon start (default is true).</param>
    public SliderBar(
        string name,
        int rate = 1,
        int initialPercentage = 0,
        ComponentConfig<Displayer<Bar>, InputHandler<SliderBar>>? config = null,
        bool enableOnStart = true)
    : base(name, config, enableOnStart)
    {
        config ??= Defaults;
        Rate = rate;
        InnerBar = new($"{name}.innerBar", initialPercentage, new(config.Disp, new NoInput(), new NoFocus()));
    }
}