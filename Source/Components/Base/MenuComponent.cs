using CliMenu.Source.Interface;

namespace CliMenu.Source.Components.Base;

/// <summary>
/// Initializes a new instance of the <see cref="MenuComponent"/> class with the specified name.
/// </summary>
/// <param name="componentName">The name of the component. It must be unique inside his <see cref="Menus.BaseMenu"/> or <see cref="Group{T}"/> </param>
public abstract class MenuComponent(string componentName) : IFocusable
{
    private bool isFocused;

    /// <summary>
    /// Gets the name of the menu component.
    /// </summary>
    public string Name => componentName;

    /// <summary>
    /// Gets or sets a value indicating whether the component is currently focused.
    /// When set, triggers <see cref="OnFocus"/> or <see cref="OnBlur"/> accordingly.
    /// </summary>
    public bool IsFocused
    {
        get => isFocused;
        set
        {
            isFocused = value;

            if (value) OnFocus();
            else OnBlur();
        }
    }

    /// <summary>
    /// Called when the component gains focus.
    /// Override this method to implement custom focus behavior.
    /// </summary>
    public virtual void OnFocus() { }

    /// <summary>
    /// Called when the component loses focus.
    /// Override this method to implement custom blur behavior.
    /// </summary>
    public virtual void OnBlur() { }
}