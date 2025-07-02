using CliMenu.Source.Components.Base;

namespace CliMenu.Source.Components;

/// <summary>
/// Represents an action button component that can trigger one or more callbacks when executed.
/// </summary>
/// <param name="componentName">The name of the component. It must be unique inside his <see cref="Menus.BaseMenu"/> or <see cref="Group{T}"/> </param>
/// <param name="buttonText">The text label displayed on the button.</param>
public class ActionButton(string componentName, string buttonText) : MenuComponent(componentName)
{
    /// <summary>
    /// Event that stores the callbacks to be invoked when the button is executed.
    /// </summary>
    protected event EventHandler? Callback;

    /// <summary>
    /// Gets the text label of the button.
    /// </summary>
    public string Text => buttonText;

    /// <summary>
    /// Adds a callback to be invoked when the button is executed.
    /// </summary>
    /// <param name="callback">The callback method to add.</param>
    public virtual void AddCallback(EventHandler callback) =>
        Callback += callback;

    /// <summary>
    /// Removes a previously added callback.
    /// </summary>
    /// <param name="callback">The callback method to remove.</param>
    public virtual void RemoveCallback(EventHandler callback) =>
        Callback -= callback;

    /// <summary>
    /// Executes the button's callbacks, using this instance as the event sender.
    /// </summary>
    /// <param name="e">Optional event arguments. Defaults to <see cref="EventArgs.Empty"/> if null.</param>
    public void Execute(EventArgs? e = null) =>
        InvokeEvent(this, e ?? EventArgs.Empty);

    /// <summary>
    /// Executes the button's callbacks with the specified sender and event arguments.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The event arguments.</param>
    public void Execute(object? sender, EventArgs e) =>
        InvokeEvent(sender, e);
        
    /// <summary>
    /// Invokes the registered callbacks with the provided sender and event arguments.
    /// Can be overridden to customize callback invocation behavior.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The event arguments.</param>
    protected virtual void InvokeEvent(object? sender, EventArgs e) =>
        Callback?.Invoke(sender, e);
}
