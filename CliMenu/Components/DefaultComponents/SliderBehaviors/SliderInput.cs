using CliMenu.Components.Behaviors;

namespace CliMenu.Components.DefaultComponents.SliderBehaviors;

/// <summary>
/// Input handler for the <see cref="SliderBar"/> component.
/// Handles increasing and decreasing the slider value using keyboard keys.
/// </summary>
public class SliderInput : BetterInputHandler<SliderBar>
{
    /// <summary>
    /// The key used to decrease the slider's value.
    /// Defaults to the left arrow key.
    /// </summary>
    public ConsoleKey DecreaseKey = ConsoleKey.LeftArrow;

    /// <summary>
    /// The key used to increase the slider's value.
    /// Defaults to the right arrow key.
    /// </summary>
    public ConsoleKey IncreaseKey = ConsoleKey.RightArrow;

    public SliderInput()
    {
        AddKey(DecreaseKey, slider => slider.InnerBar.Percentage -= slider.Rate);
        AddKey(IncreaseKey, slider => slider.InnerBar.Percentage += slider.Rate);
    }
}